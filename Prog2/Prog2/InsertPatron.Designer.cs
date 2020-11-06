namespace LibraryItems
{
    partial class InsertPatron
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
            this.patronNameLbl = new System.Windows.Forms.Label();
            this.patronIDLbl = new System.Windows.Forms.Label();
            this.patronNameTxt = new System.Windows.Forms.TextBox();
            this.patronIDTxt = new System.Windows.Forms.TextBox();
            this.okPatBtn = new System.Windows.Forms.Button();
            this.cancelPatBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // patronNameLbl
            // 
            this.patronNameLbl.AutoSize = true;
            this.patronNameLbl.Location = new System.Drawing.Point(22, 26);
            this.patronNameLbl.Name = "patronNameLbl";
            this.patronNameLbl.Size = new System.Drawing.Size(45, 17);
            this.patronNameLbl.TabIndex = 0;
            this.patronNameLbl.Text = "Name";
            // 
            // patronIDLbl
            // 
            this.patronIDLbl.AutoSize = true;
            this.patronIDLbl.Location = new System.Drawing.Point(22, 87);
            this.patronIDLbl.Name = "patronIDLbl";
            this.patronIDLbl.Size = new System.Drawing.Size(21, 17);
            this.patronIDLbl.TabIndex = 1;
            this.patronIDLbl.Text = "ID";
            // 
            // patronNameTxt
            // 
            this.patronNameTxt.Location = new System.Drawing.Point(95, 21);
            this.patronNameTxt.Name = "patronNameTxt";
            this.patronNameTxt.Size = new System.Drawing.Size(100, 22);
            this.patronNameTxt.TabIndex = 2;
            this.patronNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.patronNameTxt_Validating);
            this.patronNameTxt.Validated += new System.EventHandler(this.patronNameTxt_Validated);
            // 
            // patronIDTxt
            // 
            this.patronIDTxt.Location = new System.Drawing.Point(95, 82);
            this.patronIDTxt.Name = "patronIDTxt";
            this.patronIDTxt.Size = new System.Drawing.Size(100, 22);
            this.patronIDTxt.TabIndex = 3;
            this.patronIDTxt.Validating += new System.ComponentModel.CancelEventHandler(this.patronIDTxt_Validating);
            this.patronIDTxt.Validated += new System.EventHandler(this.patronIDTxt_Validated);
            // 
            // okPatBtn
            // 
            this.okPatBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okPatBtn.Location = new System.Drawing.Point(25, 151);
            this.okPatBtn.Name = "okPatBtn";
            this.okPatBtn.Size = new System.Drawing.Size(75, 23);
            this.okPatBtn.TabIndex = 4;
            this.okPatBtn.Text = "OK";
            this.okPatBtn.UseVisualStyleBackColor = true;
            this.okPatBtn.Click += new System.EventHandler(this.InsertPatron_Click);
            // 
            // cancelPatBtn
            // 
            this.cancelPatBtn.Location = new System.Drawing.Point(120, 151);
            this.cancelPatBtn.Name = "cancelPatBtn";
            this.cancelPatBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelPatBtn.TabIndex = 5;
            this.cancelPatBtn.Text = "Cancel";
            this.cancelPatBtn.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.patronNameTxt_Validated);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.RightToLeftChanged += new System.EventHandler(this.patronIDTxt_Validated);
            // 
            // InsertPatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 243);
            this.Controls.Add(this.cancelPatBtn);
            this.Controls.Add(this.okPatBtn);
            this.Controls.Add(this.patronIDTxt);
            this.Controls.Add(this.patronNameTxt);
            this.Controls.Add(this.patronIDLbl);
            this.Controls.Add(this.patronNameLbl);
            this.Name = "InsertPatron";
            this.Text = "InsertPatron";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patronNameLbl;
        private System.Windows.Forms.Label patronIDLbl;
        private System.Windows.Forms.TextBox patronNameTxt;
        private System.Windows.Forms.TextBox patronIDTxt;
        private System.Windows.Forms.Button okPatBtn;
        private System.Windows.Forms.Button cancelPatBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}