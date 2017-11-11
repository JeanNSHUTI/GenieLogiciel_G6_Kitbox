using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.VisualBasic.FileIO;

namespace KitboxClassLibrary
{
    public class DbManager
    {
        //Fields
        private List<Client> list_of_clients;
        private List<Employee> list_of_employees;
        private List<Element> list_of_stock;
        private List<Order> list_of_orders;
        private List<Supplier> list_of_suppliers;
        private List<InventoryOrder> stockOrders;
        private DataTable catalog;
        public string test;
        int accept_entry;

        //Constructor
        public DbManager()
        {
            List_of_clients = new List<Client>();
            List_of_employees = new List<Employee>();
            List_of_stock = new List<Element>();
            List_of_orders = new List<Order>();
            List_of_suppliers = new List<Supplier>();
            stockOrders = new List<InventoryOrder>();
            Catalog = new DataTable();

        }

        //Properties
        public List<Client> List_of_clients
        {
            set { list_of_clients = value; }
            get { return list_of_clients; }
        }
        public List<Employee> List_of_employees
        {
            set { list_of_employees = value; }
            get { return list_of_employees; }
        }
        public List<Element> List_of_stock
        {
            set { list_of_stock = value; }
            get { return list_of_stock; }
        }
        public List<Order> List_of_orders
        {
            set { list_of_orders = value; }
            get { return list_of_orders; }
        }
        public List<Supplier> List_of_suppliers
        {
            set { list_of_suppliers = value; }
            get { return list_of_suppliers; }
        }
        public List<InventoryOrder> StockOrders
        {
            set { stockOrders = value; }
            get { return stockOrders; }
        }
        public DataTable Catalog
        {
            set { catalog = value; }
            get { return catalog; }
        }

        //Methods
        //Add clients to Clients table
        public void AddClient(Client newclient)
        {
            List_of_clients.Add(newclient);
        }
        //Add orders to Orders table
        public void AddOrder(Order newOrder)
        {
            List_of_orders.Add(newOrder);
        }

        //Creation of Clients table
        public void AddClients()
        {
            Client client1 = new Client("John", "Travolta", "50jjkk", "16186@ecam.be", "21 Rue de Mons", "Turnhout", "1477", "0487222333", "Belgium");
            Client client2 = new Client("Kenneth", "Kane", "United", "jean.rene.nshuti@gmail.com", "21 Rue de mode", "Brussels", "1477", "048722113", "Belgium");
            Client client3 = new Client("Timmers", "Travolta", "Arsenal", "nshuti.jeanrene@outlook.com", "21 Rue de pont", "Turnhout", "1477", "0487777333", "Belgium");
            Client client4 = new Client("prenomClint", "nomClinet", "", "root", "21 Rue de pont", "Turnhout", "1477", "0487777333", "Belgium");
            List_of_clients.Add(client1);
            List_of_clients.Add(client2);
            List_of_clients.Add(client3);
            List_of_clients.Add(client4);
        }

        //Creation of Suppliers table
        public void AddSuppliers()
        {
            Supplier supp1 = new Supplier("Supplier 1", "TRABELBO SA", "Les Artisans du Bois", "Parc industriel 9", "6124 MARBEHAN");
            Supplier supp2 = new Supplier("Supplier 2", "TraitBois SPRL", "Ebénistes réunis", "Chemin des 2 Maisons, 140", "5150 : Floriffoux");
            List_of_suppliers.Add(supp1);
            List_of_suppliers.Add(supp2);
        }

        //Creation of employees table
        public void AddEmployees()
        {
            Employee employee1 = new Employee("isaac@kitbox.be", "djoko5", "Djoko", "Isaac" );
            Employee employee2 = new Employee("zschau@kitbox.be", "zschau4", "Djoko", "Johann");
            Employee employee3 = new Employee("catry@kitbox.be", "catry3", "Catry", "Emmanuel");
            Employee employee4 = new Employee("garo@kitbox.be", "garo2", "Garofalo", "Steven");
            Employee employee5 = new Employee("nshuti@kitbox.be", "nshuti1", "Nshuti", "Jean-Rene");
            Employee employee6 = new Employee("root", "", "nom", "prenom");
            List_of_employees.Add(employee1);
            List_of_employees.Add(employee2);
            List_of_employees.Add(employee3);
            List_of_employees.Add(employee4);
            List_of_employees.Add(employee5);
            List_of_employees.Add(employee6);
        }

