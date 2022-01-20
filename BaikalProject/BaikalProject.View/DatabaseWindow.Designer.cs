
namespace BaikalProject.View
{
    partial class DatabaseWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseWindow));
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.tableInfo = new System.Windows.Forms.DataGridView();
            this.comboBoxTableName = new MaterialSkin.Controls.MaterialComboBox();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.ToolStripButton();
            this.excelButton = new System.Windows.Forms.ToolStripButton();
            this.helpButton = new System.Windows.Forms.ToolStripButton();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.AutoSize = false;
            this.toolbar.Dock = System.Windows.Forms.DockStyle.None;
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.deleteButton,
            this.updateButton,
            this.excelButton,
            this.helpButton});
            this.toolbar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolbar.Location = new System.Drawing.Point(4, 68);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(941, 44);
            this.toolbar.TabIndex = 4;
            this.toolbar.Text = "toolStrip1";
            // 
            // tableInfo
            // 
            this.tableInfo.AllowUserToAddRows = false;
            this.tableInfo.AllowUserToDeleteRows = false;
            this.tableInfo.AllowUserToResizeColumns = false;
            this.tableInfo.AllowUserToResizeRows = false;
            this.tableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInfo.Location = new System.Drawing.Point(4, 168);
            this.tableInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tableInfo.MultiSelect = false;
            this.tableInfo.Name = "tableInfo";
            this.tableInfo.RowHeadersWidth = 51;
            this.tableInfo.RowTemplate.Height = 24;
            this.tableInfo.ShowCellToolTips = false;
            this.tableInfo.ShowEditingIcon = false;
            this.tableInfo.Size = new System.Drawing.Size(944, 459);
            this.tableInfo.TabIndex = 5;
            // 
            // comboBoxTableName
            // 
            this.comboBoxTableName.AutoResize = false;
            this.comboBoxTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxTableName.Depth = 0;
            this.comboBoxTableName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxTableName.DropDownHeight = 174;
            this.comboBoxTableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableName.DropDownWidth = 121;
            this.comboBoxTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTableName.FormattingEnabled = true;
            this.comboBoxTableName.IntegralHeight = false;
            this.comboBoxTableName.ItemHeight = 43;
            this.comboBoxTableName.Items.AddRange(new object[] {
            "aquatories",
            "coordinates",
            "locations",
            "prob_Positions",
            "oil_Products_And_Elements"});
            this.comboBoxTableName.Location = new System.Drawing.Point(4, 115);
            this.comboBoxTableName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTableName.MaxDropDownItems = 4;
            this.comboBoxTableName.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTableName.Name = "comboBoxTableName";
            this.comboBoxTableName.Size = new System.Drawing.Size(942, 49);
            this.comboBoxTableName.StartIndex = 0;
            this.comboBoxTableName.TabIndex = 6;
            this.comboBoxTableName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableName_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.AutoSize = false;
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButton.Image = global::BaikalProject.View.Properties.Resources._1;
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 50);
            this.addButton.Text = "Добавить";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addButton.Click += new System.EventHandler(this.OnWorkWithDatabaseClick);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = false;
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = global::BaikalProject.View.Properties.Resources._2;
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 50);
            this.deleteButton.Text = "Удалить";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteButton.Click += new System.EventHandler(this.OnWorkWithDatabaseClick);
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = false;
            this.updateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.updateButton.Image = global::BaikalProject.View.Properties.Resources._3;
            this.updateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(50, 50);
            this.updateButton.Text = "Изменить";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.updateButton.Click += new System.EventHandler(this.OnWorkWithDatabaseClick);
            // 
            // excelButton
            // 
            this.excelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.excelButton.Image = global::BaikalProject.View.Properties.Resources._7;
            this.excelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(24, 41);
            this.excelButton.Text = "Сохранить в Excel";
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpButton.Image = global::BaikalProject.View.Properties.Resources.help;
            this.helpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(24, 41);
            this.helpButton.Text = "help";
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // DatabaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 632);
            this.Controls.Add(this.comboBoxTableName);
            this.Controls.Add(this.tableInfo);
            this.Controls.Add(this.toolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatabaseWindow";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Работа с данными";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton updateButton;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton excelButton;
        private System.Windows.Forms.DataGridView tableInfo;
        private MaterialSkin.Controls.MaterialComboBox comboBoxTableName;
        private System.Windows.Forms.ToolStripButton helpButton;
    }
}