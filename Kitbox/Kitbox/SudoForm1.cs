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
    public partial class SudoForm1 : System.Windows.Forms.Form
    {
        //Fields
        public static SudoForm1 Current;
        DbManager db;


        //Constructors
        public SudoForm1()
        {
            //Current = this;
            InitializeComponent();
        }
        public SudoForm1(DbManager db)
        {
            Current = this;
            this.db = db;
            InitializeComponent();
        }

        private void SudoForm1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGestionStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sudo_InventoryOrders orderStock = new Sudo_InventoryOrders(db);
            orderStock.ShowDialog();
            this.Show();
        }

        private void buttonGestionCommande_Click(object sender, EventArgs e)
        {
            this.Hide();
            SudoForm4 form4 = new SudoForm4(db);
            form4.ShowDialog();
            this.Show();
        }

        private void button2Home_Click(object sender, EventArgs e)
        {
            //try and close any forms that are still open and using memory
            try
            {
                SudoForm4.Current.Dispose();
                SudoForm4.Current.Close();
                Sudo_Catalog_management.Current.Dispose();
                Sudo_Catalog_management.Current.Close();
                Sudo_InventoryOrders.Current.Dispose();
                Sudo_InventoryOrders.Current.Close();
            }
            catch(NullReferenceException)  //None of these forms have been opened
            {

            }
            finally
            {
                this.Dispose();
                this.Close();
                Home.Current.Show();
            }
        }

        private void button1_Catalog_management_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sudo_Catalog_management Catalog_management = new Sudo_Catalog_management(db);
            Catalog_management.ShowDialog();
            this.Show();
        }

    }
}
