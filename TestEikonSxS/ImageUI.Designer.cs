namespace TestEikonSxS
{
    partial class ImageUI
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
            this.pictImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictImage
            // 
            this.pictImage.Location = new System.Drawing.Point(-3, 1);
            this.pictImage.Name = "pictImage";
            this.pictImage.Size = new System.Drawing.Size(675, 345);
            this.pictImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictImage.TabIndex = 0;
            this.pictImage.TabStop = false;
            // 
            // ImageUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(668, 343);
            this.Controls.Add(this.pictImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImageUI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ImageUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictImage;
    }
}