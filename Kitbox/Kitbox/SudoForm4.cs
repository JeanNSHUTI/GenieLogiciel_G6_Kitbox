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
    public partial class SudoForm4 : System.Windows.Forms.Form
    {
        //Fields
        public static SudoForm4 Current;
        public static Order order;
        List<Order> ordersfound;
        DbManager db;
        int iD;
        //public Employee current_employee;

        public SudoForm4()
        {
            Current = this;
            InitializeComponent();
        }
        public SudoForm4(DbManager db)
        {
            Current = this;
            this.db = db;
            //this.current_employee = current_employee;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1Back_Click(object sender, EventArgs e)
        {
            Form2.clearkitlist_flag = false;
            this.Dispose();
            this.Close();
            SudoForm1.Current.Show();
            this.Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SudoForm4_Load(object sender, EventArgs e)
        {
            txtBx_ID.KeyPress += TxtBx_ID_KeyPress;

            tabPage1.Text = "Active Orders";
            tabPage2.Text = "Passive Orders";
            tabPage2.MouseClick += TabPage2_MouseClick;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

            //Display User
            listView_active.View = View.Details;
            listView_active.FullRowSelect = true;
            //Add column header
            listView_active.Columns.Add("Order Id", 50);
            listView_active.Columns.Add("Date", 60);
            listView_active.Columns.Add("First Name", 120);
            listView_active.Columns.Add("Last Name", 120);           
            listView_active.Columns.Add("Email", 120);
            listView_active.Columns.Add("Price", 80);

            //Display User
            listView_passive.View = View.Details;
            listView_passive.FullRowSelect = true;
            //Add column header
            listView_passive.Columns.Add("Order Id", 50);
            listView_passive.Columns.Add("Date", 60);
            listView_passive.Columns.Add("First Name", 120);
            listView_passive.Columns.Add("Last Name", 120);
            listView_passive.Columns.Add("Email", 120);
            listView_passive.Columns.Add("Price", 70);

            Display1();


        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])//your specific tabname
            {
                btn_edit.Enabled = false;
                btn_treat.Enabled = false;
                Display1();
            }
            else if(tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                btn_edit.Enabled = true;
                btn_treat.Enabled = true;
                Display1();
            }
        }

        private void TxtBx_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                lbl_info.ForeColor = Color.Red;
                lbl_info.Text = "Order Id has to be a number";
                e.Handled = true;
            }
            else
            {
                lbl_info.Text = "";
            }
        }

        private void TabPage2_MouseClick(object sender, MouseEventArgs e)
        {
            btn_edit.Enabled = false;
            btn_treat.Enabled = false;
            Display1();
        }

        private void btn_treat_Click(object sender, EventArgs e)
        {
            //Display complete and detailed list of all elements in order
            //Only one item can be chosen at a time for edit
            foreach (ListViewItem item in listView_active.Items)
                if (item.Selected)
                {
                    //Find index
                    int order_id = Int32.Parse(item.Text);
                    label7.Text = "";

                    //Find order
                    Order treat_order = db.List_of_orders.Find(a => a.OrderID == order_id);
                    int index = db.List_of_orders.FindIndex(a => a.OrderID == order_id);
                    order = treat_order;

                    //Set flag for view
                    Order_debug.billingFlag = true;
                    this.Hide();
                    Order_debug billing = new Order_debug(db, treat_order);
                    billing.ShowDialog();

                    //Update order in db
                    db.UpdateOrder(order, index);

                    if (order.State == "Passive")
                    {
                        //Update count of each element in stock
                        db.UpdateStock_onOrder(order);
                    }
                    //refresh display
                    Display1();
                    break;
                }
                else if (listView_active.SelectedItems.Count == 0)
                {
                    label7.ForeColor = Color.Red;
                    label7.Text = "You have not selected an item !";
                    break;
                }


            //Generate pdf also?

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //Only one item can be chosen at a time for edit
            foreach (ListViewItem item in listView_active.Items)
                if (item.Selected)
                {
                    //Find index
                    int order_id = Int32.Parse(item.Text);
                    label3.Text = "";

                    //Find order
                    Order edit_order = db.List_of_orders.Find(a => a.OrderID == order_id);
                    int index = db.List_of_orders.FindIndex(a => a.OrderID == order_id);

                    SudoLogin.current_employee.Editorder_flag = true;
                    order = edit_order;
                    //Form2.clearkitlist_flag = true;
                    this.Hide();
                    Form2 editOrder = new Form2(db, edit_order.List_of_cabinetkits);  
                    editOrder.ShowDialog();

                    //Update order in db
                    db.UpdateOrder(order, index);

                    //refresh display
                    Display1();
                    break;
                }
                else if (listView_active.SelectedItems.Count == 0)
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "You have not selected an item !";
                    break;
                }
        }

        private void listView_active_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {           
            if(comboBx_FirstN.Text == "" && comboBx_LastN.Text == "" && txtBx_ID.Text == "")
            {
                lbl_info.Text = "All search fields are empty";
            }
            else
            {
                lbl_info.Text = "";
                if(txtBx_ID.Text != "")
                {
                    iD = Int32.Parse(txtBx_ID.Text);
                }               
                ordersfound = db.List_of_orders.FindAll(x => x.OrderID == iD || x.Firstname == comboBx_FirstN.Text || x.Lastname == comboBx_LastN.Text);
                if(ordersfound.Count == 0)
                {
                    lbl_info.Text = "No results match your search";
                }
                else
                {
                    Display2(ordersfound);
                }
            }
        }

        private void Display1()
        {
            lbl_info.Text = "";
            label7.Text = "";
            label3.Text = "";
            listView_active.Items.Clear();
            listView_active.BeginUpdate();

            listView_passive.Items.Clear();
            listView_passive.BeginUpdate();

            //Add items in the listview
            string[] array = new string[6];
            ListViewItem order_itm;


            //Add first item
            foreach (Order order in db.List_of_orders)
            {
                array[0] = order.OrderID.ToString();
                array[1] = order.Date.ToShortDateString();
                array[2] = order.Firstname;
                array[3] = order.Lastname;
                array[4] = order.Client_email;
                array[5] = order.Totalprice.ToString();
                order_itm = new ListViewItem(array);
                if (order.State == "Active")
                {
                    
                    listView_active.Items.Add(order_itm);
                }
                else if(order.State == "Passive")
                {
                    listView_passive.Items.Add(order_itm);
                }
            }

            listView_active.EndUpdate();
            listView_passive.EndUpdate();

        }
        private void Display2(List<Order> ordersfound)
        {
            listView_active.Items.Clear();
            listView_active.BeginUpdate();
            listView_passive.Items.Clear();
            listView_passive.BeginUpdate();

            //Add items in the listview
            string[] array = new string[6];
            ListViewItem order_itm;

            //Add first item
            foreach (Order order in ordersfound)
            {
                array[0] = order.OrderID.ToString();
                array[1] = order.Date.ToShortDateString();
                array[2] = order.Firstname;
                array[3] = order.Lastname;
                array[4] = order.Client_email;
                array[5] = order.Totalprice.ToString();
                order_itm = new ListViewItem(array);
                if (order.State == "Active")
                {

                    listView_active.Items.Add(order_itm);
                }
                else if (order.State == "Passive")
                {
                    listView_passive.Items.Add(order_itm);
                }
            }

            listView_active.EndUpdate();
            listView_passive.EndUpdate();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
