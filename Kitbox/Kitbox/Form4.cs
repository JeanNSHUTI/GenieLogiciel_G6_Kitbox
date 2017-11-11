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
using System.Configuration;
using System.Data.SqlClient;


namespace Kitbox
{
    public partial class Form4 : System.Windows.Forms.Form
    {
        //Fields
        public static Form4 Current;
        DbManager db;
        CabinetKit cabinetkit;
        Rack rack;
        List<CabinetKit> list_of_cabinetkits;
        int rackcounter;
        string name;
        double totalheight;
        bool updateMode_flag;
        int cabinet_index;
        int indx;
        public static int numberOfracks;


        //Constructor
        public Form4()
        {
            Current = this;
            InitializeComponent();
        }
        public Form4(DbManager db, CabinetKit cabinetkit1, List<CabinetKit> list_of_cabinetkits)
        {
            Current = this;
            this.db = db;
            cabinetkit = cabinetkit1;
            this.list_of_cabinetkits = list_of_cabinetkits;
            InitializeComponent();
        }
        public Form4(DbManager db, CabinetKit cabinetkit1, int rackcounter, List<CabinetKit> list_of_cabinetkits)
        {
            Current = this;
            this.db = db;
            cabinetkit = cabinetkit1;
            this.rackcounter = rackcounter;
            this.list_of_cabinetkits = list_of_cabinetkits;
            indx = rackcounter;
            InitializeComponent();
        }
        public Form4(DbManager db, CabinetKit cabinetkit1, int rackcounter, List<CabinetKit> list_of_cabinetkits, bool updateMode_flag, int cabinet_index)
        {
            Current = this;
            this.db = db;
            cabinetkit = cabinetkit1;
            this.rackcounter = rackcounter;
            this.list_of_cabinetkits = list_of_cabinetkits;
            this.updateMode_flag = updateMode_flag;
            indx = rackcounter;
            this.cabinet_index = cabinet_index;
            InitializeComponent();
        }

