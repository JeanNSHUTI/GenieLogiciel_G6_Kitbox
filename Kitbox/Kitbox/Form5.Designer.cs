namespace Kitbox
{
    partial class Form5
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Client_signup = new System.Windows.Forms.Button();
            this.txtBx_Firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_Lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_Tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBx_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBx_postalcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBx_Country = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBx_Password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbox_confirmPassword = new System.Windows.Forms.TextBox();
            this.txtbx_City = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Client_signup
            // 
            this.btn_Client_signup.Location = new System.Drawing.Point(226, 362);
            this.btn_Client_signup.Name = "btn_Client_signup";
            this.btn_Client_signup.Size = new System.Drawing.Size(75, 23);
            this.btn_Client_signup.TabIndex = 0;
            this.btn_Client_signup.Text = "Sign up";
            this.btn_Client_signup.UseVisualStyleBackColor = true;
            this.btn_Client_signup.Click += new System.EventHandler(this.btn_Client_signup_Click);
            // 
            // txtBx_Firstname
            // 
            this.txtBx_Firstname.Location = new System.Drawing.Point(12, 62);
            this.txtBx_Firstname.Name = "txtBx_Firstname";
            this.txtBx_Firstname.Size = new System.Drawing.Size(127, 20);
            this.txtBx_Firstname.TabIndex = 1;
            this.txtBx_Firstname.TextChanged += new System.EventHandler(this.txtBx_Firstname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First name";
            // 
            // txtBx_Lastname
            // 
            this.txtBx_Lastname.Location = new System.Drawing.Point(160, 62);
            this.txtBx_Lastname.Name = "txtBx_Lastname";
            this.txtBx_Lastname.Size = new System.Drawing.Size(141, 20);
            this.txtBx_Lastname.TabIndex = 3;
            this.txtBx_Lastname.TextChanged += new System.EventHandler(this.txtBx_Lastname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // txtBx_Tel
            // 
            this.txtBx_Tel.Location = new System.Drawing.Point(12, 120);
            this.txtBx_Tel.Name = "txtBx_Tel";
            this.txtBx_Tel.Size = new System.Drawing.Size(127, 20);
            this.txtBx_Tel.TabIndex = 5;
            this.txtBx_Tel.TextChanged += new System.EventHandler(this.txtBx_Tel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mobile number";
            // 
            // txtBx_Email
            // 
            this.txtBx_Email.Location = new System.Drawing.Point(160, 120);
            this.txtBx_Email.Name = "txtBx_Email";
            this.txtBx_Email.Size = new System.Drawing.Size(141, 20);
            this.txtBx_Email.TabIndex = 7;
            this.txtBx_Email.TextChanged += new System.EventHandler(this.txtBx_Email_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail";
            // 
            // txtBx_Address
            // 
            this.txtBx_Address.Location = new System.Drawing.Point(12, 183);
            this.txtBx_Address.Name = "txtBx_Address";
            this.txtBx_Address.Size = new System.Drawing.Size(127, 20);
            this.txtBx_Address.TabIndex = 9;
            this.txtBx_Address.TextChanged += new System.EventHandler(this.txtBx_Address_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Street Address";
            // 
            // txtBx_postalcode
            // 
            this.txtBx_postalcode.Location = new System.Drawing.Point(160, 183);
            this.txtBx_postalcode.Name = "txtBx_postalcode";
            this.txtBx_postalcode.Size = new System.Drawing.Size(141, 20);
            this.txtBx_postalcode.TabIndex = 11;
            this.txtBx_postalcode.TextChanged += new System.EventHandler(this.txtBx_postalcode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Postal Code";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "City";
            // 
            // txtBx_Country
            // 
            this.txtBx_Country.Location = new System.Drawing.Point(160, 256);
            this.txtBx_Country.Name = "txtBx_Country";
            this.txtBx_Country.Size = new System.Drawing.Size(141, 20);
            this.txtBx_Country.TabIndex = 15;
            this.txtBx_Country.TextChanged += new System.EventHandler(this.txtBx_Country_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sign Up";
            // 
            // txtBx_Password
            // 
            this.txtBx_Password.Location = new System.Drawing.Point(12, 315);
            this.txtBx_Password.MaxLength = 20;
            this.txtBx_Password.Name = "txtBx_Password";
            this.txtBx_Password.PasswordChar = '*';
            this.txtBx_Password.Size = new System.Drawing.Size(124, 20);
            this.txtBx_Password.TabIndex = 18;
            this.txtBx_Password.TextChanged += new System.EventHandler(this.txtBx_Password_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Password";
            // 
            // txtbox_confirmPassword
            // 
            this.txtbox_confirmPassword.Location = new System.Drawing.Point(160, 315);
            this.txtbox_confirmPassword.MaxLength = 20;
            this.txtbox_confirmPassword.Multiline = true;
            this.txtbox_confirmPassword.Name = "txtbox_confirmPassword";
            this.txtbox_confirmPassword.PasswordChar = '*';
            this.txtbox_confirmPassword.Size = new System.Drawing.Size(141, 20);
            this.txtbox_confirmPassword.TabIndex = 20;
            this.txtbox_confirmPassword.TextChanged += new System.EventHandler(this.txtbox_confirmPassword_TextChanged);
            // 
            // txtbx_City
            // 
            this.txtbx_City.Location = new System.Drawing.Point(12, 256);
            this.txtbx_City.Name = "txtbx_City";
            this.txtbx_City.Size = new System.Drawing.Size(127, 20);
            this.txtbx_City.TabIndex = 21;
            this.txtbx_City.TextChanged += new System.EventHandler(this.txtbx_City_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Confirm Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 23;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(318, 397);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbx_City);
            this.Controls.Add(this.txtbox_confirmPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBx_Password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBx_Country);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBx_postalcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBx_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBx_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBx_Tel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBx_Lastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_Firstname);
            this.Controls.Add(this.btn_Client_signup);
            this.Name = "Form5";
            this.Text = "KitBox";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Client_signup;
        private System.Windows.Forms.TextBox txtBx_Firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_Lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_Tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBx_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBx_postalcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBx_Country;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBx_Password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbox_confirmPassword;
        private System.Windows.Forms.TextBox txtbx_City;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

