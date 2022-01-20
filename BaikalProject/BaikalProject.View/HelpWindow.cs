using MaterialSkin.Controls;

namespace BaikalProject.View
{
    public partial class HelpWindow : MaterialForm
    {
        #region Parametrs
        private static HelpWindow instance;
        private readonly MaterialSkin.MaterialSkinManager skinManager = null;
        #endregion

        public HelpWindow()
        {
            InitializeComponent();
            
            MainWindow.themeSelector(skinManager, this);
        }

        /// <summary>
        /// Check for singleton.
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
        /// Set information into label.
        /// </summary>
        /// <param name="text">Text data.</param>
        public void SetText(string text)
        {
            helpLabel.Text = text;
        }
    }
}