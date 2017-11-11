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
    public partial class Catalog_Form1 : Form
    {

        //Fields
        DbManager db;
        

        public Catalog_Form1(DbManager db)
        {
            this.db = db;
            InitializeComponent();
        }


        private void Catalog_Form1_Load(object sender, EventArgs e)
        {
            lbl_Catalog.Font = new Font("Arial", 12, FontStyle.Bold);
            //Display;
            listView_catalog.View = View.Details;
            listView_catalog.FullRowSelect = true;
            //Add column header
            listView_catalog.Columns.Add("Product Name", 200);
            listView_catalog.Columns.Add("Dimensions (HxWxD)", 120);
            listView_catalog.Columns.Add("Color", 120);
            listView_catalog.Columns.Add("Qty/rack", 60);
            listView_catalog.Columns.Add("Qty in stock", 65);
            listView_catalog.Columns.Add("Price", 60);
            listView_catalog.Columns.Add("Delay", 60);
            //Add items in the listview

            //Display
            Display();
        }

        private void btn_BackToHelp_Click(object sender, EventArgs e)
        {
            //Back to help form
            this.Dispose();
            this.Close();
            Help_Form1.Current.Show();

        }

        private void btn_backToForm1_Click(object sender, EventArgs e)
        {
            //Back to form1
            this.Dispose();
            this.Close();
            Help_Form1.Current.Dispose();
            Help_Form1.Current.Close();
            Form1.Current.Show();
        }

        private void Display()
        {
            string[] arr = new string[7];
            ListViewItem itm;

            //Add first item
            //List<CabinetKit> list_ofcabinet = db.List_of_clients.Find(x => x.Email == client_email);
            foreach (Element elmnt in db.List_of_stock)
            {
                arr[0] = elmnt.Name;
                arr[1] = elmnt.Dimensions_cm;
                arr[2] = elmnt.Color;
                arr[3] = elmnt.Quantity_per_rack.ToString();
                arr[4] = elmnt.Quantity_in_stock.ToString();
                arr[5] = elmnt.Price_client.ToString();
                if(elmnt.Available == true)
                {
                    arr[6] = "";
                }
                else if(elmnt.Available == false)
                {
                    arr[6] = elmnt.Bestdelay().ToString() + "days";
                }
                itm = new ListViewItem(arr);
                listView_catalog.Items.Add(itm);
            }

            for (int i = 0; i < listView_catalog.Items.Count; i++)
            {
                if (listView_catalog.Items[i].SubItems[6].Text != "")
                {
                    for (int x = 0; x < listView_catalog.Items[i].SubItems.Count; x++)
                    {
                        listView_catalog.Items[i].SubItems[x].BackColor = Color.Green;
                    }
                }
            }

            listView_catalog.EndUpdate();

        }
    }
            
 
}
