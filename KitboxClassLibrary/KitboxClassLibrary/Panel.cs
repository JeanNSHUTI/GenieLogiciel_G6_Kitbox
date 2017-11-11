using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public class Panel : Element
    {
        /*------------------------------------------------------------------------------------------------
         * This class represents a ****
         * 
         * 
         * Last update ******* - ****** by ******
         * -----------------------------------------------------------------------------------------------
         */

        //Constructors
        public Panel(string reference, string code, string dimensions_cm, double height, double depth,
                double width, string color, int quantity_in_stock, int minimum_stock, double price_client,
                int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2)
        {

        }
        //Constructor used for creating an order
        public Panel(string name, string colour, double width = 0, double depth = 0)
        {

        }

    }

    public class PanelLR : Panel
    {
        /*------------------------------------------------------------------------------------------------
         * This class represents a ****
         * 
         * 
         * Last update ******* - ****** by ******
         * -----------------------------------------------------------------------------------------------
         */

        //Constructor
        public PanelLR(string reference, string code, string dimensions_cm, double height, double depth,
                double width, string color, int quantity_in_stock, int minimum_stock, double price_client,
                int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2) : base(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client,
                                                         quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2)
        {
            Name = "Left and Right Panel";
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
        //Constructor used for creating an order
        public PanelLR(string name, string colour, double depth) : base(name, colour, 0, depth)
        {
            Reference = "Panneau GD";
            Name = name;
            Color = colour;
            Depth = depth;
        }

        //methods
        public override string ToString()
        {
            return "Name: " + Name + "   Code: " + Code + "Price: " + Price_client + "Color: " + Color;
        }


    }

    public class PanelTB : Panel
    {
        /*------------------------------------------------------------------------------------------------
         * This class represents a ****
         * 
         * 
         * Last update ******* - ****** by ******
         * -----------------------------------------------------------------------------------------------
         */

        //Constructor
        public PanelTB(string reference, string code, string dimensions_cm, double height, double depth,
                double width, string color, int quantity_in_stock, int minimum_stock, double price_client,
                int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2) : base(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client,
                                                         quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2)
        {
            Name = "Top and Bottom Panel";
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

        public PanelTB(string name, string colour, double width, double depth) : base(name, colour, width, depth)
        {
            Reference = "Panneau HB";
            Name = name;
            Color = colour;
            Width = width;
            Depth = depth;
        }

        //methods
        public override string ToString()
        {
            return "Name: " + Name + "   Code: " + Code + "Price: " + Price_client + "Color: " + Color;
        }


    }

    public class RearPanel : Panel
    {
        /*------------------------------------------------------------------------------------------------
         * This class represents a ****
         * 
         * 
         * Last update ******* - ****** by ******
         * -----------------------------------------------------------------------------------------------
         */

        //Constructor
        public RearPanel(string reference, string code, string dimensions_cm, double height, double depth,
                double width, string color, int quantity_in_stock, int minimum_stock, double price_client,
                int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2) : base(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client,
                                                         quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2)
        {
            Name = "Rear Panel";
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
        //Constructor used for creating an order
        public RearPanel(string name, string colour, double width) : base(name, colour, width, 0)
        {
            Reference = "Panneau Ar";
            Name = name;
            Color = colour;
            Width = width;
        }

        //methods
        public override string ToString()
        {
            return "Name: " + Name + "   Code: " + Code + "Price: " + Price_client + "Color: " + Color;
        }


    }
}
