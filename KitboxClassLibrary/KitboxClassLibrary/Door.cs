using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public class Door:Element
    {
        /*------------------------------------------------------------------------------------------------
         * This class represents a cabinet door.
         * 
         * 
         * Last update ******* - ****** by ******
         * -----------------------------------------------------------------------------------------------
         */

        //Fields

        //Constructors
        public Door(double height, double width, string color) // The material glass is considerd to be a color
        {

        }
        //Constructor used to build list_of_stock in DbManager
        public Door(string reference, string code, string dimensions_cm, double height, double depth,
                double width, string color, int quantity_in_stock, int minimum_stock, double price_client,
                int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2) : base(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client,
                                                         quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2)
        {
            Name = "Door";
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

       
    }

    /*-----------------------------------------------------------------
        class Left_Door -Girl
     ------------------------------------------------------------------*/
    public class Left_Door : Door
    {
        //Constructor
        public Left_Door(double height, double width, string color) : base(height, width, color)
        {
            Reference = "Porte";
            Name = "Left Door";
            Height = height;
            Width = width;
            Color = color;
        }
    }
    /*-----------------------------------------------------------------
    class Right_Door -Girl
     ------------------------------------------------------------------*/
    public class Right_Door : Door
    {
        //Constructor
        public Right_Door(double height, double width, string color) : base(height, width, color)
        {
            Reference = "Porte";
            Name = "Right Door";
            Height = height;
            Width = width;
            Color = color;
        }
    }
}