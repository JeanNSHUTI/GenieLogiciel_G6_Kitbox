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
    public partial class Sudo_OrderElement : Form
    {

        //Fields
        public static Sudo_OrderElement Current;
        DbManager db;
        Element element;
        Supplier supplier;

        public Sudo_OrderElement(DbManager db, Element element, Supplier supplier)
        {
            Current = this;
            this.db = db;
            this.element = element;
            this.supplier = supplier;
            InitializeComponent();
        }

        private void Sudo_OrderElement_Load(object sender, EventArgs e)
        {
            ActiveControl = txtBx_qty;
            buttonOrder.Enabled = false;
            rtb_Supplier.Text = supplier.ToString();
            rtb_element.MouseClick += rtb_element_MouseClick;
            txtBx_qty.KeyPress += TxtBx_qty_KeyPress;
        }

        private void TxtBx_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Order Id has to be a whole number";
                e.Handled = true;
            }
            else
            {
                label3.Text = "";
            }
        }

        private void txtBx_qty_TextChanged(object sender, EventArgs e)
        {
            int result;
            label3.Text = "";
            if (Int32.TryParse(txtBx_qty.Text, out result))
            {
                label3.Text = "";
                label2.Text = "";
                rtb_element.Text = "Name:   " + element.Name + "\n------------------\n" + "\nCode:  " + element.Code + "\nColor:   " + element.Color + "\nQty:    " + txtBx_qty.Text + "\nDimensions(cm):    " + element.Dimensions_cm;
                buttonOrder.Enabled = true;
            }
            else if (txtBx_qty.Text != "")
            {
                label3.ForeColor = Color.Red;
                label3.Text = "This field has to be a whole number";
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            element.Needs_tobe_orderd = false;
            InventoryOrder newOrder = new InventoryOrder(element, supplier, Int32.Parse(txtBx_qty.Text));
            db.StockOrders.Add(newOrder);
            this.Dispose();
            this.Close();
            MessageBox.Show("Your order has been sent correctly", "Titre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Sudo_InventoryOrders.Current.Show();
        }

        private void rtb_Supplier_TextChanged(object sender, EventArgs e)
        {
            rtb_Supplier.MouseClick += rtb_Supplier_MouseClick;
        }

        private void rtb_element_TextChanged(object sender, EventArgs e)
        {
        }

        private void rtb_Supplier_MouseClick(object sender, EventArgs e)
        {
            ActiveControl = txtBx_qty;
        }
        private void rtb_element_MouseClick(object sender, EventArgs e)
        {
            ActiveControl = txtBx_qty;
        }
    }
}
