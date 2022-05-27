using System.Collections.Generic;
using System.Drawing;
using BaikalProject.BL.Other;
using BaikalProject.BL.Controller;
using BaikalProject.BL.Database;
using System;
using MaterialSkin.Controls;

namespace BaikalProject.View
{
    public partial class DatabaseWorkWindow : MaterialForm
    {
        #region Параметры
        private const int length = 25;
        private IDatabase database;
        private int X = 20;
        private int Y = 30;
        private int tableColumns;
        private List<string> columnNames;
        public static string TableName { get; set; }
        public static string ButtonClickedName { get; set; }
        private Dictionary<string, MaterialTextBox> columnData;
        private string errorText;
        public DatabaseWindow currentDatabaseWindow;
        private readonly MaterialSkin.MaterialSkinManager skinManager = null;
        #endregion

        /// <summary>
        /// Окно для работы с данными из БД.
        /// </summary>
        public DatabaseWorkWindow()
        {
            InitializeComponent();

            database = new Database();
            columnData = new Dictionary<string, MaterialTextBox>();

            database.GetInformationAboutTable(TableName);
            tableColumns = database.ColumsNumber;
            columnNames = database.GetColumnNames();

            #region Проверка какая кнопка нажата (Создание элементов в окне.)

            switch (ButtonClickedName)
            {
                case "addButton":
                    for (int i = 0; i < tableColumns; i++)
                    {
                        CreateInsertUpdateElement(i);
                    }
                    break;
                case "deleteButton":
                    CreateDeleteElement();
                    break;
                case "updateButton":
                    for (int i = 0; i < tableColumns; i++)
                    {
                        CreateInsertUpdateElement(i);
                    }
                    break;
            }
            #endregion

            MainWindow.themeSelector(skinManager, this);
        }

        /// <summary>
        /// Создание элементов для вставки или обновления данных в таблице.
        /// </summary>
        /// <param name="number">Количество элементов.</param>
        private void CreateInsertUpdateElement(int number)
        {
            Y += length;
            MaterialLabel label = new MaterialLabel();
            label.Location = new Point(X,Y);
            label.Text = columnNames[number];
            panel1.Controls.Add(label);
            label.Show();
            Y += length;
            MaterialTextBox textBox = new MaterialTextBox();
            textBox.Location = new Point(X, Y);
            columnData.Add(columnNames[number], textBox);
            panel1.Controls.Add(textBox);
            textBox.Show();
            Y += length;
        }

        /// <summary>
        /// Создание элементов для удаления.
        /// </summary>
        private void CreateDeleteElement()
        {
            Y += length;
            MaterialLabel label = new MaterialLabel();
            label.Location = new Point(X, Y);
            label.Text = "ID";
            panel1.Controls.Add(label);
            label.Show();
            Y += length;
            MaterialTextBox textBox = new MaterialTextBox();
            textBox.Location = new Point(X, Y);
            columnData.Add(columnNames[0], textBox);
            panel1.Controls.Add(textBox);
            textBox.Show();
        }

        /// <summary>
        /// Сохранить изменения в БД и закрыть окно.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endButton_Click(object sender, System.EventArgs e)
        {
            string result = "";

            #region Проверка какая кнопка нажата (Отправка данных в класс database)

            switch (ButtonClickedName)
            {
                case "addButton":
                    foreach (MaterialTextBox textBox in columnData.Values)
                    {
                        result += textBox.Text + "|";
                    }

                    try
                    {
                        database.InsertIntoTable(TableName, result);
                    }
                    catch (Exception exception)
                    {
                        errorText = "Некоректный SQL запрос - (" + exception.Message + ");";
                        ErrorWindow.errorText = errorText;
                        ErrorWindow errorWindow = new ErrorWindow();
                        errorWindow.Show();
                    }
                    break;
                case "deleteButton":
                    try
                    {
                        database.DeleteWithTable(TableName, columnNames[0], columnData[columnNames[0]].Text);
                    }
                    catch (Exception exception)
                    {
                        errorText = "Некоректный SQL запрос - (" + exception.Message + ");";
                        ErrorWindow.errorText = errorText;
                        ErrorWindow errorWindow = new ErrorWindow();
                        errorWindow.Show();
                    }
                    break;
                case "updateButton":
                    foreach (string key in columnData.Keys)
                    {
                        if (!columnData[key].Text.Equals(""))
                        {
                            result += key + "|" + columnData[key].Text + "|";
                        }
                    }

                    try
                    {
                        database.UpdateInTable(TableName, result);
                    }
                    catch (Exception exception)
                    {
                        errorText = "Некоректный SQL запрос - (" + exception.Message + ");";
                        ErrorWindow.errorText = errorText;
                        ErrorWindow errorWindow = new ErrorWindow();
                        errorWindow.Show();
                    }
                    break;
            }
            columnData.Clear();
            currentDatabaseWindow.TableUpdate();
            Close();
            #endregion
        }

        /// <summary>
        /// Открыть окно помощи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpButton_Click(object sender, EventArgs e)
        {
            IHelperStorage helperStorage = new HelperStorage();
            HelpWindow help = HelpWindow.GetInstance();
            help.SetText(helperStorage.GetDataString("DatabaseWorkWindow"));
            help.Show();
        }
    }
}