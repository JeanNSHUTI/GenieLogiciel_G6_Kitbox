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
    public partial class Sudo_ManageInventory : Form
    {
        //Fields
        DbManager db;
        InventoryOrder orderfound;
        bool info_flag= false;

        //Construcors
        public Sudo_ManageInventory(DbManager db)
        {
            this.db = db;
            InitializeComponent();
        }


        //Event Handlers
        private void Sudo_ManageInventory_Load(object sender, EventArgs e)
        {
            listV_InventOrders.View = View.Details;
            listV_InventOrders.FullRowSelect = true;

            //Add column header
            listV_InventOrders.Columns.Add("Id", 60);
            listV_InventOrders.Columns.Add("Date", 90);
            listV_InventOrders.Columns.Add("Code", 110);
            listV_InventOrders.Columns.Add("Dimensions", 100);
            listV_InventOrders.Columns.Add("Color", 90);
            listV_InventOrders.Columns.Add("Supplier", 105);
            listV_InventOrders.Columns.Add("Qty orderd", 90);
            listV_InventOrders.Columns.Add("Price", 90);

            Display();
        }

        //Methods
        private void Display()
        {
            if(db.StockOrders.Count == 0)
            {
                listV_InventOrders.Items.Clear();
                lbl_info.Text = "There are no orders that need to be treated";
            }
            else
            {
                lbl_info.Text = "";
                listV_InventOrders.Items.Clear();
                listV_InventOrders.BeginUpdate();

                //Add items in the listview
                string[] arr = new string[8];
                ListViewItem itm;

                foreach (InventoryOrder order in db.StockOrders)
                {
                    order.CalculatePrice();
                    arr[0] = order.OrderId.ToString();
                    arr[1] = order.Date.ToShortDateString();
                    arr[2] = order.ElementCode;
                    arr[3] = order.ElementDimensions;
                    arr[4] = order.ElementColor;
                    arr[5] = order.SupplierName;
                    arr[6] = order.Quantity.ToString();
                    arr[7] = order.Price.ToString();
                    itm = new ListViewItem(arr);
                    listV_InventOrders.Items.Add(itm);
                }
                listV_InventOrders.EndUpdate();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_applyChanges_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listV_InventOrders.CheckedItems)
            {
                int identifier = Int32.Parse(item.Text); //Converts OrderID of item checked to an integer
                //Get order
                InventoryOrder order = db.StockOrders.Find(x => x.OrderId == identifier);
                //Retrieve element from order and update stock qty
                Element element = order.ElementOrdered;
                element.UpdateStockQty(order.Quantity);
                //Update element in db
                db.UpdateStockCount(element);
                //Remove Order from list
                db.StockOrders.Remove(order);
            }
            this.Dispose();
            this.Close();
            MessageBox.Show("Orders have successfully been marked as received !", "Titre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Sudo_InventoryOrders.Current.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listV_InventOrders.Items.Clear();
            lbl_info.Text = "";
            int result;
            if(Int32.TryParse(textBox1.Text, out result) == true)
            {
                info_flag = false;
                orderfound = db.StockOrders.Find(a => a.OrderId == result);

                if (orderfound == null)
                {
                    textBox1.LostFocus += textBox1_LostFocus;
                }
                else
                {
                    lbl_info.Text = "";
                    listV_InventOrders.Items.Clear();
                    listV_InventOrders.BeginUpdate();

                    //Add items in the listview
                    string[] arr = new string[8];
                    ListViewItem itm;

                    arr[0] = orderfound.OrderId.ToString();
                    arr[1] = orderfound.Date.ToShortDateString();
                    arr[2] = orderfound.ElementCode;
                    arr[3] = orderfound.ElementDimensions;
                    arr[4] = orderfound.ElementColor;
                    arr[5] = orderfound.SupplierName;
                    arr[6] = orderfound.Quantity.ToString();
                    arr[7] = orderfound.Price.ToString();
                    itm = new ListViewItem(arr);
                    listV_InventOrders.Items.Add(itm);
                    listV_InventOrders.EndUpdate();
                }
            }
            else
            {
                info_flag = true;
                textBox1.LostFocus += textBox1_LostFocus;
            }
        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            if (orderfound == null && textBox1.Text != "")
            {
                lbl_info.Text = "There are no results that match your search";
            }
            if (orderfound == null && info_flag == true && textBox1.Text != "")
            {
                lbl_info.Text = "Error Format: Order ID has to be a whole number";
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
