namespace TestEikonSxS
{
    partial class ModifyContextUI
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
            this.cmbAddContext = new System.Windows.Forms.ComboBox();
            this.btnClearContext = new System.Windows.Forms.Button();
            this.btnDelContext = new System.Windows.Forms.Button();
            this.btnAddContext = new System.Windows.Forms.Button();
            this.lsbContext = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAddContext
            // 
            this.cmbAddContext.FormattingEnabled = true;
            this.cmbAddContext.Items.AddRange(new object[] {
            "EUR=",
            "GBP=",
            "TRI.N",
            ".SETI",
            "PTT.BK"});
            this.cmbAddContext.Location = new System.Drawing.Point(69, 16);
            this.cmbAddContext.Name = "cmbAddContext";
            this.cmbAddContext.Size = new System.Drawing.Size(196, 21);
            this.cmbAddContext.TabIndex = 48;
            this.cmbAddContext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbAddContext_KeyUp);
            // 
            // btnClearContext
            // 
            this.btnClearContext.Location = new System.Drawing.Point(272, 131);
            this.btnClearContext.Name = "btnClearContext";
            this.btnClearContext.Size = new System.Drawing.Size(75, 23);
            this.btnClearContext.TabIndex = 47;
            this.btnClearContext.Text = "Clear";
            this.btnClearContext.UseVisualStyleBackColor = true;
            this.btnClearContext.Click += new System.EventHandler(this.btnClearContext_Click);
            // 
            // btnDelContext
            // 
            this.btnDelContext.Location = new System.Drawing.Point(190, 131);
            this.btnDelContext.Name = "btnDelContext";
            this.btnDelContext.Size = new System.Drawing.Size(75, 23);
            this.btnDelContext.TabIndex = 46;
            this.btnDelContext.Text = "Delete";
            this.btnDelContext.UseVisualStyleBackColor = true;
            this.btnDelContext.Click += new System.EventHandler(this.btnDelContext_Click);
            // 
            // btnAddContext
            // 
            this.btnAddContext.Location = new System.Drawing.Point(271, 16);
            this.btnAddContext.Name = "btnAddContext";
            this.btnAddContext.Size = new System.Drawing.Size(75, 23);
            this.btnAddContext.TabIndex = 45;
            this.btnAddContext.Text = "Add";
            this.btnAddContext.UseVisualStyleBackColor = true;
            this.btnAddContext.Click += new System.EventHandler(this.btnAddContext_Click);
            // 
            // lsbContext
            // 
            this.lsbContext.FormattingEnabled = true;
            this.lsbContext.Location = new System.Drawing.Point(69, 43);
            this.lsbContext.Name = "lsbContext";
            this.lsbContext.Size = new System.Drawing.Size(278, 82);
            this.lsbContext.TabIndex = 44;
            this.lsbContext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lsbContext_KeyUp);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Add RIC: ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(254, 181);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(335, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ModifyContextUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 216);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbAddContext);
            this.Controls.Add(this.btnClearContext);
            this.Controls.Add(this.btnDelContext);
            this.Controls.Add(this.btnAddContext);
            this.Controls.Add(this.lsbContext);
            this.Controls.Add(this.label18);
            this.MaximumSize = new System.Drawing.Size(426, 247);
            this.MinimumSize = new System.Drawing.Size(426, 247);
            this.Name = "ModifyContextUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify RICs";
            this.Load += new System.EventHandler(this.ModifyContextUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAddContext;
        private System.Windows.Forms.Button btnClearContext;
        private System.Windows.Forms.Button btnDelContext;
        private System.Windows.Forms.Button btnAddContext;
        private System.Windows.Forms.ListBox lsbContext;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}