        //Event handlers
        private void Form4_Load(object sender, EventArgs e)
        {
            rackcounter++;
            rack = new Rack(cabinetkit.Depth, cabinetkit.Width);
            label1_form4.Text = "Rack " + rackcounter.ToString() + " details";
            if (cabinetkit.Identical_rack_height == true)
            {
                label4_form4.Enabled = false;
                comboBx_rackheight4.Enabled = false;
            }
            else
            {
                label4_form4.Enabled = true;
                comboBx_rackheight4.Enabled = true;
            }
            //Set rack height accordingly
            if (cabinetkit.Identical_rack_height == true)
            {
                rack.Height = cabinetkit.Identical_rack_heights;
            }
            if (updateMode_flag == true && (numberOfracks <= cabinetkit.Nbr_racks))
            {
                try
                {
                    //Prefill
                    if (cabinetkit.Identical_rack_height == false)
                    {
                        comboBx_rackheight4.Text = cabinetkit.List_of_racks[indx].Height.ToString();
                    }
                    Element element = cabinetkit.List_of_racks[indx].List_of_elements.Find(x => x.Name == "Right Panel");
                    comboBx_Rpanel4.Text = element.Color;
                    element = cabinetkit.List_of_racks[indx].List_of_elements.Find(x => x.Name == "Left Panel");
                    comboBx_LPanel4.Text = element.Color;
                    element = cabinetkit.List_of_racks[indx].List_of_elements.Find(x => x.Name == "Rear Panel");
                    comboBx_RearPanel4.Text = element.Color;
                    element = cabinetkit.List_of_racks[indx].List_of_elements.Find(x => x.Name == "Top Panel");
                    comboBx_topPanel.Text = element.Color;
                    element = cabinetkit.List_of_racks[indx].List_of_elements.Find(x => x.Name == "Bottom Panel");
                    comboBx_BottmPanel.Text = element.Color;
                    element = cabinetkit.Steel_corner_bars.Find(a => a.Name == "Steel corner Bar" || a.Name == "Steel corner bar (Cut)");
                    comboBx_SteelCornerBr.Text = element.Color;

                    if (cabinetkit.List_of_racks[indx].List_of_elements.Exists(a => a.Name == "Left Door" || a.Name == "Handle"))
                    {
                        checkBx_rackdoors4.Checked = cabinetkit.List_of_racks[indx].Door_addition;
                        element = cabinetkit.List_of_racks[indx].List_of_elements.Find(x => x.Name == "Left Door");
                        comboBx_doorcolor4.Text = element.Color;
                        element = cabinetkit.List_of_racks[indx].List_of_elements.Find(x => x.Name == "Right Door");
                        comboBx_rightdoor.Text = element.Color;
                        checkBx_rackhandles4.Checked = cabinetkit.List_of_racks[indx].Handle_addition;
                    }
                }
                catch(ArgumentOutOfRangeException)
                {
                    comboBx_Rpanel4.Text = "";
                    comboBx_LPanel4.Text = "";
                    comboBx_RearPanel4.Text = "";
                    comboBx_topPanel.Text = "";
                    comboBx_BottmPanel.Text = "";
                    comboBx_SteelCornerBr.Text = "";
                    comboBx_doorcolor4.Text = "";
                    comboBx_rightdoor.Text = "";
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            rack.Handle_addition = checkBx_rackhandles4.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Il faut tester si c'est possible d'ajouter des portes par rapport a la largeur choisit !!
            //--> 2 portes/casier --> largeur_casier/2, glisseurs!!
            if (checkBx_rackdoors4.Checked == true)
            {
                List<Element> doors = db.List_of_stock.FindAll(x => x.Reference == "Porte");
                if(doors.Exists(x => x.Width == rack.Width/2 + 1 || x.Width == rack.Width/2 + 2))
                {
                    rack.Door_addition = checkBx_rackdoors4.Checked;
                    label10_form4.Enabled = true;
                    comboBx_doorcolor4.Enabled = true;
                    label5_form4.Enabled = true;
                    checkBx_rackhandles4.Enabled = true;
                    label1_rightdoor.Enabled = true;
                    comboBx_rightdoor.Enabled = true;
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Insufficiant width ! There are no doors that fit your cabinet.";
                }
            }
            else
            {
                label3.Text = "";
                label10_form4.Enabled = false;
                comboBx_doorcolor4.Enabled = false;
                label5_form4.Enabled = false;
                checkBx_rackhandles4.Enabled = false;
                label1_rightdoor.Enabled = false;
                comboBx_rightdoor.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_form4_Click(object sender, EventArgs e)
        {
            if(updateMode_flag == true)
            {
                this.Close();
                Form3.Current.Show();
            }
            else
            {
                //if User clicks back, dispose of all current racks and elements 
                //created --> User needs to restart from From3
                rack.List_of_elements.RemoveAll(x => x.Reference == "Coupelles" || x.Reference == "Traverse Av" || x.Reference == "Traverse Ar" || x.Reference == "Traverse GD" || x.Reference == "Tasseau" || x.Reference == "Porte" || x.Reference == "Panneau HB" || x.Reference == "Panneau GD" || x.Reference == "Panneau Ar");
                cabinetkit.List_of_racks.RemoveAll(x => x.Width == cabinetkit.Width);
                this.Close();
                Form3.Current.Show();
            }
        }

        private void btn_next__form4_Click(object sender, EventArgs e)
        {
            //User is obliged to fill in all fields
            if (comboBx_BottmPanel.Text.Equals("") || comboBx_LPanel4.Text.Equals("") || comboBx_RearPanel4.Text.Equals("") || comboBx_Rpanel4.Text.Equals("") || comboBx_topPanel.Text.Equals("")
                || (comboBx_SteelCornerBr.Text.Equals("") && comboBx_SteelCornerBr.Enabled == true) || (comboBx_rackheight4.Text.Equals("") && comboBx_rackheight4.Enabled == true)
                || (comboBx_doorcolor4.Text.Equals("") && comboBx_doorcolor4.Enabled == true) || (comboBx_rightdoor.Text.Equals("") && comboBx_rightdoor.Enabled == true))
            {
                // On ajoute une icône : celle d'une erreur. On change aussi les boutons...
                MessageBox.Show("Please define all fields !",
                    "Titre",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                //Create Elements for Rack
                InsertRackElements();
                //test to see if not in update mode
                if (updateMode_flag == false)
                {
                    cabinetkit.List_of_racks.Add(rack);
                }
                else
                {                   
                    try
                    {
                        int indx = rackcounter;
                        cabinetkit.List_of_racks[indx - 1] = rack;

                        //Client has decided to reduce number of racks in edit mode
                        if (numberOfracks > cabinetkit.Nbr_racks)
                        {
                            int indx_racks_delete = indx;
                            int nbr_racks_delete = numberOfracks - cabinetkit.Nbr_racks;
                            //Remove/delete old racks
                            cabinetkit.List_of_racks.RemoveRange(indx_racks_delete, nbr_racks_delete);
                        }
                    }

                    //Client has decided to add racks in edit mode
                    catch (ArgumentOutOfRangeException)
                    {
                        cabinetkit.List_of_racks.Add(rack);
                    }
                }

                //Test to see if all racks have been created
                if (rackcounter + 1 <= cabinetkit.Nbr_racks)
                {
                    this.Dispose();
                    this.Close();
                    //this.Hide();
                    if(updateMode_flag == true)
                    {
                        Form4 update_rack = new Form4(db, cabinetkit, rackcounter, list_of_cabinetkits, updateMode_flag, cabinet_index);
                        update_rack.ShowDialog();
                    }
                    else
                    {
                        Form4 new_rack = new Form4(db, cabinetkit, rackcounter, list_of_cabinetkits);
                        new_rack.ShowDialog();
                    }
                }
                else
                {
                    //Try to find Steel corner bars that match current cabinet conditions
                    AddSteelCornerbars();
                    //Set price
                    cabinetkit.CalculatePrice();
                    if(updateMode_flag == false)
                    {
                        //Add cabinetkit
                        list_of_cabinetkits.Add(cabinetkit);
                    }
                    else
                    {
                        //Replace cabinet
                        list_of_cabinetkits[cabinet_index] = cabinetkit;
                    }
                    this.Dispose();
                    this.Close();
                    Form3.Current.Dispose();
                    Form3.Current.Close();
                    Form2 form2 = new Form2(db, list_of_cabinetkits);
                    form2.ShowDialog();
                }
            }
        }

        private void comboBx_LPanel4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBx_Rpanel4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBx_topPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBx_BottmPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBx_RearPanel4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show color option for Steel corner bars only once on the last time form 4 is called
            if (rackcounter == cabinetkit.Nbr_racks)
            {
                comboBx_SteelCornerBr.Enabled = true;
                label2.Enabled = true;
            }
        }

        private void comboBx_rackheight4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cabinetkit.Identical_rack_height != true)
            {
                rack.Height = double.Parse(comboBx_rackheight4.SelectedItem.ToString());
            }
        }

        private void comboBx_SteelCornerBr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void comboBx_doorcolor4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doorcolor = comboBx_doorcolor4.SelectedItem.ToString();
            if (checkBx_rackdoors4.Checked == true)
            {
                if (doorcolor == "Verre")
                {
                    label5_form4.Enabled = false;
                    checkBx_rackhandles4.Enabled = false;
                    label3.ForeColor = Color.Red;
                    label3.Text = "Glass doors do not come with handles.";
                    await Task.Delay(1500);
                    label3.Text = "";
                }
                else
                {
                    label5_form4.Enabled = true;
                    checkBx_rackhandles4.Enabled = true;
                }
            }
            else
            {

            }
        }

        private async void comboBx_rightdoor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doorcolor = comboBx_doorcolor4.SelectedItem.ToString();
            if (checkBx_rackdoors4.Checked == true)
            {
                if (doorcolor == "Verre")
                {
                    label5_form4.Enabled = false;
                    checkBx_rackhandles4.Enabled = false;
                    label3.ForeColor = Color.Red;
                    label3.Text = "Glass doors do not come with handles.";
                    await Task.Delay(1500);
                    label3.Text = "";
                }
                else
                {
                    label5_form4.Enabled = true;
                    checkBx_rackhandles4.Enabled = true;
                }
            }
            else
            {

            }
        }

