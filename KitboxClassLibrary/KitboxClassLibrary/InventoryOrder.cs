using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public class InventoryOrder
    {
        //Fields
        private Random randID = new Random();
        private int orderID;
        private Element element_to_order;
        private Supplier supplier;
        DateTime timestamp;
        private bool receivedOrder_flag;
        private int quantity;
        private double price;


        //Constructors
        public InventoryOrder(Element elemnt, Supplier bestsupplier, int qty)
        {
            orderID = randID.Next(1, 1000);
            element_to_order = elemnt;
            supplier = bestsupplier;
            timestamp = DateTime.Now;
            receivedOrder_flag = false;
            quantity = qty;
        }

        //Properties
        public double Price
        {
            get { return price; }
        }
        public int OrderId
        {
            get { return orderID; }
        }
        public string ElementCode
        {
            get { return element_to_order.Code; }
        }
        public string ElementColor
        {
            get { return element_to_order.Color; }
        }
        public string ElementDimensions
        {
            get { return element_to_order.Dimensions_cm; }
        }
        public Element ElementOrdered
        {
            get { return element_to_order; }
        }
        public string SupplierName
        {
            get { return supplier.Supplier_company; }
        }
        public DateTime Date
        {
            get { return timestamp; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public bool OrderReceived
        {
            get { return receivedOrder_flag; }
            set { receivedOrder_flag = value; }
        }



        //Methods
        public void CalculatePrice()
        {
            if(supplier.Name == "Supplier 1")
            {
                price = element_to_order.Price_fournisseur1 * quantity;
            }
            if (supplier.Name == "Supplier 2")
            {
                price = element_to_order.Price_fournisseur2 * quantity;
            }

        }
    }
}
