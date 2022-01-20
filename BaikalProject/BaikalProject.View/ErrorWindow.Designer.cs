
namespace BaikalProject.View
{
    partial class ErrorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorWindow));
            this.errorTextLabel = new MaterialSkin.Controls.MaterialLabel();
            this.errorPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // errorTextLabel
            // 
            this.errorTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorTextLabel.Depth = 0;
            this.errorTextLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.errorTextLabel.Location = new System.Drawing.Point(139, 66);
            this.errorTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorTextLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.errorTextLabel.Name = "errorTextLabel";
            this.errorTextLabel.Size = new System.Drawing.Size(457, 119);
            this.errorTextLabel.TabIndex = 1;
            this.errorTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorPicture
            // 
            this.errorPicture.BackColor = System.Drawing.Color.Transparent;
            this.errorPicture.Image = global::BaikalProject.View.Properties.Resources._4;
            this.errorPicture.Location = new System.Drawing.Point(36, 97);
            this.errorPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.errorPicture.Name = "errorPicture";
            this.errorPicture.Size = new System.Drawing.Size(79, 60);
            this.errorPicture.TabIndex = 0;
            this.errorPicture.TabStop = false;
            // 
            // ErrorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 188);
            this.Controls.Add(this.errorTextLabel);
            this.Controls.Add(this.errorPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ErrorWindow";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Text = "Ошибка";
            ((System.ComponentModel.ISupportInitialize)(this.errorPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel errorTextLabel;
        private System.Windows.Forms.PictureBox errorPicture;
    }
}