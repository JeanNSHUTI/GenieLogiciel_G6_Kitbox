using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
   public class Cross_beam : Element
    {
        /*------------------------------------------------------------------------------------------------
         * This class represents a Cross beam
         * 
         * 
         * Last update ******* - ****** by ******
         * -----------------------------------------------------------------------------------------------
         */

        //Fields


        //Constructors
        public Cross_beam(float length, int number)
        {
            /*this.lengh = lengh;
            this.number = number;*/
        }
        public Cross_beam(double width, string name)
        {

        }
        public Cross_beam(string reference, string code, string dimensions_cm, double height, double depth,
                double width, string color, int quantity_in_stock, int minimum_stock, double price_client,
                int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2)
        {

        }


        //Methods

    }
    /*-----------------------------------------------------------------
    class Frontal_crossbeam - daughter
    -----------------------------------------------------------------*/
    public class Frontal_crossbeam : Cross_beam
    {
        //Constructor
        public Frontal_crossbeam(string reference, string code, string dimensions_cm, double height, double depth,
                double width, string color, int quantity_in_stock, int minimum_stock, double price_client,
                int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2) : base(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client,
                                                         quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2)
        {
            Name = "Frontal Crossbeam";
            Reference = reference;
            Code = code;
            Dimensions_cm = dimensions_cm;
            Height = height;
            Depth = depth;
            Width = width;
            Color = color;
            Quantity_in_stock = quantity_in_stock;
            Minimum_stock_level = minimum_stock;
            Price_client = price_client;
            Quantity_per_rack = quantity_per_rack;
            Price_fournisseur1 = price_fournisseur1;
            Delay_fournisseur1 = delay_fournisseur1;
            Price_fournisseur2 = price_fournisseur2;
            Delay_fournisseur2 = delay_fournisseur2;
            CheckNeedforOrder();
            CheckifAvailable();
        }
        public Frontal_crossbeam(double width, string name) : base(width, name)
        {
            Reference = "Traverse Av";
            Name = name;
            Depth = 0;
            Height = 0;
            Width = width;
        }
    }
    /*-----------------------------------------------------------------
    class Rear_crossbeam - daughter
    -----------------------------------------------------------------*/
    public class Rear_crossbeam : Cross_beam
    {
        //Constructors
        public Rear_crossbeam(string reference, string code, string dimensions_cm, double height, double depth,
                double width, string color, int quantity_in_stock, int minimum_stock, double price_client,
                int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2) : base(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client,
                                                         quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2)
        {
            Name = "Rear Crossbeam";
            Reference = reference;
            Code = code;
            Dimensions_cm = dimensions_cm;
            Height = height;
            Depth = depth;
            Width = width;
            Color = color;
            Quantity_in_stock = quantity_in_stock;
            Minimum_stock_level = minimum_stock;
            Price_client = price_client;
            Quantity_per_rack = quantity_per_rack;
            Price_fournisseur1 = price_fournisseur1;
            Delay_fournisseur1 = delay_fournisseur1;
            Price_fournisseur2 = price_fournisseur2;
            Delay_fournisseur2 = delay_fournisseur2;
            CheckNeedforOrder();
            CheckifAvailable();
        }
        public Rear_crossbeam(double n_width, string name) : base(n_width, name)
        {
            Reference = "Traverse Ar";
            Name = name;
            Width = n_width;
            Height = 0;
            Depth = 0;
        }
    }
    /*-----------------------------------------------------------------
    class Left_Right_crossbeam - daughter
    -----------------------------------------------------------------*/
    public class Left_Right_crossbeam : Cross_beam
    {
        //Constructor
        public Left_Right_crossbeam(string reference, string code, string dimensions_cm, double height, double depth,
                double width, string color, int quantity_in_stock, int minimum_stock, double price_client,
                int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2) : base(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client,
                                                         quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2)
        {
            Name = "Left and Right Crossbeam";
            Reference = reference;
            Code = code;
            Dimensions_cm = dimensions_cm;
            Height = height;
            Depth = depth;
            Width = width;
            Color = color;
            Quantity_in_stock = quantity_in_stock;
            Minimum_stock_level = minimum_stock;
            Price_client = price_client;
            Quantity_per_rack = quantity_per_rack;
            Price_fournisseur1 = price_fournisseur1;
            Delay_fournisseur1 = delay_fournisseur1;
            Price_fournisseur2 = price_fournisseur2;
            Delay_fournisseur2 = delay_fournisseur2;
            CheckNeedforOrder();
            CheckifAvailable();
        }
        public Left_Right_crossbeam(double n_depth, string name) : base(n_depth, name)
        {
            Reference = "Traverse GD";
            Name = name;
            Depth = n_depth;
            Height = 0;
            Width = 0;
        }
    }
}


