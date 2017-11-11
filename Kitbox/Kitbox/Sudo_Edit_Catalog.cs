/*-----------------------------------------------------/
J.Z_Programme 3.0.5
Version du 03/05/2017
/-----------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Windows.Forms;
using KitboxClassLibrary;

namespace Kitbox
{
    public partial class Sudo_Edit_Catalog : Form
    {
        /*-----------------------------------------------------/
                               Fields
       /-----------------------------------------------------*/
        DbManager db;
        ListViewItem ID;
        string Infos = "";
        private List<Element> list_of_stock_bis;
        string mode = "";


        /*-----------------------------------------------------/
                             Constructor
        /-----------------------------------------------------*/

        public Sudo_Edit_Catalog()
        {
            InitializeComponent();
        }

        public Sudo_Edit_Catalog(DbManager db)
        {
            this.db = db;
            mode = "Add";
            list_of_stock_bis = new List<Element>();
            InitializeComponent();
        }
        public Sudo_Edit_Catalog(DbManager db, ListViewItem ID)
        {
            this.db = db;
            this.ID = ID;
            mode = "Edit";
            list_of_stock_bis = new List<Element>();
            InitializeComponent();

        }

        /*-----------------------------------------------------/
                              Load
        /-----------------------------------------------------*/

        private void Sudo_Edit_Catalog_Load(object sender, EventArgs e)
        {
            if( mode == "Edit")
            {
                try
                {
                    Element element = db.List_of_stock[Convert.ToInt32(ID.Text)];// élément sélectionné
                    txtBx_Code.Text = element.Code; //reconstruire les objets 
                    txtBx_Width.Text = element.Width.ToString();//reconstruire les objets 
                    txtBx_Depth.Text = element.Depth.ToString();//reconstruire les objets 
                    txtBx_Height.Text = element.Height.ToString();//reconstruire les objets 
                    Colors.Text = element.Color;//reconstruire les objets 
                    textBox1_CustomerPrice.Text = element.Price_client.ToString();//reconstruire les objets 
                    txtBx_Type.Text = element.Reference;//reconstruire les objets 

                    textBox1_InStock.Text = element.Quantity_in_stock.ToString();//reconstruire les objets 
                    textBox1MinStock.Text = element.Minimum_stock_level.ToString();//reconstruire les objets 
                    textBox1_NumberOfPart.Text = element.Quantity_per_rack.ToString(); //reconstruire les objets 
                    textBox1_SupplierPrice1.Text = element.Price_fournisseur1.ToString();//reconstruire les objets 
                    textBox1_SupplierPrice2.Text = element.Price_fournisseur2.ToString();//reconstruire les objets 
                    textBox1_SupplierTime1.Text = element.Delay_fournisseur1.ToString();//reconstruire les objets 
                    textBox1_SupplierTime2.Text = element.Delay_fournisseur2.ToString();//reconstruire les objets 
                }
                catch (System.IO.IOException i)

                    {
                         // On ajoute une icône : celle d'une erreur ...
                        MessageBox.Show("!!! Error reading from {0} !!!! " + i.Message,
                        "Titre",
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error);

                    }



            }

        }
        /*-----------------------------------------------------/
                               Event Handlers
        /-----------------------------------------------------*/

        private void txtBx_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Colors_TextChanged(object sender, EventArgs e)
        {

        }

        private void Width_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Client_signup_Click(object sender, EventArgs e)
        {
     
            if (txtBx_Code.Text.Equals("") || txtBx_Type.Text.Equals("") || txtBx_Width.Text.Equals("") || txtBx_Depth.Equals("") || txtBx_Height.Equals("") || Colors.Equals("") || textBox1_CustomerPrice.Equals("") || textBox1_InStock.Equals("") || textBox1MinStock.Equals("") || textBox1_NumberOfPart.Equals("") || textBox1_SupplierPrice1.Equals("") || textBox1_SupplierPrice2.Equals("") || textBox1_SupplierTime1.Equals("") || textBox1_SupplierTime2.Equals("")) 
            {

                // On ajoute une icône : celle d'une erreur ...
                    MessageBox.Show("!!! Veuillez indiquer tous les champs !!!! ",
                    "Titre",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);

            }
            else
            {
                //Fields
                try
                {
                    
                    
                    Convert.ToDouble(txtBx_Height.Text);
                    Convert.ToDouble(txtBx_Depth.Text);
                    Convert.ToDouble(txtBx_Width.Text);
                    Convert.ToDouble(textBox1_CustomerPrice.Text);
                    Convert.ToInt32(textBox1_InStock.Text);
                    Convert.ToInt32(textBox1MinStock.Text);
                    Convert.ToInt32(textBox1_NumberOfPart.Text);
                    Convert.ToDouble(textBox1_SupplierPrice1.Text);
                    Convert.ToDouble(textBox1_SupplierPrice2.Text);
                    Convert.ToInt32(textBox1_SupplierTime1.Text);
                    Convert.ToInt32(textBox1_SupplierTime2.Text);
                
                    string name = txtBx_Type.Text;
                    string reference = txtBx_Type.Text;
                    string code = txtBx_Code.Text;
                    double height = Convert.ToDouble(txtBx_Height.Text); 
                    double depth = Convert.ToDouble(txtBx_Depth.Text);
                    double width= Convert.ToDouble(txtBx_Width.Text);
                    string color = Colors.Text;
                    double price_client= Convert.ToDouble(textBox1_CustomerPrice.Text);
                    string dimensions_cm = "";
                    int quantity_in_stock = Convert.ToInt32(textBox1_InStock.Text);
                    //bool available = true;
                    int minimum_stock = Convert.ToInt32(textBox1MinStock.Text);
                    int quantity_per_rack = Convert.ToInt32(textBox1_NumberOfPart.Text);
                    double price_fournisseur1 = Convert.ToDouble(textBox1_SupplierPrice1.Text);
                    double price_fournisseur2 = Convert.ToDouble(textBox1_SupplierPrice2.Text); 
                    int delay_fournisseur1 = Convert.ToInt32(textBox1_SupplierTime1.Text);
                    int delay_fournisseur2 = Convert.ToInt32(textBox1_SupplierTime2.Text); 

                if (reference == "Cornieres")
                {
                    Steel_CornerBar steel_Corner_Bars = new Steel_CornerBar(reference, code,dimensions_cm,height,depth,width, color,quantity_in_stock, minimum_stock,price_client,quantity_per_rack, price_fournisseur1,delay_fournisseur1,price_fournisseur2,delay_fournisseur2);
                    db.List_of_stock.Add(steel_Corner_Bars);
                        Infos = "Successful update";

                    }
               else if (reference == "Coupelles")
                {
                    Handle Handles = new Handle(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client, quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2);
                    db.List_of_stock.Add(Handles);
                    Infos = "Successful update";
                }
                else if (reference == "Panneau Ar")
                {
                    RearPanel rear_panels = new RearPanel(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client, quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2);
                    db.List_of_stock.Add(rear_panels);
                    Infos = "Successful update";
                }
                else if (reference == "Panneau GD")
                {
                    PanelLR left_right_panels = new PanelLR(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client, quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2);
                    db.List_of_stock.Add(left_right_panels);
                    Infos = "Successful update";
                }
                else if (reference == "Panneau HB")
                {
                    PanelTB top_bottom_panels = new PanelTB(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client, quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2);
                    db.List_of_stock.Add(top_bottom_panels);
                    Infos = "Successful update";
                }
                else if (reference == "Porte")
                {
                    Door doors = new Door(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client, quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2);
                    db.List_of_stock.Add(doors);
                    Infos = "Successful update";
                }
                else if (reference == "Tasseau")
                {
                    WoodenBatten wooden_battens = new WoodenBatten(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client, quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2);
                    db.List_of_stock.Add(wooden_battens);
                    Infos = "Successful update";
                }

                else if (reference == "Traverse Ar")
                {
                    Rear_crossbeam rear_crossbeams = new Rear_crossbeam(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client, quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2);
                    db.List_of_stock.Add(rear_crossbeams);
                    Infos = "Successful update";
                }
                else if (reference == "Traverse Av")
                {
                    Frontal_crossbeam frontal_crossbeams = new Frontal_crossbeam(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client, quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2);
                    db.List_of_stock.Add(frontal_crossbeams);
                    Infos = "Successful update";
                }
                else if (reference == "Traverse GD")
                {
                    Left_Right_crossbeam left_right_crossbeams = new Left_Right_crossbeam(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client, quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2);
                    db.List_of_stock.Add(left_right_crossbeams);
                    Infos = "Successful update";
                }
                else
                {
                    // On ajoute une icône : celle d'une erreur ...
                    MessageBox.Show("!!! Error 103 aucun type ne correspond !!!! ",
                    "Titre",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);

                }
            }
                catch (Exception ex)
            {
                MessageBox.Show("!!! Oups :( !!!! "+ex,
              "Titre",
              MessageBoxButtons.RetryCancel,
              MessageBoxIcon.Error);
                    Infos = "!!! ERROR !!!";


            }


            if (mode == "Add")
                {
                    db.List_of_stock = db.List_of_stock;
                    this.Hide(); // retourne à la page précédente
                Sudo_Catalog_management Catalog_management = new Sudo_Catalog_management(db, Infos);
                Catalog_management.ShowDialog();
                }
                 if(mode == "Edit")
                {
                    db.List_of_stock.RemoveAt(Convert.ToInt32(ID.Text));// on supprime la ligne la dataBase 
                    db.List_of_stock = db.List_of_stock;
                    this.Hide(); // retourne à la page précédente
                    Sudo_Catalog_management Catalog_management = new Sudo_Catalog_management(db, Infos);
                    Catalog_management.ShowDialog();

                }
            }
            }

        private void txtBx_Code_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBx_Type_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBx_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBx_Height_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_Available_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBx_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Colors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_Available_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_InStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_CustomerPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1MinStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_NumberOfPart_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_SupplierPrice1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_SupplierTime1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
