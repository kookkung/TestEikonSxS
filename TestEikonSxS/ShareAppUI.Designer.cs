namespace TestEikonSxS
{
    partial class ShareAppUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnklblURI = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSendEMail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMailTo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictEikonApp = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictEikonApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Received ShareApp message from Eikon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(45, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Link: ";
            // 
            // lnklblURI
            // 
            this.lnklblURI.AutoSize = true;
            this.lnklblURI.Location = new System.Drawing.Point(45, 50);
            this.lnklblURI.Name = "lnklblURI";
            this.lnklblURI.Size = new System.Drawing.Size(55, 13);
            this.lnklblURI.TabIndex = 4;
            this.lnklblURI.TabStop = true;
            this.lnklblURI.Text = "linkLabel1";
            this.lnklblURI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblURI_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(495, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSendEMail
            // 
            this.btnSendEMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendEMail.Location = new System.Drawing.Point(505, 35);
            this.btnSendEMail.Name = "btnSendEMail";
            this.btnSendEMail.Size = new System.Drawing.Size(75, 23);
            this.btnSendEMail.TabIndex = 6;
            this.btnSendEMail.Text = "Send";
            this.btnSendEMail.UseVisualStyleBackColor = true;
            this.btnSendEMail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Send Email to: ";
            // 
            // txbMailTo
            // 
            this.txbMailTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMailTo.Location = new System.Drawing.Point(87, 36);
            this.txbMailTo.Name = "txbMailTo";
            this.txbMailTo.Size = new System.Drawing.Size(412, 20);
            this.txbMailTo.TabIndex = 8;
            this.txbMailTo.Text = "@thomsonreuters.com";
            this.txbMailTo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbMailTo_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictEikonApp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lnklblURI);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 370);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesage Received";
            // 
            // pictEikonApp
            // 
            this.pictEikonApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictEikonApp.Location = new System.Drawing.Point(9, 81);
            this.pictEikonApp.Name = "pictEikonApp";
            this.pictEikonApp.Size = new System.Drawing.Size(551, 283);
            this.pictEikonApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictEikonApp.TabIndex = 5;
            this.pictEikonApp.TabStop = false;
            // 
            // ShareAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(592, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbMailTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSendEMail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Name = "ShareAppUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Share via";
            this.Load += new System.EventHandler(this.ShareAppUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictEikonApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnklblURI;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSendEMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMailTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictEikonApp;
    }
}