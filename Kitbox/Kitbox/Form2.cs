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
    public partial class Form2 : System.Windows.Forms.Form
    {
        //Fields
        public static Form2 Current;
        DbManager db;
        List<CabinetKit> list_of_cabinetkits;
        Order order;
        bool edit_Cabinet_flag;
        public static bool clearkitlist_flag = false; //Flag set when client has decided to change order from Recap. ref (ctrl.back)

        //Constructor
        public Form2()
        {
            Current = this;
            InitializeComponent();
        }
        public Form2(DbManager db)
        {
            Current = this;
            this.db = db;
            list_of_cabinetkits = new List<CabinetKit>();
            InitializeComponent();
        }
        public Form2(DbManager db, List<CabinetKit> list_of_cabinetkits)
        {
            Current = this;
            this.db = db;
            this.list_of_cabinetkits = list_of_cabinetkits;
            order = new Order();
            InitializeComponent();
        }

        //Event handlers
        private void Form2_Load(object sender, EventArgs e)
        {
            if(SudoLogin.current_employee.Editorder_flag == true)
            {
                label2_sudo.ForeColor = Color.Green;
                label2_sudo.Text = SudoLogin.current_employee.Firstname + " " + SudoLogin.current_employee.Lastname + " is editing";
            }


            //Display;
            listView_order.View = View.Details;
            listView_order.FullRowSelect = true;
            //Add column header
            listView_order.Columns.Add("Product Name", 200);
            listView_order.Columns.Add("Dimensions (HxWxD)", 120);
            listView_order.Columns.Add("Price", 120);
            //Add items in the listview

            //Display
            Display();
            
        }

        private void btn_cancel_form2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Current.Show();
        }

        private void btn_finished_form2_Click_1(object sender, EventArgs e)
        {
            //try catch --> List_of_cabinets null no cabinet has been created -> NullReferenceException 
            try
            {
                if(clearkitlist_flag == true)
                {
                    order.List_of_cabinetkits.Clear();
                }
                order.List_of_cabinetkits.AddRange(list_of_cabinetkits);
                if (SudoLogin.current_employee.Editorder_flag == true)
                {
                    SudoForm4.order.List_of_cabinetkits = order.List_of_cabinetkits;
                    SudoForm4.order.CalculatePrice();
                    //Set Order in question and return to back-end                  
                    //SudoForm4.order = order;
                    this.Close();
                    this.Dispose();
                    SudoForm4.Current.Show();
                }
                else
                {
                    this.Hide();
                    Loginup log_in = new Loginup(db, order);
                    log_in.ShowDialog();
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Your shopping cart is empty !", "Titre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Addcabinet_F2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3(db, list_of_cabinetkits);
            form3.ShowDialog();
        }

        private void btn_DeleteCabinet_F2_Click(object sender, EventArgs e)
        {
            
            //Only one item can be chosen at a time for deletion
            foreach (ListViewItem item in listView_order.Items)
            {
                if (item.Selected)
                {
                    //Find index
                    int index = item.Index;
                    label2_delete.Text = "";

                    //Remove from list of cabinets and display
                    list_of_cabinetkits.RemoveAt(index);
                    listView_order.Items.RemoveAt(index);
                    Display();
                    break;
                }
                else if (listView_order.SelectedItems.Count == 0)
                {
                    label2_delete.ForeColor = Color.Red;
                    label2_delete.Text = "You have not selected an item !";
                    break;
                }
            }
        }

        private void btn_EditCabinet_F2_Click(object sender, EventArgs e)
        {
            edit_Cabinet_flag = true;
            //Only one item can be chosen at a time for edit
            foreach (ListViewItem item in listView_order.Items)
                if (item.Selected)
                {
                    //Find index
                    int indx_cabinet = item.Index;
                    label3_edit.Text = "";

                    //Find cabinet to edit from list of cabinets in display
                    CabinetKit edit_kit = list_of_cabinetkits[indx_cabinet];
                    //Set original number of racks -> Used to know if user adds 
                    //or reduces number of racks
                    Form4.numberOfracks = edit_kit.Nbr_racks;

                    this.Hide();
                    Form3 form3 = new Form3(db, edit_kit, indx_cabinet, edit_Cabinet_flag, list_of_cabinetkits);
                    form3.ShowDialog();
                    break;
                }
                else if (listView_order.SelectedItems.Count == 0)
                {
                    label3_edit.ForeColor = Color.Red;
                    label3_edit.Text = "You have not selected an item !";
                    break;
                }
        }

        private void listView_order_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //Methods
        private void Display()
        {
            if (list_of_cabinetkits.Count == 0)
            {
                label1.Text = "Your shopping cart is empty";
            }
            else
            {
                label1.Text = "You have " + list_of_cabinetkits.Count.ToString() + " item in your cart";
            }
            listView_order.Items.Clear();
            listView_order.BeginUpdate();
            int i = 1;

            string[] arr = new string[3];
            ListViewItem itm;

            //Add first item
            //List<CabinetKit> list_ofcabinet = db.List_of_clients.Find(x => x.Email == client_email);
            foreach (CabinetKit kit in list_of_cabinetkits)
            {
                Decimal totalprice = Convert.ToDecimal(kit.Totalprice);
                arr[0] = kit.Name + " " + i;
                arr[1] = kit.CalculateHeight().ToString() + " x " + kit.ToString();
                arr[2] = Math.Round(totalprice, 2).ToString();
                itm = new ListViewItem(arr);
                listView_order.Items.Add(itm);
                i++;
            }

            listView_order.EndUpdate(); 
        }
    }
}
