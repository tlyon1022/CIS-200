namespace LibraryItems
{
    partial class EditBook
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
            this.editBookLb = new System.Windows.Forms.ListBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cnclBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // editBookLb
            // 
            this.editBookLb.FormattingEnabled = true;
            this.editBookLb.Location = new System.Drawing.Point(16, 6);
            this.editBookLb.Margin = new System.Windows.Forms.Padding(2);
            this.editBookLb.Name = "editBookLb";
            this.editBookLb.Size = new System.Drawing.Size(358, 134);
            this.editBookLb.TabIndex = 0;
            this.editBookLb.Validating += new System.ComponentModel.CancelEventHandler(this.bookLb_Validating);
            this.editBookLb.Validated += new System.EventHandler(this.bookLb_Validated);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(16, 153);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(60, 27);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click_1);
            // 
            // cnclBtn
            // 
            this.cnclBtn.Location = new System.Drawing.Point(88, 153);
            this.cnclBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cnclBtn.Name = "cnclBtn";
            this.cnclBtn.Size = new System.Drawing.Size(56, 27);
            this.cnclBtn.TabIndex = 2;
            this.cnclBtn.Text = "Cancel";
            this.cnclBtn.UseVisualStyleBackColor = true;
            this.cnclBtn.Click += new System.EventHandler(this.CnclBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditBook
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.cnclBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.editBookLb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditBook";
            this.Text = "Edit Book";
            this.Load += new System.EventHandler(this.EditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox editBookLb;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cnclBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}