        //Creation of Stock table
        public void SetDataTableFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();

            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { ";" });
                    csvReader.HasFieldsEnclosedInQuotes = false;
                    string[] colFields = csvReader.ReadFields();

                    foreach (string column in colFields)
                    {
                        DataColumn datacolumn = new DataColumn(column);
                        datacolumn.AllowDBNull = true;
                        csvData.Columns.Add(datacolumn);
                    }

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(string.Format("Failed to find/read kitbox.csv file:", ex.Message));
            }

            Catalog = csvData;
            //Populate list_of_stock from datatable
        }
        
        //Populate list_of_stock from datatable
        public void PopulateStockList()
        {
            //Populate list_of_stock from datatable
            foreach (DataRow row in Catalog.Rows)
            {
                string reference;
                reference = row["Ref"].ToString();
                if (reference == "Cornieres")
                {
                    Steel_CornerBar steel_Corner_Bars = new Steel_CornerBar(row["Ref"].ToString(), row["Code"].ToString(),
                                                                            row["Dimensions(cm)"].ToString(), double.Parse(row["hauteur"].ToString()),
                                                                            double.Parse(row["profondeur"].ToString()), double.Parse(row["largeur"].ToString()),
                                                                            row["couleur"].ToString(), int.Parse(row["Enstock"].ToString()), int.Parse(row["Stock minimum"].ToString()),
                                                                            double.Parse(row["Prix-Client"].ToString()), int.Parse(row["Nb-Pieces/casier"].ToString()), double.Parse(row["Prix-Fourn 1"].ToString()), int.Parse(row["Delai-Fourn 1"].ToString()),
                                                                            double.Parse(row["Prix-Fourn2"].ToString()), int.Parse(row["Delai-Fourn2"].ToString()));
                    List_of_stock.Add(steel_Corner_Bars);
                }
                if (reference == "Coupelles")
                {
                    Handle Handles = new Handle(row["Ref"].ToString(), row["Code"].ToString(),
                                                                            row["Dimensions(cm)"].ToString(), double.Parse(row["hauteur"].ToString()),
                                                                            double.Parse(row["profondeur"].ToString()), double.Parse(row["largeur"].ToString()),
                                                                            row["couleur"].ToString(), int.Parse(row["Enstock"].ToString()), int.Parse(row["Stock minimum"].ToString()),
                                                                            double.Parse(row["Prix-Client"].ToString()), int.Parse(row["Nb-Pieces/casier"].ToString()), double.Parse(row["Prix-Fourn 1"].ToString()), int.Parse(row["Delai-Fourn 1"].ToString()),
                                                                            double.Parse(row["Prix-Fourn2"].ToString()), int.Parse(row["Delai-Fourn2"].ToString()));
                    List_of_stock.Add(Handles);
                }
                if (reference == "Panneau Ar")
                {
                    RearPanel rear_panels = new RearPanel(row["Ref"].ToString(), row["Code"].ToString(),
                                                                            row["Dimensions(cm)"].ToString(), double.Parse(row["hauteur"].ToString()),
                                                                            double.Parse(row["profondeur"].ToString()), double.Parse(row["largeur"].ToString()),
                                                                            row["couleur"].ToString(), int.Parse(row["Enstock"].ToString()), int.Parse(row["Stock minimum"].ToString()),
                                                                            double.Parse(row["Prix-Client"].ToString()), int.Parse(row["Nb-Pieces/casier"].ToString()), double.Parse(row["Prix-Fourn 1"].ToString()), int.Parse(row["Delai-Fourn 1"].ToString()),
                                                                            double.Parse(row["Prix-Fourn2"].ToString()), int.Parse(row["Delai-Fourn2"].ToString()));
                    List_of_stock.Add(rear_panels);
                }
                if (reference == "Panneau GD")
                {
                    PanelLR left_right_panels = new PanelLR(row["Ref"].ToString(), row["Code"].ToString(),
                                                                            row["Dimensions(cm)"].ToString(), double.Parse(row["hauteur"].ToString()),
                                                                            double.Parse(row["profondeur"].ToString()), double.Parse(row["largeur"].ToString()),
                                                                            row["couleur"].ToString(), int.Parse(row["Enstock"].ToString()), int.Parse(row["Stock minimum"].ToString()),
                                                                            double.Parse(row["Prix-Client"].ToString()), int.Parse(row["Nb-Pieces/casier"].ToString()), double.Parse(row["Prix-Fourn 1"].ToString()), int.Parse(row["Delai-Fourn 1"].ToString()),
                                                                            double.Parse(row["Prix-Fourn2"].ToString()), int.Parse(row["Delai-Fourn2"].ToString()));
                    List_of_stock.Add(left_right_panels);
                }
                if (reference == "Panneau HB")
                {
                    PanelTB top_bottom_panels = new PanelTB(row["Ref"].ToString(), row["Code"].ToString(),
                                                                            row["Dimensions(cm)"].ToString(), double.Parse(row["hauteur"].ToString()),
                                                                            double.Parse(row["profondeur"].ToString()), double.Parse(row["largeur"].ToString()),
                                                                            row["couleur"].ToString(), int.Parse(row["Enstock"].ToString()), int.Parse(row["Stock minimum"].ToString()),
                                                                            double.Parse(row["Prix-Client"].ToString()), int.Parse(row["Nb-Pieces/casier"].ToString()), double.Parse(row["Prix-Fourn 1"].ToString()), int.Parse(row["Delai-Fourn 1"].ToString()),
                                                                            double.Parse(row["Prix-Fourn2"].ToString()), int.Parse(row["Delai-Fourn2"].ToString()));
                    List_of_stock.Add(top_bottom_panels);
                }
                if (reference == "Porte")
                {
                    Door doors = new Door(row["Ref"].ToString(), row["Code"].ToString(),
                                                                            row["Dimensions(cm)"].ToString(), double.Parse(row["hauteur"].ToString()),
                                                                            double.Parse(row["profondeur"].ToString()), double.Parse(row["largeur"].ToString()),
                                                                            row["couleur"].ToString(), int.Parse(row["Enstock"].ToString()), int.Parse(row["Stock minimum"].ToString()),
                                                                            double.Parse(row["Prix-Client"].ToString()), int.Parse(row["Nb-Pieces/casier"].ToString()), double.Parse(row["Prix-Fourn 1"].ToString()), int.Parse(row["Delai-Fourn 1"].ToString()),
                                                                            double.Parse(row["Prix-Fourn2"].ToString()), int.Parse(row["Delai-Fourn2"].ToString()));
                    List_of_stock.Add(doors);
                }
                if (reference == "Tasseau")
                {
                    WoodenBatten wooden_battens = new WoodenBatten(row["Ref"].ToString(), row["Code"].ToString(),
                                                                            row["Dimensions(cm)"].ToString(), double.Parse(row["hauteur"].ToString()),
                                                                            double.Parse(row["profondeur"].ToString()), double.Parse(row["largeur"].ToString()),
                                                                            row["couleur"].ToString(), int.Parse(row["Enstock"].ToString()), int.Parse(row["Stock minimum"].ToString()),
                                                                            double.Parse(row["Prix-Client"].ToString()), int.Parse(row["Nb-Pieces/casier"].ToString()), double.Parse(row["Prix-Fourn 1"].ToString()), int.Parse(row["Delai-Fourn 1"].ToString()),
                                                                            double.Parse(row["Prix-Fourn2"].ToString()), int.Parse(row["Delai-Fourn2"].ToString()));
                    List_of_stock.Add(wooden_battens);
                }
                if (reference == "Traverse Ar")
                {
                    Rear_crossbeam rear_crossbeams = new Rear_crossbeam(row["Ref"].ToString(), row["Code"].ToString(),
                                                                            row["Dimensions(cm)"].ToString(), double.Parse(row["hauteur"].ToString()),
                                                                            double.Parse(row["profondeur"].ToString()), double.Parse(row["largeur"].ToString()),
                                                                            row["couleur"].ToString(), int.Parse(row["Enstock"].ToString()), int.Parse(row["Stock minimum"].ToString()),
                                                                            double.Parse(row["Prix-Client"].ToString()), int.Parse(row["Nb-Pieces/casier"].ToString()), double.Parse(row["Prix-Fourn 1"].ToString()), int.Parse(row["Delai-Fourn 1"].ToString()),
                                                                            double.Parse(row["Prix-Fourn2"].ToString()), int.Parse(row["Delai-Fourn2"].ToString()));
                    List_of_stock.Add(rear_crossbeams);
                }
                if (reference == "Traverse Av")
                {
                    Frontal_crossbeam frontal_crossbeams = new Frontal_crossbeam(row["Ref"].ToString(), row["Code"].ToString(),
                                                                            row["Dimensions(cm)"].ToString(), double.Parse(row["hauteur"].ToString()),
                                                                            double.Parse(row["profondeur"].ToString()), double.Parse(row["largeur"].ToString()),
                                                                            row["couleur"].ToString(), int.Parse(row["Enstock"].ToString()), int.Parse(row["Stock minimum"].ToString()),
                                                                            double.Parse(row["Prix-Client"].ToString()), int.Parse(row["Nb-Pieces/casier"].ToString()), double.Parse(row["Prix-Fourn 1"].ToString()), int.Parse(row["Delai-Fourn 1"].ToString()),
                                                                            double.Parse(row["Prix-Fourn2"].ToString()), int.Parse(row["Delai-Fourn2"].ToString()));
                    List_of_stock.Add(frontal_crossbeams);
                }
                if (reference == "Traverse GD")
                {
                    Left_Right_crossbeam left_right_crossbeams = new Left_Right_crossbeam(row["Ref"].ToString(), row["Code"].ToString(),
                                                                            row["Dimensions(cm)"].ToString(), double.Parse(row["hauteur"].ToString()),
                                                                            double.Parse(row["profondeur"].ToString()), double.Parse(row["largeur"].ToString()),
                                                                            row["couleur"].ToString(), int.Parse(row["Enstock"].ToString()), int.Parse(row["Stock minimum"].ToString()),
                                                                            double.Parse(row["Prix-Client"].ToString()), int.Parse(row["Nb-Pieces/casier"].ToString()), double.Parse(row["Prix-Fourn 1"].ToString()), int.Parse(row["Delai-Fourn 1"].ToString()),
                                                                            double.Parse(row["Prix-Fourn2"].ToString()), int.Parse(row["Delai-Fourn2"].ToString()));
                    List_of_stock.Add(left_right_crossbeams);
                }
            }
        }

        //Authorization for client
        public bool VerifyClient(Client client_login)
        {
            if ((List_of_clients.Exists(x => x.Email == client_login.Email)) && (List_of_clients.Exists(x => x.Password == client_login.Password)))
            {
                accept_entry = 1;
            }
            else
            {
                accept_entry = 0;
            }
            if (accept_entry == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Authorization for employees
        public bool VerifyEmployee(Employee employee_login)
        {
            if (List_of_employees.Exists(x => x.Email == employee_login.Email && x.Password == employee_login.Password))
            {               
                accept_entry = 1;
            }
            else
            {
                accept_entry = 0;
            }
            if (accept_entry == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] DisplayClients()
        {
            string[] clients = new string[500];
            int i = 1;
            clients[0] = "List of Clients\n";

            foreach (Client client in List_of_clients)

            {
                clients[i] = client.ToString()+"\n";
                i++;
            }
            return clients;

        }

        //Update client information in DB
        public void UpdateClient(Client update_client)
        {
            var index = List_of_clients.FindIndex(c => c.Email == update_client.Email);
            List_of_clients[index] = new Client(update_client.Firstname, update_client.Lastname, update_client.Password, update_client.Email, update_client.Address, update_client.City, update_client.Postalcode, update_client.Tel, update_client.Country);
        }

        //Update count of stock when elemets have been orderd from suppliers
        public void UpdateStockCount(Element stockElement)
        {
            var index = List_of_stock.FindIndex(b => b.Code == stockElement.Code);
            List_of_stock[index] = stockElement;
        }

        //Used to keep count of stock after orders become passive
        public void UpdateCount(Element orderElement)
        {
            var index = List_of_stock.FindIndex(b => b.Code == orderElement.Code);
            List_of_stock[index].Quantity_in_stock -= 1;
        }

        //Main method called from Sudo Form 4 to updqte quantity in
        //stock of different elements that have been sold in order
        public void UpdateStock_onOrder(Order order)
        {
            foreach(CabinetKit kit in order.List_of_cabinetkits)
            {
                foreach(Rack rack in kit.List_of_racks)
                {
                    foreach(Element element in rack.List_of_elements)
                    {
                        UpdateCount(element);
                    }
                }
            }
        }

        public void UpdateOrder(Order order, int index)
        {
            //var index = List_of_orders.FindIndex(b => b.OrderID == order.OrderID);
            List_of_orders[index] = order;
        }
    }
}
