
namespace BaikalProject.View
{
    partial class DatabaseWorkWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseWorkWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.endButton = new MaterialSkin.Controls.MaterialButton();
            this.helpButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(4, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 290);
            this.panel1.TabIndex = 1;
            // 
            // endButton
            // 
            this.endButton.AutoSize = false;
            this.endButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.endButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.endButton.Depth = 0;
            this.endButton.HighEmphasis = true;
            this.endButton.Icon = null;
            this.endButton.Location = new System.Drawing.Point(73, 370);
            this.endButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.endButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(598, 29);
            this.endButton.TabIndex = 2;
            this.endButton.Text = "Готово";
            this.endButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.endButton.UseAccentColor = false;
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.AutoSize = false;
            this.helpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.helpButton.Depth = 0;
            this.helpButton.HighEmphasis = true;
            this.helpButton.Icon = global::BaikalProject.View.Properties.Resources.help_small;
            this.helpButton.Location = new System.Drawing.Point(4, 366);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(41, 36);
            this.helpButton.TabIndex = 35;
            this.helpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.helpButton.UseAccentColor = false;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // DatabaseWorkWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 405);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatabaseWorkWindow";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Изменение данных";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton endButton;
        private MaterialSkin.Controls.MaterialButton helpButton;
    }
}