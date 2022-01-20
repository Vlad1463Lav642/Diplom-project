using System.Collections.Generic;
using System.Data;
using BaikalProject.BL.Other;

namespace BaikalProject.BL.Controller
{

    /// <summary>
    /// Interface for working with database class.
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        /// Get or set number of all columns from current table. 
        /// </summary>
        int ColumsNumber { get; set; }

        /// <summary>
        /// Get all names columns from current table.
        /// </summary>
        /// <returns>string with names.</returns>
        List<string> GetColumnNames();

        /// <summary>
        /// Get all data from table.
        /// </summary>
        /// <param name="tableName">Name of table.</param>
        /// <returns>All data information from table.</returns>
        DataTable GetAllDataFromTable(string tableName);

        /// <summary>
        /// Insert information into table.
        /// </summary>
        /// <param name="tableName">Name of table.</param>
        /// <param name="data">Insert data information.</param>
        void InsertIntoTable(string tableName, string data);

        /// <summary>
        /// Delete information into table.
        /// </summary>
        /// <param name="tableName">Name of table.</param>
        /// <param name="idName">Name of id column.</param>
        /// <param name="data">ID number.</param>
        void DeleteWithTable(string tableName, string idName, string data);

        /// <summary>
        /// Update information into table.
        /// </summary>
        /// <param name="tableName">Name of table.</param>
        /// <param name="data">Update data information.</param>
        void UpdateInTable(string tableName, string data);

        /// <summary>
        /// Get all numbers of positions from table "prob_Positions".
        /// </summary>
        /// <returns>List with numbers of positions.</returns>
        List<string> GetNumberPositions();

        /// <summary>
        /// Get information about current table.
        /// </summary>
        /// <param name="tableName">Name of table.</param>
        void GetInformationAboutTable(string tableName);

        /// <summary>
        /// Get coordinates from table "coordinates".
        /// </summary>
        /// <returns>Dictionary with coordinates.</returns>
        Dictionary<string, MapPoint> GetCoordinates();

        /// <summary>
        /// Get list of elements.
        /// </summary>
        /// <param name="element">Name of element.</param>
        /// <returns>Dictionary with numberPositions and elements.</returns>
        Dictionary<string, double> GetOilOrElements(string element);

        /// <summary>
        /// Get a dictionary with data on the binding of points to a certain water area.
        /// </summary>
        /// <returns>Dictionary with data.</returns>
        Dictionary<string, int> GetPositionsOfAquatories();
    }
}