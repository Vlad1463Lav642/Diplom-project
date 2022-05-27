using MaterialSkin.Controls;

namespace BaikalProject.View
{
    public partial class ErrorWindow : MaterialForm
    {

        #region Параметры
        public static string errorText { get; set; }
        private readonly MaterialSkin.MaterialSkinManager skinManager = null;
        #endregion

        public ErrorWindow()
        {
            InitializeComponent();

            errorTextLabel.Text = errorText;

            MainWindow.themeSelector(skinManager, this);
        }
    }
}