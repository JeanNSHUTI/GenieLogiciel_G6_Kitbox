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
    public partial class ConfirmClientDetails : Form
    {
        //Fields
        public static ConfirmClientDetails Current;
        DbManager db;
        Client newclient;
        Order current_order;
        bool update_flag;

        //Constructors
        public ConfirmClientDetails()
        {
            Current = this;
            InitializeComponent();
        }
        public ConfirmClientDetails(DbManager db)
        {
            Current = this;
            this.db = db;
            InitializeComponent();
        }
        public ConfirmClientDetails(DbManager db, Client client, bool update_flag, Order order)
        {
            Current = this;
            this.db = db;
            this.update_flag = update_flag;
            newclient = client;
            current_order = order;
            InitializeComponent();
            lbl_FirstName.Text = client.Firstname;
            lbl_LastName.Text = client.Lastname;
            lbl_Tel.Text = client.Tel;
            lbl_Email.Text = client.Email;
            lbl_Address.Text = client.Address;
            lbl_Postalcode.Text = client.Postalcode;
            lbl_city.Text = client.City;
            lbl_Country.Text = client.Country;
        }

        //Event-handlers
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            if (update_flag)
            {
                db.UpdateClient(newclient);
                OrderRecap.Current.Show();
            }
            else
            {
                db.AddClient(newclient);
                Loginup login = new Loginup(db, current_order);
                login.ShowDialog();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5.Current.Show();
        }

        private void lbl_LastName_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmClientDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
