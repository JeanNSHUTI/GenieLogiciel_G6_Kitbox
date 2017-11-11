using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using KitboxClassLibrary;

namespace Kitbox
{
    public partial class Help_Form1 : System.Windows.Forms.Form
    {
        //Fields
        public static Help_Form1 Current;
        DbManager db;
        string path = @"C:\Users\Jean\Documents\Visual Studio 2015\Projects\Group6Kitbox\Help.txt";


        //Constructor
        public Help_Form1(DbManager db)
        {
            this.db = db;
            Current = this;
            InitializeComponent();
        }

        private void Help_Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine("File doesn't exists !");
                }
                else
                {
                    string text = sr.ReadToEnd();
                    richTextBox1.Text = text;
                }
            }
        }

        private void btn_help_next_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_skipto_catalog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalog_Form1 catalogform1 = new Catalog_Form1(db);
            catalogform1.ShowDialog();
        }
    }
}
