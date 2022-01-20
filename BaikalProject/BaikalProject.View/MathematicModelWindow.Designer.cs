
namespace BaikalProject.View
{
    partial class MathematicModelWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathematicModelWindow));
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.pointLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pointsButton = new MaterialSkin.Controls.MaterialButton();
            this.pollutionButton = new MaterialSkin.Controls.MaterialButton();
            this.screenButton = new MaterialSkin.Controls.MaterialButton();
            this.toExcelButton = new MaterialSkin.Controls.MaterialButton();
            this.seasonLabel = new MaterialSkin.Controls.MaterialLabel();
            this.yearLabel = new MaterialSkin.Controls.MaterialLabel();
            this.elementsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.darkRedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.darkOrangeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.orangeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.darkYellowLabel = new MaterialSkin.Controls.MaterialLabel();
            this.redLabel = new MaterialSkin.Controls.MaterialLabel();
            this.redPanel = new System.Windows.Forms.Panel();
            this.darkOrangePanel = new System.Windows.Forms.Panel();
            this.orangePanel = new System.Windows.Forms.Panel();
            this.darkYellowPanel = new System.Windows.Forms.Panel();
            this.darkRedPanel = new System.Windows.Forms.Panel();
            this.helpButton = new MaterialSkin.Controls.MaterialButton();
            this.yellowPanel = new System.Windows.Forms.Panel();
            this.yellowLabel = new MaterialSkin.Controls.MaterialLabel();
            this.darkGreenLabel = new MaterialSkin.Controls.MaterialLabel();
            this.darkGreenPanel = new System.Windows.Forms.Panel();
            this.greenLabel = new MaterialSkin.Controls.MaterialLabel();
            this.greenPanel = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.hidePollutionBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(13, 134);
            this.map.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(615, 461);
            this.map.TabIndex = 2;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // pointLabel
            // 
            this.pointLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointLabel.Depth = 0;
            this.pointLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.pointLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.pointLabel.Location = new System.Drawing.Point(638, 134);
            this.pointLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(482, 124);
            this.pointLabel.TabIndex = 16;
            this.pointLabel.Text = "В точке: 0";
            this.pointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointsButton
            // 
            this.pointsButton.AutoSize = false;
            this.pointsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pointsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.pointsButton.Depth = 0;
            this.pointsButton.HighEmphasis = true;
            this.pointsButton.Icon = null;
            this.pointsButton.Location = new System.Drawing.Point(636, 79);
            this.pointsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pointsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pointsButton.Name = "pointsButton";
            this.pointsButton.Size = new System.Drawing.Size(484, 49);
            this.pointsButton.TabIndex = 1;
            this.pointsButton.Text = "Выбор точек пробоотбора";
            this.pointsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.pointsButton.UseAccentColor = false;
            this.pointsButton.UseVisualStyleBackColor = true;
            this.pointsButton.Click += new System.EventHandler(this.pointsButton_Click);
            // 
            // pollutionButton
            // 
            this.pollutionButton.AutoSize = false;
            this.pollutionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pollutionButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.pollutionButton.Depth = 0;
            this.pollutionButton.HighEmphasis = true;
            this.pollutionButton.Icon = null;
            this.pollutionButton.Location = new System.Drawing.Point(637, 545);
            this.pollutionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pollutionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pollutionButton.Name = "pollutionButton";
            this.pollutionButton.Size = new System.Drawing.Size(484, 49);
            this.pollutionButton.TabIndex = 3;
            this.pollutionButton.Text = "Расчитать";
            this.pollutionButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.pollutionButton.UseAccentColor = false;
            this.pollutionButton.UseVisualStyleBackColor = true;
            this.pollutionButton.Click += new System.EventHandler(this.PollutionClick);
            // 
            // screenButton
            // 
            this.screenButton.AutoSize = false;
            this.screenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.screenButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.screenButton.Depth = 0;
            this.screenButton.HighEmphasis = true;
            this.screenButton.Icon = null;
            this.screenButton.Location = new System.Drawing.Point(637, 667);
            this.screenButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.screenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenButton.Name = "screenButton";
            this.screenButton.Size = new System.Drawing.Size(484, 49);
            this.screenButton.TabIndex = 5;
            this.screenButton.Text = "Скриншот карты";
            this.screenButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.screenButton.UseAccentColor = false;
            this.screenButton.UseVisualStyleBackColor = true;
            this.screenButton.Click += new System.EventHandler(this.ScreenButton_Click);
            // 
            // toExcelButton
            // 
            this.toExcelButton.AutoSize = false;
            this.toExcelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toExcelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.toExcelButton.Depth = 0;
            this.toExcelButton.HighEmphasis = true;
            this.toExcelButton.Icon = null;
            this.toExcelButton.Location = new System.Drawing.Point(636, 606);
            this.toExcelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.toExcelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.toExcelButton.Name = "toExcelButton";
            this.toExcelButton.Size = new System.Drawing.Size(484, 49);
            this.toExcelButton.TabIndex = 4;
            this.toExcelButton.Text = "Экспорт данных в Excel";
            this.toExcelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.toExcelButton.UseAccentColor = false;
            this.toExcelButton.UseVisualStyleBackColor = true;
            this.toExcelButton.Click += new System.EventHandler(this.toExcelButton_Click);
            // 
            // seasonLabel
            // 
            this.seasonLabel.BackColor = System.Drawing.Color.Transparent;
            this.seasonLabel.Depth = 0;
            this.seasonLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.seasonLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.seasonLabel.Location = new System.Drawing.Point(72, 643);
            this.seasonLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.seasonLabel.Name = "seasonLabel";
            this.seasonLabel.Size = new System.Drawing.Size(263, 82);
            this.seasonLabel.TabIndex = 23;
            this.seasonLabel.Text = "За сезон: 0";
            this.seasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearLabel
            // 
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Depth = 0;
            this.yearLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.yearLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.yearLabel.Location = new System.Drawing.Point(365, 643);
            this.yearLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(264, 82);
            this.yearLabel.TabIndex = 22;
            this.yearLabel.Text = "За год: 0";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elementsComboBox
            // 
            this.elementsComboBox.AutoResize = false;
            this.elementsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.elementsComboBox.Depth = 0;
            this.elementsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.elementsComboBox.DropDownHeight = 174;
            this.elementsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elementsComboBox.DropDownWidth = 121;
            this.elementsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.elementsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.elementsComboBox.FormattingEnabled = true;
            this.elementsComboBox.IntegralHeight = false;
            this.elementsComboBox.ItemHeight = 43;
            this.elementsComboBox.Items.AddRange(new object[] {
            "F (мг/дм³)",
            "HCO3 (мг/дм³)",
            "Cl (мг/дм³)",
            "SO23 (мг/дм³)",
            "NO2 (мг/дм³)",
            "NO3 (мг/дм³)",
            "PO34 (мг/дм³)",
            "Ca2 (мг/дм³)",
            "Mg2 (мг/дм³)",
            "K (мг/дм³)",
            "Na (мг/дм³)",
            "NH4 (мг/дм³)",
            "Oil (мг/дм³)",
            "Mo (мг/дм³)",
            "Mn (мг/дм³)",
            "Ba (мг/дм³)",
            "Al (мг/дм³)",
            "Pb (мг/дм³)",
            "Ni (мг/дм³)",
            "Cu (мг/дм³)",
            "Be (мг/дм³)",
            "V (мг/дм³)",
            "Cr (мг/дм³)",
            "Fe (мг/дм³)",
            "Si (мг/дм³)",
            "Zn (мг/дм³)",
            "Sr (мг/дм³)",
            "Ti (мг/дм³)",
            "Co (мг/дм³)",
            "Cd (мг/дм³)",
            "Hg (мкг/дм³)"});
            this.elementsComboBox.Location = new System.Drawing.Point(13, 79);
            this.elementsComboBox.MaxDropDownItems = 4;
            this.elementsComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.elementsComboBox.Name = "elementsComboBox";
            this.elementsComboBox.Size = new System.Drawing.Size(616, 49);
            this.elementsComboBox.StartIndex = 0;
            this.elementsComboBox.TabIndex = 0;
            this.elementsComboBox.SelectedIndexChanged += new System.EventHandler(this.ElementsComboBox_SelectedIndexChanged);
            // 
            // darkRedLabel
            // 
            this.darkRedLabel.BackColor = System.Drawing.Color.Transparent;
            this.darkRedLabel.Depth = 0;
            this.darkRedLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.darkRedLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.darkRedLabel.Location = new System.Drawing.Point(673, 267);
            this.darkRedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkRedLabel.Name = "darkRedLabel";
            this.darkRedLabel.Size = new System.Drawing.Size(447, 26);
            this.darkRedLabel.TabIndex = 28;
            this.darkRedLabel.Text = "0";
            this.darkRedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // darkOrangeLabel
            // 
            this.darkOrangeLabel.BackColor = System.Drawing.Color.Transparent;
            this.darkOrangeLabel.Depth = 0;
            this.darkOrangeLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.darkOrangeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.darkOrangeLabel.Location = new System.Drawing.Point(673, 331);
            this.darkOrangeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkOrangeLabel.Name = "darkOrangeLabel";
            this.darkOrangeLabel.Size = new System.Drawing.Size(447, 26);
            this.darkOrangeLabel.TabIndex = 29;
            this.darkOrangeLabel.Text = "0";
            this.darkOrangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orangeLabel
            // 
            this.orangeLabel.BackColor = System.Drawing.Color.Transparent;
            this.orangeLabel.Depth = 0;
            this.orangeLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.orangeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.orangeLabel.Location = new System.Drawing.Point(673, 363);
            this.orangeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.orangeLabel.Name = "orangeLabel";
            this.orangeLabel.Size = new System.Drawing.Size(447, 26);
            this.orangeLabel.TabIndex = 30;
            this.orangeLabel.Text = "0";
            this.orangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // darkYellowLabel
            // 
            this.darkYellowLabel.BackColor = System.Drawing.Color.Transparent;
            this.darkYellowLabel.Depth = 0;
            this.darkYellowLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.darkYellowLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.darkYellowLabel.Location = new System.Drawing.Point(673, 395);
            this.darkYellowLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkYellowLabel.Name = "darkYellowLabel";
            this.darkYellowLabel.Size = new System.Drawing.Size(447, 26);
            this.darkYellowLabel.TabIndex = 31;
            this.darkYellowLabel.Text = "0";
            this.darkYellowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Transparent;
            this.redLabel.Depth = 0;
            this.redLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.redLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.redLabel.Location = new System.Drawing.Point(673, 299);
            this.redLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(447, 26);
            this.redLabel.TabIndex = 32;
            this.redLabel.Text = "0";
            this.redLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redPanel
            // 
            this.redPanel.BackColor = System.Drawing.Color.Red;
            this.redPanel.Location = new System.Drawing.Point(639, 299);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(28, 26);
            this.redPanel.TabIndex = 9;
            // 
            // darkOrangePanel
            // 
            this.darkOrangePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.darkOrangePanel.Location = new System.Drawing.Point(639, 331);
            this.darkOrangePanel.Name = "darkOrangePanel";
            this.darkOrangePanel.Size = new System.Drawing.Size(28, 26);
            this.darkOrangePanel.TabIndex = 9;
            // 
            // orangePanel
            // 
            this.orangePanel.BackColor = System.Drawing.Color.Orange;
            this.orangePanel.Location = new System.Drawing.Point(639, 363);
            this.orangePanel.Name = "orangePanel";
            this.orangePanel.Size = new System.Drawing.Size(28, 26);
            this.orangePanel.TabIndex = 9;
            // 
            // darkYellowPanel
            // 
            this.darkYellowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.darkYellowPanel.Location = new System.Drawing.Point(639, 395);
            this.darkYellowPanel.Name = "darkYellowPanel";
            this.darkYellowPanel.Size = new System.Drawing.Size(28, 26);
            this.darkYellowPanel.TabIndex = 9;
            // 
            // darkRedPanel
            // 
            this.darkRedPanel.BackColor = System.Drawing.Color.DarkRed;
            this.darkRedPanel.Location = new System.Drawing.Point(639, 267);
            this.darkRedPanel.Name = "darkRedPanel";
            this.darkRedPanel.Size = new System.Drawing.Size(28, 26);
            this.darkRedPanel.TabIndex = 8;
            // 
            // helpButton
            // 
            this.helpButton.AutoSize = false;
            this.helpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.helpButton.Depth = 0;
            this.helpButton.HighEmphasis = true;
            this.helpButton.Icon = global::BaikalProject.View.Properties.Resources.help_small;
            this.helpButton.Location = new System.Drawing.Point(7, 689);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(41, 36);
            this.helpButton.TabIndex = 33;
            this.helpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.helpButton.UseAccentColor = false;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // yellowPanel
            // 
            this.yellowPanel.BackColor = System.Drawing.Color.Yellow;
            this.yellowPanel.Location = new System.Drawing.Point(639, 427);
            this.yellowPanel.Name = "yellowPanel";
            this.yellowPanel.Size = new System.Drawing.Size(28, 26);
            this.yellowPanel.TabIndex = 10;
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.Color.Transparent;
            this.yellowLabel.Depth = 0;
            this.yellowLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.yellowLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.yellowLabel.Location = new System.Drawing.Point(673, 427);
            this.yellowLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(447, 26);
            this.yellowLabel.TabIndex = 34;
            this.yellowLabel.Text = "0";
            this.yellowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // darkGreenLabel
            // 
            this.darkGreenLabel.BackColor = System.Drawing.Color.Transparent;
            this.darkGreenLabel.Depth = 0;
            this.darkGreenLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.darkGreenLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.darkGreenLabel.Location = new System.Drawing.Point(673, 462);
            this.darkGreenLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkGreenLabel.Name = "darkGreenLabel";
            this.darkGreenLabel.Size = new System.Drawing.Size(447, 26);
            this.darkGreenLabel.TabIndex = 36;
            this.darkGreenLabel.Text = "0";
            this.darkGreenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // darkGreenPanel
            // 
            this.darkGreenPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.darkGreenPanel.Location = new System.Drawing.Point(639, 462);
            this.darkGreenPanel.Name = "darkGreenPanel";
            this.darkGreenPanel.Size = new System.Drawing.Size(28, 26);
            this.darkGreenPanel.TabIndex = 35;
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.Color.Transparent;
            this.greenLabel.Depth = 0;
            this.greenLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.greenLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.greenLabel.Location = new System.Drawing.Point(673, 498);
            this.greenLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(447, 26);
            this.greenLabel.TabIndex = 38;
            this.greenLabel.Text = "0";
            this.greenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // greenPanel
            // 
            this.greenPanel.BackColor = System.Drawing.Color.Green;
            this.greenPanel.Location = new System.Drawing.Point(639, 498);
            this.greenPanel.Name = "greenPanel";
            this.greenPanel.Size = new System.Drawing.Size(28, 26);
            this.greenPanel.TabIndex = 37;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "point.png");
            this.imageList1.Images.SetKeyName(1, "point2.png");
            // 
            // hidePollutionBox
            // 
            this.hidePollutionBox.AutoSize = true;
            this.hidePollutionBox.Depth = 0;
            this.hidePollutionBox.Location = new System.Drawing.Point(497, 597);
            this.hidePollutionBox.Margin = new System.Windows.Forms.Padding(0);
            this.hidePollutionBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.hidePollutionBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.hidePollutionBox.Name = "hidePollutionBox";
            this.hidePollutionBox.Ripple = true;
            this.hidePollutionBox.Size = new System.Drawing.Size(131, 37);
            this.hidePollutionBox.TabIndex = 39;
            this.hidePollutionBox.Text = "Скрыть поле";
            this.hidePollutionBox.UseVisualStyleBackColor = true;
            this.hidePollutionBox.CheckedChanged += new System.EventHandler(this.HidePollutionBox_CheckedChanged);
            // 
            // MathematicModelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 732);
            this.Controls.Add(this.hidePollutionBox);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.greenPanel);
            this.Controls.Add(this.darkGreenLabel);
            this.Controls.Add(this.darkGreenPanel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.yellowPanel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.darkYellowLabel);
            this.Controls.Add(this.orangeLabel);
            this.Controls.Add(this.darkOrangeLabel);
            this.Controls.Add(this.darkRedLabel);
            this.Controls.Add(this.seasonLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.toExcelButton);
            this.Controls.Add(this.screenButton);
            this.Controls.Add(this.pollutionButton);
            this.Controls.Add(this.elementsComboBox);
            this.Controls.Add(this.pointsButton);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.darkYellowPanel);
            this.Controls.Add(this.orangePanel);
            this.Controls.Add(this.darkOrangePanel);
            this.Controls.Add(this.redPanel);
            this.Controls.Add(this.darkRedPanel);
            this.Controls.Add(this.map);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "MathematicModelWindow";
            this.Text = "Работа с картой";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private MaterialSkin.Controls.MaterialLabel pointLabel;
        private MaterialSkin.Controls.MaterialButton pointsButton;
        private MaterialSkin.Controls.MaterialButton pollutionButton;
        private MaterialSkin.Controls.MaterialButton screenButton;
        private MaterialSkin.Controls.MaterialButton toExcelButton;
        private MaterialSkin.Controls.MaterialLabel seasonLabel;
        private MaterialSkin.Controls.MaterialLabel yearLabel;
        private MaterialSkin.Controls.MaterialComboBox elementsComboBox;
        private MaterialSkin.Controls.MaterialLabel darkRedLabel;
        private MaterialSkin.Controls.MaterialLabel darkOrangeLabel;
        private MaterialSkin.Controls.MaterialLabel orangeLabel;
        private MaterialSkin.Controls.MaterialLabel darkYellowLabel;
        private MaterialSkin.Controls.MaterialLabel redLabel;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.Panel darkOrangePanel;
        private System.Windows.Forms.Panel orangePanel;
        private System.Windows.Forms.Panel darkYellowPanel;
        private System.Windows.Forms.Panel darkRedPanel;
        private MaterialSkin.Controls.MaterialButton helpButton;
        private System.Windows.Forms.Panel yellowPanel;
        private MaterialSkin.Controls.MaterialLabel yellowLabel;
        private MaterialSkin.Controls.MaterialLabel darkGreenLabel;
        private System.Windows.Forms.Panel darkGreenPanel;
        private MaterialSkin.Controls.MaterialLabel greenLabel;
        private System.Windows.Forms.Panel greenPanel;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialCheckbox hidePollutionBox;
    }
}