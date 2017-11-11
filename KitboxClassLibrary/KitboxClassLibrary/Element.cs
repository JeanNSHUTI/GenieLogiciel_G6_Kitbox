using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public abstract class Element
    {
        /*------------------------------------------------------------------------------------------------
         * This class represents a ****
         * 
         * 
         * Last update ******* - ****** by ******
         * -----------------------------------------------------------------------------------------------
         */

        //Fields
        protected bool needs_tobe_orderd;
        protected string name;
        protected string reference;
        protected string code;
        protected string dimensions_cm;
        protected double height;
        protected double depth;
        protected double width;
        protected string color;
        protected int quantity_in_stock;
        protected int minimum_stock_level;
        protected double price_client;
        protected int quantity_per_rack;
        protected double price_fournisseur1;
        protected double price_fournisseur2;
        protected int delay_fournisseur1;
        protected int delay_fournisseur2;
        protected bool available = false;

        //Constructors  
        public Element()
        {

        }
        public Element(double width, string name)
        {

        }
        public Element(string reference, string code, string dimensions_cm, double height, double depth,
                        double width, string color, int quantity_in_stock, int minimum_stock, double price_client, 
                        int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2)
        {

        }

        //Properties
        public double Price_client
        {
            set { price_client = value; }
            get { return price_client; }
        }
        public double Price_fournisseur1
        {
            set { price_fournisseur1 = value; }
            get { return price_fournisseur1; }
        }
        public double Price_fournisseur2
        {
            set { price_fournisseur2 = value; }
            get { return price_fournisseur2; }
        }
        public int Delay_fournisseur1
        {
            set { delay_fournisseur1 = value; }
            get { return delay_fournisseur1; }
        }
        public int Delay_fournisseur2
        {
            set { delay_fournisseur2 = value; }
            get { return delay_fournisseur2; }
        }
        public int Minimum_stock_level
        {
            set { minimum_stock_level = value; }
            get { return minimum_stock_level; }
        }

        public int Quantity_in_stock
        {
            get { return quantity_in_stock; }
            set { quantity_in_stock = value; }
        }
        public double Height
        {
            set { this.height = value; }
            get { return this.height; }
        }
        public double Depth
        {
            set { this.depth = value; }
            get { return this.depth; }
        }
        public double Width
        {
            set { this.width = value; }
            get { return this.width; }
        }
        public string Color
        {
            set { this.color = value; }
            get { return this.color; }
        }
        public string Dimensions_cm
        {
            set { dimensions_cm = value; }
            get { return dimensions_cm; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Reference
        {
            set { reference = value; }
            get { return reference; }
        }
        public string Code
        {
            set { code = value; }
            get { return code; }
        }
        public bool Available
        {
            get { return available; }
        }
        public int Quantity_per_rack
        {
            get { return quantity_per_rack; }
            set { quantity_per_rack = value; }
        }
        public bool Needs_tobe_orderd
        {
            get { return needs_tobe_orderd; }
            set { needs_tobe_orderd = value; }
        }

        //Methods
        public void  CheckifAvailable()
        {
            if (Quantity_in_stock > 0)
            {
                available = true;
            }
            else
            {
                available = false;
            }
        }

        public void SetValues(string code, double price, string dimensions, int quantity_per_rack, bool available, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2)
        {
            Code = code;
            Price_client = price;
            Dimensions_cm = dimensions;
            Quantity_per_rack = quantity_per_rack;
            this.available = available;
            Price_fournisseur1 = price_fournisseur1;
            Delay_fournisseur1 = delay_fournisseur1;
            Price_fournisseur2 = price_fournisseur2;
            Delay_fournisseur2 = delay_fournisseur2;
        }

        public void UpdateStockQty(int qty)
        {
            Quantity_in_stock = Quantity_in_stock + qty;
        }

        public void CheckNeedforOrder()
        {
            if(Quantity_in_stock <= Minimum_stock_level)
            {
                needs_tobe_orderd = true;
            }
            else
            {
                needs_tobe_orderd = false;
            }
        }

        //Choose best supplier of element in question
        public string ChooseBestSupplier()
        {
            string result;
            string fournissseur1 = "Supplier 1";
            string fournissseur2 = "Supplier 2";
            if (Price_fournisseur1 == Price_fournisseur2)
            {
                if(Delay_fournisseur1 <= Delay_fournisseur2)
                {
                    result = fournissseur1;
                }
                else
                {
                    result = fournissseur2;
                }
            }
            else
            {
                if(Price_fournisseur1 < Price_fournisseur2)
                {
                    result = fournissseur1;
                }
                else
                {
                    result = fournissseur2;
                }
            }

            return result;
        }

        public int Bestdelay()
        {
            int result;

            if (Delay_fournisseur1 <= Delay_fournisseur2)
            {
                result = Delay_fournisseur1;
            }
            else
            {
                result = Delay_fournisseur2;
            }

            return result;
        }
    }

}
