
namespace BaikalProject.View
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.mainButton = new System.Windows.Forms.TabPage();
            this.helpButton = new MaterialSkin.Controls.MaterialButton();
            this.exitButton = new MaterialSkin.Controls.MaterialButton();
            this.mathematicModelButton = new MaterialSkin.Controls.MaterialButton();
            this.databaseButton = new MaterialSkin.Controls.MaterialButton();
            this.settingsButton = new System.Windows.Forms.TabPage();
            this.themeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.aboutButton = new System.Windows.Forms.TabPage();
            this.emailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.aboutEmailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.authorsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.mainButton.SuspendLayout();
            this.settingsButton.SuspendLayout();
            this.aboutButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.mainButton);
            this.materialTabControl1.Controls.Add(this.settingsButton);
            this.materialTabControl1.Controls.Add(this.aboutButton);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(2, 2);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(596, 362);
            this.materialTabControl1.TabIndex = 4;
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.Color.White;
            this.mainButton.Controls.Add(this.helpButton);
            this.mainButton.Controls.Add(this.exitButton);
            this.mainButton.Controls.Add(this.mathematicModelButton);
            this.mainButton.Controls.Add(this.databaseButton);
            this.mainButton.ImageKey = "house.png";
            this.mainButton.Location = new System.Drawing.Point(4, 39);
            this.mainButton.Margin = new System.Windows.Forms.Padding(2);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(588, 319);
            this.mainButton.TabIndex = 2;
            this.mainButton.Text = "Главная";
            // 
            // helpButton
            // 
            this.helpButton.AutoSize = false;
            this.helpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.helpButton.Depth = 0;
            this.helpButton.HighEmphasis = true;
            this.helpButton.Icon = global::BaikalProject.View.Properties.Resources.help_small;
            this.helpButton.ImageKey = "(отсутствует)";
            this.helpButton.Location = new System.Drawing.Point(4, 259);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(41, 36);
            this.helpButton.TabIndex = 6;
            this.helpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.helpButton.UseAccentColor = false;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = false;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitButton.Depth = 0;
            this.exitButton.HighEmphasis = true;
            this.exitButton.Icon = null;
            this.exitButton.Location = new System.Drawing.Point(51, 200);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(438, 33);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход";
            this.exitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exitButton.UseAccentColor = false;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exit_Click);
            // 
            // mathematicModelButton
            // 
            this.mathematicModelButton.AutoSize = false;
            this.mathematicModelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mathematicModelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mathematicModelButton.Depth = 0;
            this.mathematicModelButton.HighEmphasis = true;
            this.mathematicModelButton.Icon = null;
            this.mathematicModelButton.Location = new System.Drawing.Point(51, 157);
            this.mathematicModelButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mathematicModelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.mathematicModelButton.Name = "mathematicModelButton";
            this.mathematicModelButton.Size = new System.Drawing.Size(438, 33);
            this.mathematicModelButton.TabIndex = 4;
            this.mathematicModelButton.Text = "Работа с картой";
            this.mathematicModelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mathematicModelButton.UseAccentColor = false;
            this.mathematicModelButton.UseVisualStyleBackColor = true;
            this.mathematicModelButton.Click += new System.EventHandler(this.mathematicModel_Click);
            // 
            // databaseButton
            // 
            this.databaseButton.AutoSize = false;
            this.databaseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.databaseButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.databaseButton.Depth = 0;
            this.databaseButton.HighEmphasis = true;
            this.databaseButton.Icon = null;
            this.databaseButton.Location = new System.Drawing.Point(51, 114);
            this.databaseButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.databaseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.databaseButton.Name = "databaseButton";
            this.databaseButton.Size = new System.Drawing.Size(438, 33);
            this.databaseButton.TabIndex = 3;
            this.databaseButton.Text = "Работа с данными";
            this.databaseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.databaseButton.UseAccentColor = false;
            this.databaseButton.UseVisualStyleBackColor = true;
            this.databaseButton.Click += new System.EventHandler(this.database_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.White;
            this.settingsButton.Controls.Add(this.themeSwitch);
            this.settingsButton.ImageKey = "gears.png";
            this.settingsButton.Location = new System.Drawing.Point(4, 39);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(2);
            this.settingsButton.Size = new System.Drawing.Size(588, 319);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Настройки";
            // 
            // themeSwitch
            // 
            this.themeSwitch.AutoSize = true;
            this.themeSwitch.Depth = 0;
            this.themeSwitch.Location = new System.Drawing.Point(2, 2);
            this.themeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.themeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeSwitch.Name = "themeSwitch";
            this.themeSwitch.Ripple = true;
            this.themeSwitch.Size = new System.Drawing.Size(155, 37);
            this.themeSwitch.TabIndex = 2;
            this.themeSwitch.Text = "Ночная тема";
            this.themeSwitch.UseVisualStyleBackColor = true;
            this.themeSwitch.CheckedChanged += new System.EventHandler(this.themeSwitch_CheckedChanged);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.White;
            this.aboutButton.Controls.Add(this.emailLabel);
            this.aboutButton.Controls.Add(this.aboutEmailLabel);
            this.aboutButton.Controls.Add(this.authorsLabel);
            this.aboutButton.ImageKey = "hazard-sign.png";
            this.aboutButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.aboutButton.Location = new System.Drawing.Point(4, 39);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(2);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Padding = new System.Windows.Forms.Padding(2);
            this.aboutButton.Size = new System.Drawing.Size(588, 319);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "О приложении";
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Depth = 0;
            this.emailLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.emailLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.emailLabel.Location = new System.Drawing.Point(325, 231);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(192, 51);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "test@test.com";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutEmailLabel
            // 
            this.aboutEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutEmailLabel.Depth = 0;
            this.aboutEmailLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.aboutEmailLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.aboutEmailLabel.Location = new System.Drawing.Point(5, 231);
            this.aboutEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutEmailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutEmailLabel.Name = "aboutEmailLabel";
            this.aboutEmailLabel.Size = new System.Drawing.Size(316, 51);
            this.aboutEmailLabel.TabIndex = 1;
            this.aboutEmailLabel.Text = "Почта для предложений, и отчетов об ошибках:";
            this.aboutEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorsLabel
            // 
            this.authorsLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorsLabel.Depth = 0;
            this.authorsLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.authorsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.authorsLabel.Location = new System.Drawing.Point(5, 3);
            this.authorsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.authorsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(512, 228);
            this.authorsLabel.TabIndex = 0;
            this.authorsLabel.Text = "Экология Байкала V2.5\r\n\r\nАвтор идеи - Ярославцева Т.В.\r\n\r\nПрограммист - Соколов В" +
    ".Р.\r\nДизайнер - Соколов В.Р.\r\nХудожник - Соколов В.Р.\r\n\r\n";
            this.authorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "gears.png");
            this.imageList1.Images.SetKeyName(1, "hazard-sign.png");
            this.imageList1.Images.SetKeyName(2, "help.png");
            this.imageList1.Images.SetKeyName(3, "house.png");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Главное меню";
            this.materialTabControl1.ResumeLayout(false);
            this.mainButton.ResumeLayout(false);
            this.settingsButton.ResumeLayout(false);
            this.settingsButton.PerformLayout();
            this.aboutButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage settingsButton;
        private System.Windows.Forms.TabPage aboutButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage mainButton;
        private MaterialSkin.Controls.MaterialButton exitButton;
        private MaterialSkin.Controls.MaterialButton mathematicModelButton;
        private MaterialSkin.Controls.MaterialButton databaseButton;
        private MaterialSkin.Controls.MaterialLabel authorsLabel;
        private MaterialSkin.Controls.MaterialLabel aboutEmailLabel;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialSwitch themeSwitch;
        private MaterialSkin.Controls.MaterialButton helpButton;
    }
}

