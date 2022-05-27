using System;
using Microsoft.Data.Sqlite;
using System.IO;
using BaikalProject.BL.Controller;
using System.Collections.Generic;
using BaikalProject.BL.Other;
using System.Data;


namespace BaikalProject.BL.Database
{
    /// <summary>
    /// Работа с БД.
    /// </summary>
    public class Database : IDatabase
    {
        #region Параметры
        private SqliteConnection connection;
        private string connectionString;
        public int ColumsNumber { get; set; }
        private List<string> columnNames;
        #endregion

        /// <summary>
        /// Соединение с БД.
        /// </summary>
        public Database()
        {
            columnNames = new List<string>();
            connectionString = @"Data Source=baikalBase.db";

            connection = new SqliteConnection(connectionString);

            if (!File.Exists("./baikalBase.db"))
            {
                Console.WriteLine("Database not found!");
            }
        }

        /// <summary>
        /// Получить имена всех колонок из текущей таблицы.
        /// </summary>
        /// <returns>Строка с именами.</returns>
        public List<string> GetColumnNames()
        {
            return columnNames;
        }

        /// <summary>
        /// Получить информацию о данной таблице.
        /// </summary>
        /// <param name="tableName">Имя таблицы.</param>
        public void GetInformationAboutTable(string tableName)
        {
            string query = @"SELECT * FROM  " + tableName;
            var command = connection.CreateCommand();
            command.CommandText = query;
            OpenConnection();
            var result = command.ExecuteReader();
            ColumsNumber = result.FieldCount;

            if(columnNames.Count > 0)
            {
                columnNames.Clear();
            }

            while (result.Read())
            {
                for (int i = 0; i < ColumsNumber; i++)
                {
                    SetColumnNames(result, i);
                }
            }
            CloseConnection();
        }

        /// <summary>
        /// Получить все позиции из таблицы "prob_Positions".
        /// </summary>
        /// <returns>Список с позициями.</returns>
        public List<string> GetNumberPositions()
        {
            string query = @"SELECT ID_prob_position, Number_Position FROM prob_Positions ORDER BY ID_prob_position";
            List<string> numberPositions = new List<string>();

            using(SqliteCommand command = new SqliteCommand(query, connection))
            {
                OpenConnection();
                var result = command.ExecuteReader();

                while (result.Read())
                {
                    numberPositions.Add(result.GetString(1));
                }
                CloseConnection();
            }

            return numberPositions;
        }

        /// <summary>
        /// Получить словарь с данными о привязке точек к определенной акватории.
        /// </summary>
        /// <returns>Словарь с данными.</returns>
        public Dictionary<string,int> GetPositionsOfAquatories()
        {
            Dictionary<string, string> aquatoriesWithID_coordinate = new Dictionary<string, string>();

            string query = @"SELECT ID_coordinate, ID_part_Baikal FROM coordinates ORDER BY ID_coordinate";

            using (SqliteCommand command = new SqliteCommand(query, connection))
            {
                OpenConnection();
                var result = command.ExecuteReader();

                while (result.Read())
                {
                    aquatoriesWithID_coordinate.Add(result.GetString(0), result.GetString(1));
                }
                CloseConnection();
            }

            query = @"SELECT ID_prob_position, Number_Position, ID_coordinate FROM prob_Positions ORDER BY ID_prob_position";

            Dictionary<string, int> aquatoriesNumberPositions = new Dictionary<string, int>();


            using (SqliteCommand command = new SqliteCommand(query, connection))
            {
                OpenConnection();
                var result = command.ExecuteReader();

                while (result.Read())
                {
                    aquatoriesNumberPositions.Add(result.GetString(1), Convert.ToInt32(aquatoriesWithID_coordinate[result.GetString(2)]));
                }
                CloseConnection();
            }

            return aquatoriesNumberPositions;
        }

        /// <summary>
        /// Получить координаты из таблицы "coordinates".
        /// </summary>
        /// <returns>Словарь с координатами.</returns>
        public Dictionary<string,MapPoint> GetCoordinates()
        {
            int i = 0;
            string query = @"SELECT ID_coordinate, Coordinate FROM coordinates ORDER BY ID_coordinate";

            List<string> numberPositions = GetNumberPositions();
            Dictionary<string, MapPoint> pointPositions = new Dictionary<string, MapPoint>();
            List<string> coordinates = new List<string>();
            using(SqliteCommand command = new SqliteCommand(query, connection))
            {
                OpenConnection();
                var result = command.ExecuteReader();

                while (result.Read())
                {
                    coordinates.Add(result.GetString(1));
                }
                CloseConnection();
            }

            query = @"SELECT ID_prob_position, ID_coordinate FROM prob_Positions ORDER BY ID_prob_position";

            using (SqliteCommand command1 = new SqliteCommand(query, connection))
            {
                OpenConnection();
                var result = command1.ExecuteReader();

                while (result.Read())
                {
                    string[] arr = coordinates[Convert.ToInt32(result.GetString(1))-1].Split(';');
                    pointPositions.Add(numberPositions[i], new MapPoint(Convert.ToDouble(arr[0]), Convert.ToDouble(arr[1])));
                    i++;
                }
            }
            return pointPositions;
        }

