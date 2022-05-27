using System;
using System.Collections.Generic;
using BaikalProject.BL.Other;
using BaikalProject.BL.Controller;
using BaikalProject.BL.Database;
using MaterialSkin.Controls;

namespace BaikalProject.View
{
    public partial class PointsWindow : MaterialForm
    {

        #region Параметры
        private Dictionary<string,int> numberPointsAndAquatories;
        private List<string> selectedPoints;
        public MathematicModelWindow currentMathematicModelWindow;
        private IDatabase database;
        private readonly MaterialSkin.MaterialSkinManager skinManager = null;
        #endregion

        /// <summary>
        /// Окно с точками проботбора.
        /// </summary>
        public PointsWindow()
        {
            InitializeComponent();

            selectedPoints = new List<string>();
            database = new Database();
            numberPointsAndAquatories = database.GetPositionsOfAquatories();


            foreach(var point in numberPointsAndAquatories.Keys)
            {
                CreatePointElement(point);
            }

            MainWindow.themeSelector(skinManager, this);
        }

        /// <summary>
        /// Создать CheckButton элемент.
        /// </summary>
        /// <param name="number">Количество элементов</param>
        private void CreatePointElement(string number)
        {
            switch (numberPointsAndAquatories[number])
            {
                case 1:
                    nouthCheckedList.Items.Add(number);
                    break;
                case 2:
                    centerCheckedList.Items.Add(number);
                    break;
                case 3:
                    southCheckedList.Items.Add(number);
                    break;
            }
        }

        /// <summary>
        /// Получить список с выбранными точками.
        /// </summary>
        /// <param name="listBox">Aquatories list.</param>
        private void GetCheckedData(MaterialCheckedListBox listBox)
        {
            foreach (var item in listBox.Items)
            {
                if(item.Checked == true)
                {
                    selectedPoints.Add(item.Text);
                }
            }
        }

        /// <summary>
        /// Отправка списка с выбранными точками в карту и закрытие окна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endButton_Click(object sender, EventArgs e)
        {
            GetCheckedData(nouthCheckedList);
            GetCheckedData(centerCheckedList);
            GetCheckedData(southCheckedList);

            if (selectedPoints.Count > 1)
            {
                currentMathematicModelWindow.DrawPolygon(selectedPoints);
                Close();
            }
            else
            {
                string errorText = "Вы выбрали менее двух точек пробоотбора!";
                ErrorWindow.errorText = errorText;
                ErrorWindow errorWindow = new ErrorWindow();
                errorWindow.Show();
                selectedPoints.Clear();
            }
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
            help.SetText(helperStorage.GetDataString("PointsWindow"));
            help.Show();
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            foreach(var item in nouthCheckedList.Items)
            {
                item.Checked = true;
            }
            foreach(var item in centerCheckedList.Items)
            {
                item.Checked = true;
            }
            foreach(var item in southCheckedList.Items)
            {
                item.Checked = true;
            }
        }
    }
}