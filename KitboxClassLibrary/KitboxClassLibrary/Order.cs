using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public class Order
    {
        /*------------------------------------------------------------------------------------------------
         * This class represents an order created by a Kitbox client.
         * An order contains a list of cabinet kits which eventually contains the full list of elements
         * needed to construct the cabinet kit.
         * Last update 15/03/2017 - Added comments by Jean-Rene N.
         * -----------------------------------------------------------------------------------------------
         */

        //Fields
        private string firstname;
        private string lastname;
        private double totalprice;
        private Random randID = new Random();
        private int orderID;
        private string client_email;                      //Foreign key that links Client to his orders
        private string state;                            //Order can be Active (unpaid + not deliverd) or Passive (paid + delivered) 
        private List<CabinetKit> list_of_cabinetkits = new List<CabinetKit>();
        private DateTime date;
        private bool paid_flag;                         //When these two flags are true; state --> passive!
        private bool delivered_flag;

        //Constructors
        public Order()
        {
            orderID = randID.Next(1001, 5001);
            state = "Active";
            date = DateTime.Now;   //Timestamp
            Delivered_flag = false;
            Paid_flag = false;
        }

        //Properties/Accessors
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        
        public List<CabinetKit> List_of_cabinetkits
        {
            get { return list_of_cabinetkits; }
            set { list_of_cabinetkits = value; }
        }
        public double Totalprice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }
        public bool Paid_flag
        {
            get { return paid_flag; }
            set { paid_flag = value; }
        }
        public bool Delivered_flag
        {
            get { return delivered_flag; }
            set { delivered_flag = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Client_email
        {
            get { return client_email; }
            set { client_email = value; }
        }
        public int OrderID
        {
            get { return orderID; }
        }
        public DateTime Date
        {
            get { return date; }
        }

        //Methods

        //Calculate total price of all kits in order
        public void CalculatePrice()
        {
            double price = 0;
            foreach(CabinetKit kit in List_of_cabinetkits)
            {
                price = price + kit.Totalprice;
            }
            Totalprice = price;
        }

        //Create Pdf with full list of elements 


    }
}
