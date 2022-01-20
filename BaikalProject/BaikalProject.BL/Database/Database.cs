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
    /// Work with database.
    /// </summary>
    public class Database : IDatabase
    {
        #region Parametrs
        private SqliteConnection connection;
        private string connectionString;
        public int ColumsNumber { get; set; }
        private List<string> columnNames;
        #endregion

        /// <summary>
        /// Open connection with database.
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
        /// Get all names columns from current table.
        /// </summary>
        /// <returns>List with names.</returns>
        public List<string> GetColumnNames()
        {
            return columnNames;
        }

        /// <summary>
        /// Get information about current table.
        /// </summary>
        /// <param name="tableName">Name of table.</param>
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
        /// Get all numbers of positions from table "prob_Positions".
        /// </summary>
        /// <returns>List with numbers of positions.</returns>
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
        /// Get a dictionary with data on the binding of points to a certain water area.
        /// </summary>
        /// <returns>Dictionary with data.</returns>
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
        /// Get coordinates from table "coordinates".
        /// </summary>
        /// <returns>Dictionary with coordinates.</returns>
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
        /// Get list of elements.
        /// </summary>
        /// <param name="element">Name of element.</param>
        /// <returns>Dictionary with numberPositions and elements.</returns>
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
        /// Set all names colums into list.
        /// </summary>
        /// <param name="reader">Current connection into database.</param>
        /// <param name="number">Number of column.</param>
        private void SetColumnNames(SqliteDataReader reader,int number)
        {
            columnNames.Add(reader.GetName(number));
        }

        /// <summary>
        /// Open connection with database.
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
        /// Close connection with database.
        /// </summary>
        private void CloseConnection()
        {
            if(connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Get all data from table.
        /// </summary>
        /// <param name="tableName">Name of table.</param>
        /// <returns>All data information from table.</returns>
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
        /// Insert information into table.
        /// </summary>
        /// <param name="tableName">Name of table.</param>
        /// <param name="data">Insert data information.</param>
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
        /// Delete information into table.
        /// </summary>
        /// <param name="tableName">Name of table.</param>
        /// <param name="idName">Name of id column.</param>
        /// <param name="data">ID number.</param>
        public void DeleteWithTable(string tableName, string idName, string data)
        {
            string query = @"DELETE FROM " + tableName + " WHERE " + idName + " = " + data;
            QueryToDatabase(query);
        }

        /// <summary>
        /// Update information into table.
        /// </summary>
        /// <param name="tableName">Name of table.</param>
        /// <param name="data">Update data information.</param>
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
        /// Send SQL message into database.
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