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
    public partial class OrderRecap : Form
    {
        //Fields
        public static OrderRecap Current;
        DbManager db;
        Client client;
        string client_email;
        Order order;
        int i = 1;
        int a = 1;


        //Constructors
        public OrderRecap()
        {
            Current = this;
            InitializeComponent();
        }
        public OrderRecap(DbManager db, string email, Order order)
        {
            Current = this;
            this.db = db;
            client_email = email;
            this.order = order;
            InitializeComponent();
        }

        //Event handlers
        private void OrderRecap_Load(object sender, EventArgs e)
        {
            //Display User
            listView_Clientdetails.View = View.Details;
            listView_Clientdetails.FullRowSelect = true;
            //Add column header
            listView_Clientdetails.Columns.Add("First Name", 150);
            listView_Clientdetails.Columns.Add("Last Name", 150);
            listView_Clientdetails.Columns.Add("Email", 200);

            ClientDisplay();
            
            //Display Order
            listView_Order.View = View.Details;
            listView_Order.FullRowSelect = true;
            //Add column header
            listView_Order.Columns.Add("Date", 90);
            listView_Order.Columns.Add("Order Id", 80);
            listView_Order.Columns.Add("Product Name", 150);
            listView_Order.Columns.Add("Dimensions (HxWxD)", 120);
            listView_Order.Columns.Add("Color (R/T/B/L/R)", 180);
            listView_Order.Columns.Add("Price", 57);

            OrderDisplay();
        }

        private void btn_Edit_personalDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 edit_client = new Form5(db, client_email);
            edit_client.ShowDialog();
            ClientDisplay();
            this.Show();

        }

        private void precedentRecap_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Form2.clearkitlist_flag = true;
            Form2.Current.Show();
        }

        private void btn_ConfirmRecap_Click(object sender, EventArgs e)
        {
            //Add order to db list of active orders!
            db.List_of_orders.Add(order);
            this.Dispose();
            this.Close();
            //Form2.Current.Dispose();
            Form2.Current.Close();
            Form2.clearkitlist_flag = false;
            ConfirmOrder print_order = new ConfirmOrder();
            print_order.ShowDialog();
        }

        private void listView_Clientdetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Delete_recap_Click(object sender, EventArgs e)
        {
            Order_debug debug = new Order_debug(db, order);
            debug.Show();
        }

        //Methods
        private void ClientDisplay()
        {
            listView_Clientdetails.Items.Clear();
            listView_Clientdetails.BeginUpdate();

            //Add items in the listview
            string[] client_array = new string[3];
            ListViewItem itm;

            //Add first item
            client = db.List_of_clients.Find(x => x.Email == client_email);
            client_array[0] = client.Firstname;
            client_array[1] = client.Lastname;
            client_array[2] = client.Email;
            itm = new ListViewItem(client_array);
            listView_Clientdetails.Items.Add(itm);

            listView_Clientdetails.EndUpdate();
        }
        
        private void OrderDisplay()
        {
            listView_Order.Items.Clear();
            listView_Order.BeginUpdate();

            //Add items in the listview
            string[] order_array = new string[6];
            string[] racks_array = new string[6];
            ListViewItem order_itm;
            ListViewItem racks;

            //Add first item
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("fr-FR");
            order.CalculatePrice();
            Decimal totalprice = Convert.ToDecimal(order.Totalprice, culture);
            order_array[0] = order.Date.ToShortDateString();
            order_array[1] = order.OrderID.ToString();
            order_array[5] = Math.Round(totalprice, 2).ToString();
            foreach (CabinetKit kit in order.List_of_cabinetkits)
            {
                if (i > 1) { order_array[0] = ""; order_array[1] = ""; order_array[5] = ""; }
                order_array[2] = kit.Name + " " + i;
                order_array[3] = kit.CalculateHeight().ToString() + " x " + kit.ToString();
                order_array[4] = "";
                order_itm = new ListViewItem(order_array);
                listView_Order.Items.Add(order_itm);
                foreach (Rack rack in kit.List_of_racks)
                {
                    racks_array[0] = "";
                    racks_array[1] = "";
                    racks_array[2] = "  " + rack.Name + " " + a;
                    racks_array[3] = rack.Height + " x " + rack.Width + " x " + rack.Depth;
                    racks_array[4] = rack.Colors[0] + "/" + rack.Colors[1] + "/" + rack.Colors[2] + "/" + rack.Colors[3] + "/" + rack.Colors[4];
                    racks_array[5] = "";
                    racks = new ListViewItem(racks_array);
                    listView_Order.Items.Add(racks);
                    a++;
                }
                i++;
                a = 1;
            }

            listView_Order.EndUpdate();
        }
    }
}
