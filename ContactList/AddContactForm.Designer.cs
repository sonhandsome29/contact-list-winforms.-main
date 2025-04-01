namespace ContactList
{
    partial class AddContactForm
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
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(225, 148);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(100, 22);
            this.txtHoten.TabIndex = 0;
            this.txtHoten.Text = "Họ Tên";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(362, 148);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 22);
            this.txtsdt.TabIndex = 1;
            this.txtsdt.Text = "Số điện thoại";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(687, 148);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(514, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Email";
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtHoten);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txtEmail;
    }
}