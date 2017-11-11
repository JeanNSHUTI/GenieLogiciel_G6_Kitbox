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
using System.Net.Mail;

namespace Kitbox
{
    public partial class Form7 : Form
    {
        //Fields
        public static Form7 Current;
        DbManager db;
        Client client_pswrd_change;
        Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();

        //Constructors
        public Form7()
        {
            Current = this;
            InitializeComponent();
        }
        public Form7(DbManager db)
        {
            Current = this;
            this.db = db;
            InitializeComponent();
        }
        public Form7(DbManager db, Client client)
        {
            Current = this;
            this.db = db;
            client_pswrd_change = client;
            InitializeComponent();
        }


        //Event handlers
        private void txtBx_email_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var test = new MailAddress(txtBx_email.Text);
                if (test.GetType() == typeof(MailAddress))
                {
                    txtBx_email.ForeColor = Color.Green;
                    txtBx_email.ForeColor = SystemColors.ControlText;
                }
            }
            catch
            {
                // wrong format for email
                txtBx_email.ForeColor = Color.Red;
            }
        }

        private void btn_generatePswrd_Click(object sender, EventArgs e)
        {
            string key;
            string message = "";
            //Test if client exists !!
            if (db.List_of_clients.Exists(x => x.Email == txtBx_email.Text))
            {
                key = KeyGenerator.GetUniqueKey(9);
                client_pswrd_change = db.List_of_clients.Find(a => a.Email == txtBx_email.Text);
                client_pswrd_change.Password = key;
                db.UpdateClient(client_pswrd_change);
                message = "Dear Mr. " + client_pswrd_change.Firstname + " " + client_pswrd_change.Lastname + ", \n\nHere is your new Kitbox Client Password: " + key + "\n\nPlease do not reply to this message.\n\nBest Regards\nKitbox IT services";
                SendMail.SendEmailFromAccount(app, "New Kitbox Client Password", message, txtBx_email.Text, "nshuti.jeanrene@outlook.com");
                //label2.Text = key;
                if (message != "")
                {
                    this.Dispose();
                    this.Close();
                    MessageBox.Show("Your new password has successfully been sent to your e-mail", "Titre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Loginup.Current.Show();
                }
            }
            else
            {
                MessageBox.Show("You are not yet registered as a Kitbox Client\nPlease sign up to proceed", "Titre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Loginup.Current.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
