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
    public partial class Form1 : System.Windows.Forms.Form
    {
        //Fields
        public static Form1 Current;
        DbManager db;

        //Constructor
        public Form1()
        {
            Current = this;
            InitializeComponent();
        }
        public Form1(DbManager db)
        {
            Current = this;
            InitializeComponent();
            this.db = db;
        }

        //Event Handlers
        private void btn_compose_form1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(db);
            form2.ShowDialog();
        }

        private void btn_help_form1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help_Form1 helpform1 = new Help_Form1(db);
            helpform1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
