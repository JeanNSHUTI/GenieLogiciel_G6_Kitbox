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
    public partial class Order_debug : Form
    {
        //Fields
        public static bool billingFlag = false;
        DbManager db;
        Order order;
        int i = 1;
        int nbr = 1;
        string available;


        public Order_debug(DbManager db, Order order)
        {
            this.db = db;
            this.order = order;
            InitializeComponent();
        }

        private void Order_debug_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            if(billingFlag == true)
            {
                btn_confirm.Text = "Save";
                checkBox_delivered.Enabled = true;
                checkBox_paid.Enabled = true;
                checkBox_delivered.Visible = true;
                checkBox_paid.Visible = true;

                checkBox_delivered.Checked = SudoForm4.order.Delivered_flag;
                checkBox_paid.Checked = SudoForm4.order.Paid_flag;
            }

            //Display
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            //Add column header
            listView1.Columns.Add("Product Name", 200);
            listView1.Columns.Add("Code", 110);
            listView1.Columns.Add("Dimensions", 150);
            listView1.Columns.Add("Color", 90);
            listView1.Columns.Add("Price", 80);
            listView1.Columns.Add("In Stock", 80);
            listView1.Columns.Add("Delay", 80);
            //Add items in the listview
            string[] arr = new string[7];
            ListViewItem itm;

            //Add first item
            //List<CabinetKit> list_ofcabinet = db.List_of_clients.Find(x => x.Email == client_email);
            foreach(CabinetKit kit in order.List_of_cabinetkits)
            {
                arr[0] = kit.Name + " " + nbr;
                arr[1] = "";
                arr[2] = "";
                arr[3] = "";
                arr[4] = "";
                arr[5] = "";
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
                foreach (Rack rack in kit.List_of_racks)
                {
                    foreach (Element element in rack.List_of_elements)
                    {
                        arr[0] = "  " + i + " " + element.Name;
                        arr[1] = element.Code;
                        arr[2] = element.Dimensions_cm;
                        arr[3] = element.Color;
                        arr[4] = element.Price_client.ToString();
                        if (element.Available == true)
                        {
                            available = "YES";
                            arr[6] = "";
                        }
                        else
                        {
                            available = "NO";
                            arr[6] = element.Bestdelay().ToString() + " days";
                        }
                        arr[5] = available;
                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                        i++;
                    }
                }
                foreach (Steel_CornerBar cornerbar in kit.Steel_corner_bars)
                {
                    arr[0] = "  " +  i + " " + cornerbar.Name;
                    arr[1] = cornerbar.Code;
                    arr[2] = cornerbar.Dimensions_cm;
                    arr[3] = cornerbar.Color;
                    arr[4] = cornerbar.Price_client.ToString();
                    if (cornerbar.Available == true)
                    {
                        available = "YES";
                        arr[6] = "";
                    }
                    else
                    {
                        available = "NO";
                        arr[6] = cornerbar.Bestdelay().ToString() + " days";
                    }
                    arr[5] = available;
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                    i++;
                }
                nbr++;
            }

            for(int i = 0; i < listView1.Items.Count; i++)
            {
                if(listView1.Items[i].SubItems[5].Text == "NO")
                {
                    for(int x = 0; x < listView1.Items[i].SubItems.Count; x++)
                    {
                        listView1.Items[i].SubItems[x].BackColor = Color.Red;
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(billingFlag == true)
            {
                if(SudoForm4.order.Paid_flag == true && SudoForm4.order.Paid_flag == true)
                {
                    SudoForm4.order.State = "Passive";
                }
                this.Dispose();
                this.Close();
                SudoForm4.Current.Show();
            }
            else
            {
                this.Dispose();
                this.Close();
                OrderRecap.Current.Show();
            }
        }

        private void checkBox_paid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_paid.Checked == true)
            {
                SudoForm4.order.Paid_flag = true;
            }
        }

        private void checkBox_delivered_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_delivered.Checked == true)
            {
                SudoForm4.order.Delivered_flag = true;
            }
        }
    }
}
