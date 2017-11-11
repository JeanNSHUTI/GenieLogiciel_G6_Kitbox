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
    public partial class ConfirmOrder : Form
    {
        //Fields

        //Constructors
        public ConfirmOrder()
        {
            InitializeComponent();
        }


        //Event handlers
        private async void ConfirmOrder_Load(object sender, EventArgs e)
        {
            //After 6 minutes, go back homeif OK not pressed.
            await Task.Delay(3000);
            label1_Printing.Text = "";
            label1.Text = "Finished ! Please proceed to checkout/cashier";
            await Task.Delay(3000);
            this.Close();
            Home.Current.Show();

        }

    }
}
