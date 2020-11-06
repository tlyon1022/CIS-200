namespace LibraryItems
{
    partial class CheckOutForm1
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
            this.itemsCombo = new System.Windows.Forms.ComboBox();
            this.patronsCombo = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemsCombo
            // 
            this.itemsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemsCombo.FormattingEnabled = true;
            this.itemsCombo.Location = new System.Drawing.Point(12, 52);
            this.itemsCombo.Name = "itemsCombo";
            this.itemsCombo.Size = new System.Drawing.Size(271, 24);
            this.itemsCombo.TabIndex = 0;
            this.itemsCombo.SelectedIndexChanged += new System.EventHandler(this.ItemsCombo_SelectedIndexChanged);
            // 
            // patronsCombo
            // 
            this.patronsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patronsCombo.FormattingEnabled = true;
            this.patronsCombo.Location = new System.Drawing.Point(12, 120);
            this.patronsCombo.Name = "patronsCombo";
            this.patronsCombo.Size = new System.Drawing.Size(271, 24);
            this.patronsCombo.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(31, 177);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(132, 177);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // CheckOutForm1
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(314, 249);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.patronsCombo);
            this.Controls.Add(this.itemsCombo);
            this.Name = "CheckOutForm1";
            this.Text = "CheckOutForm1";
            this.Load += new System.EventHandler(this.CheckOutForm1_Load);
            this.ResumeLayout(false);

        }
        
        #endregion
        private System.Windows.Forms.ComboBox patronsCombo;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.ComboBox itemsCombo;
    }
}