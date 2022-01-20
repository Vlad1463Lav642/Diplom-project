
namespace BaikalProject.View
{
    partial class HelpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            this.helpLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // helpLabel
            // 
            this.helpLabel.BackColor = System.Drawing.Color.Transparent;
            this.helpLabel.Depth = 0;
            this.helpLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.helpLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.helpLabel.Location = new System.Drawing.Point(5, 65);
            this.helpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helpLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(1021, 281);
            this.helpLabel.TabIndex = 0;
            this.helpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 348);
            this.Controls.Add(this.helpLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HelpWindow";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Подсказка";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel helpLabel;
    }
}