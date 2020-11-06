namespace LibraryItems
{
    partial class InsertBook
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.pubLbl = new System.Windows.Forms.Label();
            this.copyLbl = new System.Windows.Forms.Label();
            this.loanLbl = new System.Windows.Forms.Label();
            this.cnLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.pubTxt = new System.Windows.Forms.TextBox();
            this.copyTxt = new System.Windows.Forms.TextBox();
            this.loanTxt = new System.Windows.Forms.TextBox();
            this.cnTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(35, 17);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title";
            // 
            // pubLbl
            // 
            this.pubLbl.AutoSize = true;
            this.pubLbl.Location = new System.Drawing.Point(12, 54);
            this.pubLbl.Name = "pubLbl";
            this.pubLbl.Size = new System.Drawing.Size(67, 17);
            this.pubLbl.TabIndex = 1;
            this.pubLbl.Text = "Publisher";
            // 
            // copyLbl
            // 
            this.copyLbl.AutoSize = true;
            this.copyLbl.Location = new System.Drawing.Point(12, 108);
            this.copyLbl.Name = "copyLbl";
            this.copyLbl.Size = new System.Drawing.Size(68, 17);
            this.copyLbl.TabIndex = 2;
            this.copyLbl.Text = "Copyright";
            // 
            // loanLbl
            // 
            this.loanLbl.AutoSize = true;
            this.loanLbl.Location = new System.Drawing.Point(12, 160);
            this.loanLbl.Name = "loanLbl";
            this.loanLbl.Size = new System.Drawing.Size(85, 17);
            this.loanLbl.TabIndex = 3;
            this.loanLbl.Text = "Loan Period";
            // 
            // cnLbl
            // 
            this.cnLbl.AutoSize = true;
            this.cnLbl.Location = new System.Drawing.Point(12, 211);
            this.cnLbl.Name = "cnLbl";
            this.cnLbl.Size = new System.Drawing.Size(85, 17);
            this.cnLbl.TabIndex = 4;
            this.cnLbl.Text = "Call Number";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(12, 260);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(50, 17);
            this.authorLbl.TabIndex = 5;
            this.authorLbl.Text = "Author";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(139, 12);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(100, 22);
            this.titleTxt.TabIndex = 6;
            this.titleTxt.Validating += new System.ComponentModel.CancelEventHandler(this.titleTxt_Validating);
            this.titleTxt.Validated += new System.EventHandler(this.titleTxt_Validated);
            // 
            // pubTxt
            // 
            this.pubTxt.Location = new System.Drawing.Point(139, 54);
            this.pubTxt.Name = "pubTxt";
            this.pubTxt.Size = new System.Drawing.Size(100, 22);
            this.pubTxt.TabIndex = 7;
            // 
            // copyTxt
            // 
            this.copyTxt.Location = new System.Drawing.Point(139, 103);
            this.copyTxt.Name = "copyTxt";
            this.copyTxt.Size = new System.Drawing.Size(100, 22);
            this.copyTxt.TabIndex = 8;
            this.copyTxt.Validating += new System.ComponentModel.CancelEventHandler(this.copyTxt_Validating);
            this.copyTxt.Validated += new System.EventHandler(this.copyTxt_Validated);
            // 
            // loanTxt
            // 
            this.loanTxt.Location = new System.Drawing.Point(139, 155);
            this.loanTxt.Name = "loanTxt";
            this.loanTxt.Size = new System.Drawing.Size(100, 22);
            this.loanTxt.TabIndex = 9;
            this.loanTxt.Validating += new System.ComponentModel.CancelEventHandler(this.loanTxt_Validating);
            this.loanTxt.Validated += new System.EventHandler(this.loanTxt_Validated);
            // 
            // cnTxt
            // 
            this.cnTxt.Location = new System.Drawing.Point(139, 206);
            this.cnTxt.Name = "cnTxt";
            this.cnTxt.Size = new System.Drawing.Size(100, 22);
            this.cnTxt.TabIndex = 10;
            this.cnTxt.Validating += new System.ComponentModel.CancelEventHandler(this.cnTxt_Validating);
            this.cnTxt.Validated += new System.EventHandler(this.cnTxt_Validated);
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(139, 257);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(100, 22);
            this.authorTxt.TabIndex = 11;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(47, 321);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 12;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(139, 321);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.titleTxt_Validated);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.RightToLeftChanged += new System.EventHandler(this.copyTxt_Validated);
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            this.errorProvider4.RightToLeftChanged += new System.EventHandler(this.loanTxt_Validated);
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            this.errorProvider5.RightToLeftChanged += new System.EventHandler(this.cnTxt_Validated);
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // InsertBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 382);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.cnTxt);
            this.Controls.Add(this.loanTxt);
            this.Controls.Add(this.copyTxt);
            this.Controls.Add(this.pubTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.cnLbl);
            this.Controls.Add(this.loanLbl);
            this.Controls.Add(this.copyLbl);
            this.Controls.Add(this.pubLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "InsertBook";
            this.Text = "InsertBook";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label pubLbl;
        private System.Windows.Forms.Label copyLbl;
        private System.Windows.Forms.Label loanLbl;
        private System.Windows.Forms.Label cnLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox pubTxt;
        private System.Windows.Forms.TextBox copyTxt;
        private System.Windows.Forms.TextBox loanTxt;
        private System.Windows.Forms.TextBox cnTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}