using System;
using System.Windows.Forms;
using BaikalProject.BL.Controller;
using BaikalProject.BL.Other;
using MaterialSkin.Controls;

namespace BaikalProject.View
{
    public partial class MainWindow : MaterialForm
    {
        #region Параметры
        private readonly MaterialSkin.MaterialSkinManager skinManager = null;
        public static bool helpSelected = true;
        public static bool themeSelected = false;
        #endregion

        /// <summary>
        /// Окно "Главное меню".
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            themeSelector(skinManager, this);
        }

        /// <summary>
        /// Открыть окно для работы с БД.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void database_Click(object sender, EventArgs e)
        {
            DatabaseWindow databaseWindow = new DatabaseWindow();
            databaseWindow.Show();
        }

        /// <summary>
        /// Открыть окно для работы с картой.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mathematicModel_Click(object sender, EventArgs e)
        {
            MathematicModelWindow modelWindow = new MathematicModelWindow();
            modelWindow.Show();
        }

        /// <summary>
        /// Закрыть программу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Выбрать тему программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void themeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            themeSelected = themeSwitch.Checked;
            themeSelector(skinManager,this);
        }

        /// <summary>
        /// Установить выбранную тему.
        /// </summary>
        /// <param name="skin">MaterialSkinManager текущего окна.</param>
        /// <param name="form">Текущее окно.</param>
        public static void themeSelector(MaterialSkin.MaterialSkinManager skin, MaterialForm form)
        {
            if (themeSelected == true)
            {
                skin = MaterialSkin.MaterialSkinManager.Instance;
                skin.EnforceBackcolorOnAllComponents = true;
                skin.AddFormToManage(form);
                skin.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
                skin.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple500, MaterialSkin.Primary.Purple700, MaterialSkin.Primary.Purple100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.BLACK);
            }
            else
            {
                skin = MaterialSkin.MaterialSkinManager.Instance;
                skin.EnforceBackcolorOnAllComponents = true;
                skin.AddFormToManage(form);
                skin.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
                skin.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
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
            help.SetText(helperStorage.GetDataString("MainWindow"));
            help.Show();
        }
    }
}