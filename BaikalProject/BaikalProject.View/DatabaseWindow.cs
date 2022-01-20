using System;
using System.Windows.Forms;
using BaikalProject.BL.Controller;
using BaikalProject.BL.Database;
using BaikalProject.BL.Other;
using ClosedXML.Excel;
using MaterialSkin.Controls;

namespace BaikalProject.View
{
    public partial class DatabaseWindow : MaterialForm
    {
        #region Parametrs
        private IDatabase database;
        private string tableName;
        private readonly MaterialSkin.MaterialSkinManager skinManager = null;
        #endregion

        /// <summary>
        /// DatabaseWindow contains list of info from table of database.
        /// </summary>
        public DatabaseWindow()
        {
            InitializeComponent();

            database = new Database();

            comboBoxTableName.SelectedIndex = 0;
            tableName = comboBoxTableName.SelectedItem.ToString();
            TableUpdate();

            MainWindow.themeSelector(skinManager, this);
        }

        /// <summary>
        /// This function updates label when info in table updates.
        /// </summary>
        public void TableUpdate()
        {
            try
            {
                tableInfo.DataSource = database.GetAllDataFromTable(tableName);
                tableInfo.Update();
                tableInfo.Refresh();
            }
            catch (Exception e)
            {
                string errorText = "Ошибка при получении данных из таблицы - (" + e.Message + ");";
                ErrorWindow.errorText = errorText;
                ErrorWindow errorWindow = new ErrorWindow();
                errorWindow.Show();
            }
        }

        /// <summary>
        /// Select table with combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableName = comboBoxTableName.SelectedItem.ToString();
            TableUpdate();
        }

        /// <summary>
        /// Work with data from database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWorkWithDatabaseClick(object sender, EventArgs e)
        {
            DatabaseWorkWindow.TableName = tableName;

            #region What button is clicked (send button name to DatabaseWorkWindow)
            if (sender.Equals(addButton))
            {
                DatabaseWorkWindow.ButtonClickedName = addButton.Name;
            }
            else
            {
                if (sender.Equals(deleteButton))
                {
                    DatabaseWorkWindow.ButtonClickedName = deleteButton.Name;
                }
                else
                {
                    if (sender.Equals(updateButton))
                    {
                        DatabaseWorkWindow.ButtonClickedName = updateButton.Name;
                    }
                }
            }
            #endregion

            DatabaseWorkWindow databaseWork = new DatabaseWorkWindow();
            databaseWork.currentDatabaseWindow = this;
            databaseWork.Show();
        }

        /// <summary>
        /// Save Excel file with data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excelButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    if (tableInfo.Rows.Count > 0)
                    {
                        dialog.FileName = "TableExcel.xlsx";
                        dialog.Filter = "XLSX (*.xlsx)|*.xlsx";

                        XLWorkbook workbook = new XLWorkbook();
                        var worksheet = workbook.Worksheets.Add("Данные из таблицы");

                        for (int i = 1; i < tableInfo.ColumnCount + 1; i++)
                        {
                            worksheet.Cell(1, i).Value = tableInfo.Columns[i - 1].HeaderText;
                        }

                        for (int j = 0; j < tableInfo.RowCount; j++)
                        {
                            for (int k = 0; k < tableInfo.ColumnCount; k++)
                            {
                                worksheet.Cell(j + 2, k + 1).Value = tableInfo.Rows[j].Cells[k].Value.ToString();
                            }
                        }

                        worksheet.Columns().AdjustToContents();
                        worksheet.Rows().AdjustToContents();

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = dialog.FileName;
                            workbook.SaveAs(fileName);
                            MessageBox.Show("Excel файл сохранен.");
                        }
                    }
                }
            }
            catch
            {
                ErrorWindow.errorText = "Ошибка при экспорте данных в Excel.";
                ErrorWindow error = new ErrorWindow();
                error.Show();
            }
        }

        /// <summary>
        /// Open help window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpButton_Click(object sender, EventArgs e)
        {
            IHelperStorage helperStorage = new HelperStorage();
            HelpWindow help = HelpWindow.GetInstance();
            help.SetText(helperStorage.GetDataString("DatabaseWindow"));
            help.Show();
        }
    }
}