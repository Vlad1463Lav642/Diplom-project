using System.Collections.Generic;
using System.Data;
using BaikalProject.BL.Other;

namespace BaikalProject.BL.Controller
{

    /// <summary>
    /// Интерфейс для работы с классом database.
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        /// Получить количество столбцов в текущей таблице.
        /// </summary>
        int ColumsNumber { get; set; }

        /// <summary>
        /// Получить имена всех колонок из текущей таблицы.
        /// </summary>
        /// <returns>Строка с именами.</returns>
        List<string> GetColumnNames();

        /// <summary>
        /// Получить все данные их таблицы.
        /// </summary>
        /// <param name="tableName">Имя таблицы.</param>
        /// <returns>Все данные из таблицы.</returns>
        DataTable GetAllDataFromTable(string tableName);

        /// <summary>
        /// Вставить данные в таблицу.
        /// </summary>
        /// <param name="tableName">Имя таблицы.</param>
        /// <param name="data">Данные.</param>
        void InsertIntoTable(string tableName, string data);

        /// <summary>
        /// Удалить данные из таблицы.
        /// </summary>
        /// <param name="tableName">Имя таблицы.</param>
        /// <param name="idName">Наименование столбца ID.</param>
        /// <param name="data">Номер ID.</param>
        void DeleteWithTable(string tableName, string idName, string data);

        /// <summary>
        /// Обновить данные в таблице.
        /// </summary>
        /// <param name="tableName">Имя таблицы.</param>
        /// <param name="data">Данные.</param>
        void UpdateInTable(string tableName, string data);

        /// <summary>
        /// Получить все позиции из таблицы "prob_Positions".
        /// </summary>
        /// <returns>Список с позициями.</returns>
        List<string> GetNumberPositions();

        /// <summary>
        /// Получить информацию о данной таблице.
        /// </summary>
        /// <param name="tableName">Имя таблицы.</param>
        void GetInformationAboutTable(string tableName);

        /// <summary>
        /// Получить координаты из таблицы "coordinates".
        /// </summary>
        /// <returns>Словарь с координатами.</returns>
        Dictionary<string, MapPoint> GetCoordinates();

        /// <summary>
        /// Получить словарь с элементами.
        /// </summary>
        /// <param name="element">Имя элемента.</param>
        /// <returns>Словарь с позициями и элементами.</returns>
        Dictionary<string, double> GetOilOrElements(string element);

        /// <summary>
        /// Получить словарь с данными о привязке точек к определенной акватории.
        /// </summary>
        /// <returns>Словарь с данными.</returns>
        Dictionary<string, int> GetPositionsOfAquatories();
    }
}