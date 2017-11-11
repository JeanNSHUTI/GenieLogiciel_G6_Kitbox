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
    public partial class Home : System.Windows.Forms.Form
    {
        //Fields
        public static Home Current;
        DbManager db;

        //Constructor
        public Home()
        {
            Current = this;
            InitializeComponent();
        }
        public Home(DbManager db)
        {
            Current = this;
            this.db = db;
            InitializeComponent();
        }

        //Event handlers
        private void btn_user_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(db);
            form1.ShowDialog();
            //form1 = null;
            this.Show();
        }

        private void btn_admin_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            SudoLogin admin = new SudoLogin(db);
            admin.ShowDialog();
            //admin = null;
            this.Show();
        }
    }
}
