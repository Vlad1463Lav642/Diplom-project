using MaterialSkin.Controls;

namespace BaikalProject.View
{
    public partial class HelpWindow : MaterialForm
    {
        #region Параметры
        private static HelpWindow instance;
        private readonly MaterialSkin.MaterialSkinManager skinManager = null;
        #endregion

        public HelpWindow()
        {
            InitializeComponent();
            
            MainWindow.themeSelector(skinManager, this);
        }

        /// <summary>
        /// Проверка на существование. (Синглтон).
        /// </summary>
        /// <returns></returns>
        public static HelpWindow GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new HelpWindow();
            }
            return instance;
        }

        /// <summary>
        /// Установить информацию в label.
        /// </summary>
        /// <param name="text">Text data.</param>
        public void SetText(string text)
        {
            helpLabel.Text = text;
        }
    }
}