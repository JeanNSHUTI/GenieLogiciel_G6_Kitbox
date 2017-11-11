using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public class Handle : Element
    {

        //Constructors;
        public Handle()
        {
            Reference = "Coupelles";
            Name = "Door Handle";
        }
        //Constructor used to build list_of_stock in DbManager
        public Handle(string reference, string code, string dimensions_cm, double height, double depth,
                double width, string color, int quantity_in_stock, int minimum_stock, double price_client,
                int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2) : base(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client,
                                                         quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2)
        {
            Name = "Door Handle";
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
