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
using System.Timers;

namespace Kitbox
{
    public partial class Sudo_InventoryOrders : Form
    {
        //Fields
        public static Sudo_InventoryOrders Current;
        DbManager db;
        List<Element> elementsfound;

        //Constructors
        public Sudo_InventoryOrders(DbManager db)
        {
            Current = this;
            this.db = db; 
            InitializeComponent();
        }

        //Event Handlers
        private void Sudo_InventoryOrders_Load(object sender, EventArgs e)
        {
            foreach (Element element in db.List_of_stock)
            {
                element.CheckNeedforOrder();
            }
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("Code", 110);
            listView1.Columns.Add("Element Name", 165);
            listView1.Columns.Add("Dimensions", 100);
            listView1.Columns.Add("Color", 90);
            listView1.Columns.Add("Below Minimum Stock", 105);
            listView1.Columns.Add("Qty in stock", 40);
            listView1.Columns.Add("Supplier 1-Price", 90);
            listView1.Columns.Add("Supplier 1-Delay", 90);
            listView1.Columns.Add("Supplier 2-Price", 90);
            listView1.Columns.Add("Supplier 2-Delay", 90);

            Display();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                //Find index
                string identifier = listView1.SelectedItems[0].Text;
                label2.Text = "";

                //Get element selected
                Element element = db.List_of_stock.Find(x => x.Code == identifier);
                //Calculate best supplier
                string bestSupplier = element.ChooseBestSupplier();
                //find supplier from db
                Supplier best_Supplier = db.List_of_suppliers.Find(x => x.Name == bestSupplier);

                //Order
                this.Hide();
                Sudo_OrderElement order_element = new Sudo_OrderElement(db, element, best_Supplier);
                order_element.ShowDialog();
                Display();
                this.Show();
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Please select an element to order";
            }
        }

        private void txtBx_Namesearch_TextChanged(object sender, EventArgs e)
        {
            elementsfound = db.List_of_stock.FindAll(x => x.Name == txtBx_Namesearch.Text || (x.Code == txtBx_codesearch.Text && x.Name == txtBx_Namesearch.Text));

            if(elementsfound.Count == 0 )
            {
                txtBx_Namesearch.LostFocus += TxtBx_Namesearch_LostFocus;
            }

            lbl_info.Text = "";
            listView1.Items.Clear();
            listView1.BeginUpdate();

            //Add items in the listview
            string[] arr = new string[10];
            ListViewItem itm;
            foreach (Element elmnt in elementsfound)
            {
                arr[0] = elmnt.Code;
                arr[1] = elmnt.Name;
                arr[2] = elmnt.Dimensions_cm;
                arr[3] = elmnt.Color;
                if (elmnt.Needs_tobe_orderd)
                {
                    arr[4] = "YES";
                }
                else
                {
                    arr[4] = "NO";
                }
                arr[5] = elmnt.Quantity_in_stock.ToString();
                arr[6] = elmnt.Price_fournisseur1.ToString();
                arr[7] = elmnt.Delay_fournisseur1.ToString() + "days";
                arr[8] = elmnt.Price_fournisseur2.ToString();
                arr[9] = elmnt.Delay_fournisseur2.ToString() + "days";
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            Highlight();
            listView1.EndUpdate();
        }

        private void TxtBx_Namesearch_LostFocus(object sender, EventArgs e)
        {
            if (elementsfound.Count == 0 && txtBx_Namesearch.Text != "")
            {
                lbl_info.Text = "No results match your search";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void TxtBx_Codesearch_LostFocus(object sender, EventArgs e)
        {
            if(elementsfound.Count == 0 && txtBx_codesearch.Text != "")
            {
                lbl_info.Text = "No results match your search";
            }
        }

        private void txtBx_codesearch_TextChanged(object sender, EventArgs e)
        {
            elementsfound = db.List_of_stock.FindAll(x => x.Code == txtBx_codesearch.Text);
            txtBx_codesearch.LostFocus += TxtBx_Codesearch_LostFocus;
            lbl_info.Text = "";
            listView1.Items.Clear();
            listView1.BeginUpdate();

            //Add items in the listview
            string[] arr = new string[10];
            ListViewItem itm;
            foreach (Element elmnt in elementsfound)
            {
                arr[0] = elmnt.Code;
                arr[1] = elmnt.Name;
                arr[2] = elmnt.Dimensions_cm;
                arr[3] = elmnt.Color;
                if (elmnt.Needs_tobe_orderd)
                {
                    arr[4] = "YES";
                }
                else
                {
                    arr[4] = "NO";
                }
                arr[5] = elmnt.Quantity_in_stock.ToString();
                arr[6] = elmnt.Price_fournisseur1.ToString();
                arr[7] = elmnt.Delay_fournisseur1.ToString();
                arr[8] = elmnt.Price_fournisseur2.ToString();
                arr[9] = elmnt.Delay_fournisseur2.ToString();
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            Highlight();
            listView1.EndUpdate();
        }

        private void Highlight()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[4].Text == "YES")
                {
                    for (int x = 0; x < listView1.Items[i].SubItems.Count; x++)
                    {
                        listView1.Items[i].SubItems[x].BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            SudoForm1.Current.Show();
        }

        //Methods
        private void Display()
        {
            string needs_tobe_orderd = "";
            lbl_info.Text = "";
            listView1.Items.Clear();
            listView1.BeginUpdate();

            //Add items in the listview
            string[] arr = new string[10];
            ListViewItem itm;

            foreach (Element element in db.List_of_stock)
            {
                if (element.Needs_tobe_orderd == true)
                {
                    needs_tobe_orderd = "YES";
                    arr[0] = element.Code;
                    arr[1] = element.Name;
                    arr[2] = element.Dimensions_cm;
                    arr[3] = element.Color;
                    arr[4] = needs_tobe_orderd;
                    arr[5] = element.Quantity_in_stock.ToString();
                    arr[6] = element.Price_fournisseur1.ToString();
                    arr[7] = element.Delay_fournisseur1.ToString() + "days";
                    arr[8] = element.Price_fournisseur2.ToString();
                    arr[9] = element.Delay_fournisseur2.ToString() + "days";
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
            Highlight();
            if(listView1.Items.Count == 0)
            {
                lbl_info.Text = "There are no elements that currently need to be orderd";
            }
            else
            {
                lbl_info.Text = "";
            }
            listView1.EndUpdate();
        }

        private void btn_ManageOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sudo_ManageInventory manage = new Sudo_ManageInventory(db);
            manage.ShowDialog();
            this.Show();
        }
    }
}