        private void AddSteelCornerbars()
        {
            //Try to find Steel corner bars that match current cabinet conditions
            try
            {
                //We only need to create corner bars once AND only on the last rack (form4) called.
                //= > this function needs to be added to Cabinetkit class in future!!! 
                //Calculate height
                totalheight = cabinetkit.CalculateHeight();

                //Add Steel corner bars
                //Try to take the closest height (<= 2*2) possible to avoid cutting large pieces.
                //Add margin of 11 for extreme case => 7 * 52cm(max rack height) = 364cm for corniere, 
                //closest and longest corniere in Catalog is at 375cm
                Element corner_bar = db.List_of_stock.Find(x => (x.Color == comboBx_SteelCornerBr.Text) && ((x.Height >= totalheight) && (x.Height <= totalheight + 4 || x.Height <= totalheight + 11)) && (x.Reference == "Cornieres"));
                corner_bar.CheckifAvailable();          //nullReferenceRisk
                if (corner_bar.Available == true)
                {
                    //Create Steel Corner bars
                    Steel_CornerBar steel_corner_bar = new Steel_CornerBar(comboBx_SteelCornerBr.Text, totalheight);
                    if (corner_bar.Height > totalheight)
                    {
                        steel_corner_bar.Cut();
                    }
                    steel_corner_bar.SetValues(corner_bar.Code, corner_bar.Price_client, corner_bar.Dimensions_cm, corner_bar.Quantity_per_rack,
                                     corner_bar.Available, corner_bar.Price_fournisseur1, corner_bar.Delay_fournisseur1,
                                     corner_bar.Price_fournisseur2, corner_bar.Delay_fournisseur2);
                    for (int counter = 1; counter <= corner_bar.Quantity_per_rack; counter++)
                    {
                        int index = counter;
                        index--;
                        if (updateMode_flag == false)
                        {
                            //Add these elements to list contained in rack
                            cabinetkit.Steel_corner_bars.Add(steel_corner_bar);
                        }
                        else
                        {
                            cabinetkit.Steel_corner_bars[index] = steel_corner_bar;
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There are no Steelcorner bars that match your Cabinet !", "Titre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InsertRackElements()
        {
            //Create Elements for Order   = > this function needs to be added to Rack class in future!!!          
            foreach (Element element in db.List_of_stock)
            {
                //Identify Handle Element
                if (element.Reference == "Coupelles")
                {
                    //Set flag appropriately depending on inventory 
                    element.CheckifAvailable();
                    if (checkBx_rackhandles4.Checked == true)
                    {
                        //Create and add handles
                        Handle handle = new Handle();
                        int rackindex = rackcounter;
                        rackindex--;
                        handle.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                        for (int counter = 1; counter <= element.Quantity_per_rack; counter++)
                        {
                            rack.AddElements(handle);
                        }
                    }
                }
                if (element.Reference == "Traverse Av")
                {
                    if (element.Width == rack.Width)
                    {
                        element.CheckifAvailable();
                        //Create Crossbeam
                        Frontal_crossbeam frontal_crossbeam = new Frontal_crossbeam(rack.Width, "Frontal Crossbeam");
                        //Set Price and dimensions from stock table
                        frontal_crossbeam.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                        for (int counter = 1; counter <= element.Quantity_per_rack; counter++)
                        {
                            rack.AddElements(frontal_crossbeam);
                        }
                    }
                }
                if (element.Reference == "Traverse Ar")
                {
                    if (element.Width == rack.Width)
                    {
                        element.CheckifAvailable();
                        //Create Crossbeams
                        Rear_crossbeam rear_crossbeam = new Rear_crossbeam(rack.Width, "Rear Crossbeam");
                        rear_crossbeam.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                        for (int counter = 1; counter <= element.Quantity_per_rack; counter++)
                        {
                            rack.AddElements(rear_crossbeam);
                        }
                    }
                }
                if (element.Reference == "Traverse GD")
                {
                    if (element.Depth == rack.Depth)
                    {
                        element.CheckifAvailable();
                        //Create Crossbeams
                        Left_Right_crossbeam left_right_crossbeam1 = new Left_Right_crossbeam(rack.Depth, "Left Crossbeam");
                        left_right_crossbeam1.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                        for (int counter = 1; counter <= element.Quantity_per_rack - 2; counter++)
                        {
                            rack.AddElements(left_right_crossbeam1);
                        }
                        Left_Right_crossbeam left_right_crossbeam2 = new Left_Right_crossbeam(rack.Depth, "Right Crossbeam");
                        left_right_crossbeam2.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                        for (int counter = 1; counter <= element.Quantity_per_rack - 2; counter++)
                        {
                            rack.AddElements(left_right_crossbeam2);
                        }
                    }
                }
                if (element.Reference == "Tasseau")
                {
                    if (element.Height == rack.Height)
                    {
                        element.CheckifAvailable();
                        //Create WoodenBattens
                        WoodenBatten woodenBatten = new WoodenBatten(rack.Height);
                        woodenBatten.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                        for (int counter = 1; counter <= element.Quantity_per_rack; counter++)
                        {
                            //Add these elements to list contained in rack
                            rack.AddElements(woodenBatten);
                        }
                    }
                }
                if (element.Reference == "Porte")
                {
                    //1 ou 2 cm maximum de marge pour la largeur
                    if (((element.Width == rack.Width / 2 + 1) || (element.Width == rack.Width / 2 + 2)) && (element.Height == rack.Height) && (element.Color == comboBx_doorcolor4.Text))
                    {
                        element.CheckifAvailable();
                        //Doors
                        if (checkBx_rackdoors4.Checked == true)
                        {
                            //Create and add doors
                            Left_Door leftdoor = new Left_Door(rack.Height, rack.Width, comboBx_doorcolor4.Text);
                            Right_Door rightdoor = new Right_Door(rack.Height, rack.Width, comboBx_rightdoor.Text);
                            leftdoor.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                            rightdoor.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                            rack.AddElements(leftdoor);
                            rack.AddElements(rightdoor);
                        }
                    }
                }
                if (element.Reference == "Panneau HB")
                {
                    if ((element.Depth == rack.Depth) && (element.Width == rack.Width) && (element.Color == comboBx_topPanel.Text))
                    {
                        element.CheckifAvailable();
                        //Create Panels
                        name = "Top Panel";
                        PanelTB toppanel = new PanelTB(name, comboBx_topPanel.Text, cabinetkit.Width, cabinetkit.Depth); //Premier panneauHB
                        toppanel.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                        //Add these elements to list contained in rack
                        rack.AddElements(toppanel);
                        rack.Colors[1] = comboBx_topPanel.Text;
                    }
                }
                if (element.Reference == "Panneau HB")
                {
                    if ((element.Depth == rack.Depth) && (element.Width == rack.Width) && (element.Color == comboBx_BottmPanel.Text))
                    {
                        element.CheckifAvailable();
                        name = "Bottom Panel";
                        PanelTB bottompanel = new PanelTB(name, comboBx_BottmPanel.Text, cabinetkit.Width, cabinetkit.Depth); //Deuxieme panneauHB
                        bottompanel.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                        //Add these elements to list contained in rack
                        rack.AddElements(bottompanel);
                        rack.Colors[2] = comboBx_BottmPanel.Text;
                    }
                }
                if (element.Reference == "Panneau GD")
                {
                    if ((element.Depth == rack.Depth) && (element.Height == rack.Height) && (element.Color == comboBx_LPanel4.Text))
                    {
                        element.CheckifAvailable();
                        //Create Panels
                        name = "Left Panel";
                        PanelLR leftpanel = new PanelLR(name, comboBx_LPanel4.Text, cabinetkit.Depth);  //Premier panneauGD
                        leftpanel.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                        //Add these elements to list contained in rack
                        rack.AddElements(leftpanel);
                        rack.Colors[3] = comboBx_LPanel4.Text;
                    }
                }
                if (element.Reference == "Panneau GD")
                {
                    if ((element.Depth == rack.Depth) && (element.Height == rack.Height) && (element.Color == comboBx_Rpanel4.Text))
                    {
                        element.CheckifAvailable();
                        name = "Right Panel";
                        PanelLR rightpanel = new PanelLR(name, comboBx_Rpanel4.Text, cabinetkit.Depth);  //Deuxieme panneauGD
                        rightpanel.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                        //Add these elements to list contained in rack
                        rack.AddElements(rightpanel);
                        rack.Colors[4] = comboBx_Rpanel4.Text;
                    }
                }
                if (element.Reference == "Panneau Ar")
                {
                    if ((element.Width == rack.Width) && (element.Height == rack.Height) && (element.Color == comboBx_RearPanel4.Text))
                    {
                        element.CheckifAvailable();
                        name = "Rear Panel";
                        RearPanel rearpanel = new RearPanel(name, comboBx_RearPanel4.Text, cabinetkit.Width);  //1 Panneau Arriere
                        rearpanel.SetValues(element.Code, element.Price_client, element.Dimensions_cm, element.Quantity_per_rack,
                                         element.Available, element.Price_fournisseur1, element.Delay_fournisseur1,
                                         element.Price_fournisseur2, element.Delay_fournisseur2);
                        rack.AddElements(rearpanel);
                        rack.Colors[0] = comboBx_RearPanel4.Text;
                    }
                }
            }
        }
    }
}
