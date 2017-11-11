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
    public partial class Form3 : System.Windows.Forms.Form
    {
        //Fields
        public static Form3 Current;
        DbManager db;
        CabinetKit cabinetkit;
        List<CabinetKit> list_of_cabinetkits;
        int rackcounter = 0;
        int cabinet_index;
        bool editMode_flag;
        bool rack_edit_flag = false;

        //Constructor
        public Form3()
        {
            InitializeComponent();
            Current = this;
            label2_form3.Enabled = false;
            comboBx_RackHeight_form3.Enabled = false;
            Current.FormClosing += Current_FormClosing;
        }

        private void Current_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.Equals((sender as Button).Name, @"CloseButton"))
            {
                Current.Dispose();
            }
            else
            {
                Form2.Current.Show();
            }
        }

        public Form3(DbManager db, CabinetKit edit_kit, int index,bool editflag,List<CabinetKit> list_of_cabinetkits)
        {
            InitializeComponent();
            Current = this;
            this.db = db;
            label2_form3.Enabled = false;
            comboBx_RackHeight_form3.Enabled = false;
            cabinetkit = edit_kit;
            cabinet_index = index;
            editMode_flag = editflag;
            this.list_of_cabinetkits = list_of_cabinetkits;
        }
        public Form3(DbManager db, List<CabinetKit> list_of_cabinetkits)
        {
            InitializeComponent();
            Current = this;
            this.db = db;
            label2_form3.Enabled = false;
            comboBx_RackHeight_form3.Enabled = false;
            cabinetkit = new CabinetKit();
            this.list_of_cabinetkits = list_of_cabinetkits;
        }

        //Event handlers
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if(editMode_flag == true)
            {
                //Prefill
                checkBx_idmHeight_form3.Checked = cabinetkit.Identical_rack_height;
                if (checkBx_idmHeight_form3.Checked)
                {
                    comboBx_RackHeight_form3.Text = cabinetkit.Identical_rack_heights.ToString();
                }
                comboBx_NbrRacks_form3.Text = cabinetkit.Nbr_racks.ToString();
                WidthOfCabinet.Text = cabinetkit.Width.ToString();
                DepthOfCabinet.Text = cabinetkit.Depth.ToString();
                rack_edit_flag = true;
            }

        }

        private void btn_next_form3_Click(object sender, EventArgs e)
        {
            if (comboBx_NbrRacks_form3.Text.Equals("")|| DepthOfCabinet.Text.Equals("")|| WidthOfCabinet.Text.Equals("") || (checkBx_idmHeight_form3.Checked == true && comboBx_RackHeight_form3.Text.Equals("")))
            {
                // On ajoute une icône : celle d'une erreur. On change aussi les boutons...
                MessageBox.Show("Please define all fields !",
                    "Titre",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
            }
            else
            {
                if(editMode_flag == true)
                {                    
                    this.Hide();
                    Form4 form4 = new Form4(db, cabinetkit, rackcounter, list_of_cabinetkits, rack_edit_flag, cabinet_index);
                    form4.ShowDialog();
                }
                else
                {
                    this.Hide();
                    Form4 form4 = new Form4(db, cabinetkit, rackcounter, list_of_cabinetkits);
                    form4.ShowDialog();
                }
            }
        }

        private void btn_back_form3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2.Current.Show();
        }

        private void checkBx_idmHeight_form3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBx_idmHeight_form3.Checked == true)
            {
                label2_form3.Enabled = true;
                comboBx_RackHeight_form3.Enabled = true;
                cabinetkit.Identical_rack_height = checkBx_idmHeight_form3.Checked;
            }
            else
            {
                label2_form3.Enabled = false;
                comboBx_RackHeight_form3.Enabled = false;
                cabinetkit.Identical_rack_height = checkBx_idmHeight_form3.Checked;
            }
        }

        private void comboBx_NbrRacks_form3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(editMode_flag == true)
            {
                /*label2.Text = "Unchangeable during edit !";
                label2.ForeColor = Color.Red;*/
            }
            cabinetkit.Nbr_racks = int.Parse(comboBx_NbrRacks_form3.SelectedItem.ToString());
        }

        private void WidthOfCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cabinetkit.Width = double.Parse(WidthOfCabinet.SelectedItem.ToString());
        }

        private void DepthOfCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cabinetkit.Depth = double.Parse(DepthOfCabinet.SelectedItem.ToString());
        }

        private void comboBx_RackHeight_form3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cabinetkit.Identical_rack_heights = double.Parse(comboBx_RackHeight_form3.SelectedItem.ToString());
        }
    }
}
