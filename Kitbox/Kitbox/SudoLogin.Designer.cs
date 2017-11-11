namespace Kitbox
{
    partial class SudoLogin
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
            this.txtBx_email_sudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_password_sudo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login_sudo = new System.Windows.Forms.Button();
            this.btn_Back_adminlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBx_email_sudo
            // 
            this.txtBx_email_sudo.Location = new System.Drawing.Point(88, 61);
            this.txtBx_email_sudo.Name = "txtBx_email_sudo";
            this.txtBx_email_sudo.Size = new System.Drawing.Size(168, 20);
            this.txtBx_email_sudo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBx_password_sudo
            // 
            this.txtBx_password_sudo.Location = new System.Drawing.Point(88, 117);
            this.txtBx_password_sudo.MaxLength = 20;
            this.txtBx_password_sudo.Name = "txtBx_password_sudo";
            this.txtBx_password_sudo.PasswordChar = '*';
            this.txtBx_password_sudo.Size = new System.Drawing.Size(168, 20);
            this.txtBx_password_sudo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // btn_login_sudo
            // 
            this.btn_login_sudo.Location = new System.Drawing.Point(181, 173);
            this.btn_login_sudo.Name = "btn_login_sudo";
            this.btn_login_sudo.Size = new System.Drawing.Size(75, 23);
            this.btn_login_sudo.TabIndex = 5;
            this.btn_login_sudo.Text = "Login";
            this.btn_login_sudo.UseVisualStyleBackColor = true;
            this.btn_login_sudo.Click += new System.EventHandler(this.btn_login_sudo_Click);
            // 
            // btn_Back_adminlogin
            // 
            this.btn_Back_adminlogin.Location = new System.Drawing.Point(25, 172);
            this.btn_Back_adminlogin.Name = "btn_Back_adminlogin";
            this.btn_Back_adminlogin.Size = new System.Drawing.Size(75, 23);
            this.btn_Back_adminlogin.TabIndex = 6;
            this.btn_Back_adminlogin.Text = "Back";
            this.btn_Back_adminlogin.UseVisualStyleBackColor = true;
            this.btn_Back_adminlogin.Click += new System.EventHandler(this.btn_Back_adminlogin_Click);
            // 
            // SudoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 220);
            this.Controls.Add(this.btn_Back_adminlogin);
            this.Controls.Add(this.btn_login_sudo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBx_password_sudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBx_email_sudo);
            this.Name = "SudoLogin";
            this.Text = "KitBox - Admin login";
            this.Load += new System.EventHandler(this.SudoLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBx_email_sudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_password_sudo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_login_sudo;
        private System.Windows.Forms.Button btn_Back_adminlogin;
    }
}