        /// <summary>
        /// Получить словарь с элементами.
        /// </summary>
        /// <param name="element">Имя элемента.</param>
        /// <returns>Словарь с позициями и элементами.</returns>
        public Dictionary<string, double> GetOilOrElements(string element)
        {
            string query = @"SELECT ID_oil, " + element + " FROM oil_Products_And_Elements ORDER BY ID_oil";
            Dictionary<string, double> oilsAndElements = new Dictionary<string, double>();
            List<string> numberPositions = GetNumberPositions();

            using(SqliteCommand command = new SqliteCommand(query, connection))
            {
                OpenConnection();
                var result = command.ExecuteReader();
                int i = 0;

                while (result.Read())
                {
                    oilsAndElements.Add(numberPositions[i], Convert.ToDouble(result.GetString(1)));
                    i++;
                }
                CloseConnection();
            }

            return oilsAndElements;
        }

        /// <summary>
        /// Добавить имена столбцов в список.
        /// </summary>
        /// <param name="reader">Текущее подключение к БД.</param>
        /// <param name="number">Номер столбца.</param>
        private void SetColumnNames(SqliteDataReader reader,int number)
        {
            columnNames.Add(reader.GetName(number));
        }

        /// <summary>
        /// Открыть соединение с БД.
        /// </summary>
        private void OpenConnection()
        {
            if(connection.State != ConnectionState.Open)
            {
                SQLitePCL.Batteries.Init();
                connection.Open();
            }
        }

        /// <summary>
        /// Закрыть соединение с БД.
        /// </summary>
        private void CloseConnection()
        {
            if(connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Получить все данные их таблицы.
        /// </summary>
        /// <param name="tableName">Имя таблицы.</param>
        /// <returns>Все данные из таблицы.</returns>
        public DataTable GetAllDataFromTable(string tableName)
        {
            string query = @"SELECT * FROM " + tableName;
            DataTable dataTable = new DataTable();

            using (SqliteCommand command = new SqliteCommand(query, connection))
            {
                OpenConnection();
                var result = command.ExecuteReader();
                dataTable.Load(result);
                CloseConnection();
            }

            return dataTable;
        }

        /// <summary>
        /// Вставить данные в таблицу.
        /// </summary>
        /// <param name="tableName">Имя таблицы.</param>
        /// <param name="data">Данные.</param>
        public void InsertIntoTable(string tableName,string data)
        {
            string[] result = data.Split('|');
            string resStr = "";

            #region Working with data
            for(int i = 0; i < result.Length - 1; i++)
            {
                if (i > 0 && i < result.Length - 2)
                {
                    resStr += "'" + result[i] + "'" + ",";
                }
                else
                {
                    if(i == result.Length - 2)
                    {
                        resStr += "'" + result[i] + "'";
                    }
                    else
                    {
                        if (i == 0)
                        {
                            resStr += result[i] + ",";
                        }
                    }
                }
            }
            #endregion
            string query = @"INSERT INTO " + tableName + " VALUES (" + resStr + ")";
            QueryToDatabase(query);
        }

        /// <summary>
        /// Удалить данные из таблицы.
        /// </summary>
        /// <param name="tableName">Имя таблицы.</param>
        /// <param name="idName">Наименование столбца ID.</param>
        /// <param name="data">Номер ID.</param>
        public void DeleteWithTable(string tableName, string idName, string data)
        {
            string query = @"DELETE FROM " + tableName + " WHERE " + idName + " = " + data;
            QueryToDatabase(query);
        }

        /// <summary>
        /// Обновить данные в таблице.
        /// </summary>
        /// <param name="tableName">Имя таблицы.</param>
        /// <param name="data">Данные.</param>
        public void UpdateInTable(string tableName, string data)
        {
            string[] result = data.Split('|');
            string resStr = "";

            for(int i = 3; i < result.Length - 1; i+=2)
            {
                if(i < result.Length - 2)
                {
                    resStr += result[i-1] + " = " + "'" + result[i] + "'" + ",";
                }
                else
                {
                    if(i == result.Length - 2)
                    {
                        resStr += result[i - 1] + " = " + "'" + result[i] + "'";
                    }
                }
            }
            string query = @"UPDATE " + tableName + " SET " + resStr + " WHERE " + result[0] + " = " + result[1];
            QueryToDatabase(query);
        }

        /// <summary>
        /// Отправить SQL запрос в БД.
        /// </summary>
        /// <param name="query">SQL message.</param>
        private void QueryToDatabase(string query)
        {
            using(SqliteCommand command = new SqliteCommand(query, connection))
            {
                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}