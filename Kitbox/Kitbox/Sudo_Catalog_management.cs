/*-----------------------------------------------------/
J.Z_Programme 3.0.5
Version du 03/05/2017
/-----------------------------------------------------*/


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KitboxClassLibrary;

namespace Kitbox
{
    public partial class Sudo_Catalog_management : Form
    {
        /*-----------------------------------------------------/
                                Fields
        /-----------------------------------------------------*/
        DbManager db;
        public static Sudo_Catalog_management Current;
        string info = "";
        /*-----------------------------------------------------/
                             Constructor
        /-----------------------------------------------------*/

        public Sudo_Catalog_management()
        {
            Current = this;
            InitializeComponent();
        }

        public Sudo_Catalog_management(DbManager db)
        {
            Current = this;
            this.db = db;
            InitializeComponent();
        }
        public Sudo_Catalog_management(DbManager db, string info)
        {
            Current = this;
            this.db = db;
            this.info = info;
                     
            InitializeComponent();
        }
        /*-----------------------------------------------------/
                                Load
        /-----------------------------------------------------*/

        private void Sudo_Catalog_management_Load(object sender, EventArgs e)
        {
            int i = 0;
            label4.Text = (info);
            // Mise en mode détails
            listView1_Add.View = System.Windows.Forms.View.Details;
                      
            listView1_Add.View = View.Details;
            listView1_Add.FullRowSelect = true;
            listView1_Add.GridLines = true;// Ajout des lignes


            foreach (Element element in db.List_of_stock)
            {
                 AddListView(Convert.ToString(i), element.Code,element.Name, Convert.ToString(element.Dimensions_cm), Convert.ToString(element.Height), Convert.ToString(element.Depth), Convert.ToString(element.Width), element.Color, Convert.ToString(element.Quantity_in_stock), Convert.ToString(element.Minimum_stock_level), Convert.ToString(element.Price_client), Convert.ToString(element.Quantity_per_rack), Convert.ToString(element.Price_fournisseur1), Convert.ToString(element.Delay_fournisseur1), Convert.ToString(element.Price_fournisseur2), Convert.ToString(element.Delay_fournisseur2));
                 i++;

            }
            label3.Text = ("Number of elements\nin the database = \n" + db.List_of_stock.Count);
        }
        private void AddListView(string Number, string Code, string Name, string Dimensions, string Height, string Depth, string Width, string Color, string Instock, string MinStock, string CustomerPrice, string NumberOfPart, string SupplierPrice1, string SupplierTime1, string SupplierPrice2, string SupplierTime2)
        {
            string[] Var = { Number, Code, Name, Dimensions, Height, Depth, Width, Color, Instock, MinStock, CustomerPrice, NumberOfPart, SupplierPrice1, SupplierTime1, SupplierPrice2, SupplierTime2 };
          
            ListViewItem itm = new ListViewItem(Var);
            listView1_Add.Items.Add(itm);
            
        }
        /*-----------------------------------------------------/
                             Event Handlers
        /-----------------------------------------------------*/
        private void button4_Click(object sender, EventArgs e)
        {
            //Il faut fermer dans ce cas car 
            this.Hide();
            SudoForm1.Current.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in listView1_Add.Items)
                if (item.Selected) // on sélectionne la ligne qui nous concerne
                {
                    Sudo_Edit_Catalog Edit_Catalog = new Sudo_Edit_Catalog(db, item);
                    Edit_Catalog.ShowDialog();
                    this.Show();

                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sudo_Edit_Catalog Edit_Catalog = new Sudo_Edit_Catalog(db);
            Edit_Catalog.ShowDialog();
            this.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1_Add.Items)
                if (item.Selected) // on sélectionne la ligne qui nous concerne
                {
                    listView1_Add.Items.Remove(item); // on supprime la ligne de l'affichage  
                    label1.Text = ("Remove " + item.Text);// affiche la ligne supprimer


                    db.List_of_stock.RemoveAt(Convert.ToInt32(item.Text));// on supprime la ligne la dataBase 
                     
                    this.Hide();// actualise la page 
                    Sudo_Catalog_management Catalog_management = new Sudo_Catalog_management(db, "Successful deletion");
                    Catalog_management.ShowDialog();
                }

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        { int i = 0;
            textBox1.Text.Equals("");
            foreach (Element element in db.List_of_stock)
            {
                if (textBox1.Text.Equals(element.Code))
                {
                        label1.Text=("number = "+i);
                        break;
                }
                else 
                {
                    label1.Text = ("!!! not found !!!");
                }
                
                i++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
