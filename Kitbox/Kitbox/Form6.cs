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
    public partial class Form6 : Form
    {
        //Fields
        public static Form6 Current;
        DbManager db;
        Client newclient;

        //Constructors
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(DbManager db, Client client)
        {
            Current = this;
            this.db = db;
            newclient = client;
            InitializeComponent();
        }

        //Event Handlers
        private void linkLbl_Newpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5.Current.Dispose();
            Form5.Current.Close();
            this.Dispose();
            this.Close();
            Form7 generateNewPswrd = new Form7(db, newclient);
            generateNewPswrd.ShowDialog();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Form5.Current.Show();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Loginup.Current.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
