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

namespace Kitbox
{
    public partial class Loginup : Form
    {
        //Fields
        public static Loginup Current;
        DbManager db;
        Order order;

        //Constructor
        public Loginup()
        {
            Current = this;
            InitializeComponent();
        }
        public Loginup(DbManager db)
        {
            Current = this;
            this.db = db;
            InitializeComponent();
        }

        public Loginup(DbManager db, Order order)
        {
            Current = this;
            this.db = db;
            this.order = order;
            InitializeComponent();
        }

        //Event Handlers
        private void Loginup_Load(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Client new_clientlogin = new Client(txtbox_email.Text, txtbox_password.Text);
            if (db.VerifyClient(new_clientlogin))
            {
                Client clientinfo = db.List_of_clients.Find(x => x.Email == txtbox_email.Text);
                order.Client_email = new_clientlogin.Email;
                order.Lastname = clientinfo.Lastname;
                order.Firstname = clientinfo.Firstname;
                this.Hide();
                OrderRecap recap = new OrderRecap(db, new_clientlogin.Email, order);
                recap.ShowDialog();
            }
            else
            {
                // On ajoute une icône : celle d'une erreur. On change aussi les boutons...
                MessageBox.Show("This is not a valid username and/or password", "Titre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void newClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Client has not yetr signed up
            this.Dispose();
            this.Close();
            Form5 sign_up = new Form5(db, order);
            sign_up.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Client has forgotten password
            this.Hide();
            Form7 generateNewPswrd = new Form7(db);
            generateNewPswrd.ShowDialog();
        }
    }
}
