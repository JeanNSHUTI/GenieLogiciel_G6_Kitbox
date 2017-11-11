using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitboxClassLibrary;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Kitbox
{
    public partial class Form5 : System.Windows.Forms.Form
    {
        //Fields
        public static Form5 Current;
        DbManager db;
        Client newclient = new Client();
        Client updateclient;
        Order current_order;
        bool update_flag;

        //Constructor
        public Form5()
        {
            Current = this;
            InitializeComponent();
        }
        public Form5(DbManager db, Order order)
        {
            Current = this;
            this.db = db;
            update_flag = false;
            current_order = order;
            InitializeComponent();
        }
        public Form5(DbManager db, string email)
        {
            Current = this;
            this.db = db;
            update_flag = true;
            InitializeComponent();
            //Find client that needs to be edited
            updateclient = db.List_of_clients.Find(x => x.Email == email);

            //Prefill
            txtBx_Firstname.Text = updateclient.Firstname;
            txtBx_Lastname.Text = updateclient.Lastname;
            txtBx_Tel.Text = updateclient.Tel;
            txtBx_Email.Text = updateclient.Email;
            txtBx_Address.Text = updateclient.Address;
            txtbx_City.Text = updateclient.City;
            txtBx_Country.Text = updateclient.Country;
            txtBx_postalcode.Text = updateclient.Postalcode;
            txtBx_Password.Text = updateclient.Password;
            txtbox_confirmPassword.Text = updateclient.Password;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if(update_flag == true)
            {
                btn_Client_signup.Text = "Update";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Client_signup_Click(object sender, EventArgs e)
        {
            if(txtBx_Firstname.Text.Equals("") || txtBx_Lastname.Text.Equals("") || txtBx_Tel.Text.Equals("") || txtBx_Email.Text.Equals("") || txtbx_City.Text.Equals("") || txtBx_Address.Text.Equals("") || txtBx_Country.Text.Equals("") || txtBx_postalcode.Text.Equals("") || txtBx_Password.Text.Equals("") || txtbox_confirmPassword.Text.Equals(""))
            {
                MessageBox.Show("Please fill in all the fields ", "Titre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(!(txtBx_Firstname.ForeColor == Color.Red || txtBx_Lastname.ForeColor == Color.Red || txtBx_Tel.ForeColor == Color.Red || txtBx_Email.ForeColor == Color.Red || txtbx_City.ForeColor == Color.Red || txtBx_Address.ForeColor == Color.Red || txtBx_Country.ForeColor == Color.Red || txtBx_postalcode.ForeColor == Color.Red || txtBx_Password.ForeColor == Color.Red))
                {
                    if (txtbox_confirmPassword.Text == txtBx_Password.Text)
                    {
                        newclient.Password = txtBx_Password.Text;
                        if ((db.List_of_clients.Exists(x => x.Email == newclient.Email)) && (update_flag == false))
                        {
                            //Change password when client has forgotten his/hers.
                            Form6 form_newPasswrd = new Form6(db, newclient);
                            form_newPasswrd.ShowDialog();
                        }
                        else
                        {
                            //Add new Client(newclient) after confirmation or update exisiting client;
                            this.Hide();
                            ConfirmClientDetails confirm_details = new ConfirmClientDetails(db, newclient, update_flag, current_order);
                            confirm_details.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your Passwords do not match ", "Titre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please correct the fields highlighted in red ", "Titre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }        
        }

        private void txtBx_Firstname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtBx_Firstname.Text, @"^[a-zA-Z-éàèùâêîôûçëïü]+$"))
                {
                    newclient.Firstname = txtBx_Firstname.Text;
                    txtBx_Firstname.ForeColor = Color.Green;
                }
                else
                {
                    txtBx_Firstname.ForeColor = Color.Red;
                }
            }
            catch
            {
                txtBx_Firstname.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtBx_Lastname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtBx_Lastname.Text, @"^[a-zA-Z-éàèùâêîôûçëïü]+$"))
                {
                    newclient.Lastname = txtBx_Lastname.Text;
                    txtBx_Lastname.ForeColor = Color.Green;
                }
                else
                {
                    txtBx_Lastname.ForeColor = Color.Red;
                }
            }
            catch
            {
                txtBx_Lastname.ForeColor = SystemColors.ControlText;
            }

        }

        private void txtBx_Tel_TextChanged(object sender, EventArgs e)
        {
            int length = txtBx_Tel.Text.Length;
            try
            {
                if (Regex.IsMatch(txtBx_Tel.Text, @"^[0-9+]+$"))
                {
                    if(length <= 15)
                    {
                        newclient.Tel = txtBx_Tel.Text;
                        txtBx_Tel.ForeColor = Color.Green;
                    }
                    else
                    {
                        txtBx_Tel.ForeColor = Color.Red;
                    }
                }
                else
                {
                    txtBx_Tel.ForeColor = Color.Red;
                }
            }
            catch
            {
                txtBx_Tel.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtBx_Email_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var test = new MailAddress(txtBx_Email.Text);
                if (test.GetType() == typeof(MailAddress))
                {
                    newclient.Email = txtBx_Email.Text;
                    txtBx_Email.ForeColor = Color.Green;
                }
            }
            catch 
            {
                // wrong format for email
                txtBx_Email.ForeColor = Color.Red;
            }
        }

        private void txtBx_Address_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtBx_Address.Text, @"^[a-zA-Z0-9-éàèùâêîôûçëïü ']+$"))
                {
                    newclient.Address = txtBx_Address.Text;
                    txtBx_Address.ForeColor = Color.Green;
                }
                else
                {
                    txtBx_Address.ForeColor = Color.Red;
                }
            }
            catch
            {
                txtBx_Address.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtBx_postalcode_TextChanged(object sender, EventArgs e)
        {
            int length = txtBx_postalcode.Text.Length;
            try
            {
                if(length <= 12)
                {
                    if (Regex.IsMatch(txtBx_postalcode.Text, @"^[0-9]+$"))
                    {
                        newclient.Postalcode = txtBx_postalcode.Text;
                        txtBx_postalcode.ForeColor = Color.Green;
                    }
                    else
                    {
                        txtBx_postalcode.ForeColor = Color.Red;
                    }
                }
                else
                {
                    txtBx_postalcode.ForeColor = Color.Red;
                }
            }
            catch
            {
                txtBx_postalcode.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtbx_City_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtbx_City.Text, @"^[a-zA-Z-éàèùâêîôûçëïü '](?!.*?[^\na-zA-Zéàèùâêîôûçëïü ']{2}).*?[a-zA-Zéàèùâêîôûçëïü ']$"))
                {
                    newclient.City = txtbx_City.Text;
                    txtbx_City.ForeColor = Color.Green;
                }
                else
                {
                    txtbx_City.ForeColor = Color.Red;
                }
            }
            catch
            {
                txtbx_City.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtBx_Country_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtBx_Country.Text, @"^[a-zA-Z-éàèùâêîôûçëïü '](?!.*?[^\na-zA-Zéàèùâêîôûçëïü ']{2}).*?[a-zA-Zéàèùâêîôûçëïü ']$"))
                {
                    newclient.Country = txtBx_Country.Text;
                    txtBx_Country.ForeColor = Color.Green;
                }
                else
                {
                    txtBx_Country.ForeColor = Color.Red;
                }
            }
            catch
            {
                txtBx_Country.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtBx_Password_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtBx_Password.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{5,15}$")) //1+ number/1+ lowercase/1+ uppercase rule
                {
                    txtBx_Password.ForeColor = Color.Green;
                    label12.Text = "";
                }
                else
                {
                    txtBx_Password.ForeColor = Color.Red;
                    label12.ForeColor = Color.Red;
                    label12.Text = "Password too weak: 1+ number\n/1+ lowercase\n/1+ uppercase, \n/minimum 5 characters";
                }
            }
            catch
            {
                txtBx_Password.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtbox_confirmPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtbox_confirmPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{5,15}$")) 
                {
                    if(txtbox_confirmPassword.Text == txtBx_Password.Text)
                    {
                        txtbox_confirmPassword.ForeColor = Color.Green;
                    }
                    else
                    {
                        txtbox_confirmPassword.ForeColor = Color.Red;
                    }
                }
                else
                {
                    txtbox_confirmPassword.ForeColor = Color.Red;
                }
            }
            catch
            {
                txtbox_confirmPassword.ForeColor = Color.Red;
            }

        }
    }
}
