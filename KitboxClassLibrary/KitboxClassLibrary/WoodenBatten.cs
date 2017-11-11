using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public class WoodenBatten : Element
    {
        /*------------------------------------------------------------------------------------------------
         * This class represents a ****
         * 
         * 
         * Last update ******* - ****** by ******
         * -----------------------------------------------------------------------------------------------
         */

        //Constructors
        public WoodenBatten(double height)
        {
            Name = "WoodenBatten";
            Height = height;//+ 2 * height_traverse;
            Reference = "Tasseau";
            Width = 0;
            Depth = 0;

        }

        //Constructor used to build list_of_stock in DbManager
        public WoodenBatten(string reference, string code, string dimensions_cm, double height, double depth,
                        double width, string color, int quantity_in_stock, int minimum_stock, double price_client,
                        int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2)
        {
            Name = "WoodenBatten";
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
}
