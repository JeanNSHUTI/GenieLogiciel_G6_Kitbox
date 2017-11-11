using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public class Steel_CornerBar : Element
    {
        /*------------------------------------------------------------------------------------------------
         * This class represents a steel corner bar used to create a cabinet.
         * A cabinet kit contains a four steel corner bars for construction.
         * A steel corner bar is an element.
         * Last update 15/03/2017 - Added comments by Jean-Rene N.
         * -----------------------------------------------------------------------------------------------
         */

        //Fields
        private bool not_standard;  //Flag that indicates if the steel corner bar is of standard size

        //Constructors
        public Steel_CornerBar(string color, double height)
        {
            Name = "Steel corner bar";
            Reference = "Cornieres";
            Color = color;
            Height = height;
        }
        public Steel_CornerBar(string color)
        {
            Name = "Steel corner bar";
            Reference = "Cornieres";
            Color = color;
        }
        public Steel_CornerBar(string reference, string code, string dimensions_cm, double height, double depth,
                double width, string color, int quantity_in_stock, int minimum_stock, double price_client,
                int quantity_per_rack, double price_fournisseur1, int delay_fournisseur1, double price_fournisseur2, int delay_fournisseur2) : base(reference, code, dimensions_cm, height, depth, width, color, quantity_in_stock, minimum_stock, price_client,
                                                         quantity_per_rack, price_fournisseur1, delay_fournisseur1, price_fournisseur2, delay_fournisseur2)
        {
            Name = "Steel corner bar";
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

        //Properties
        public bool Not_standard
        {
            get { return this.not_standard; }
        }

        //Methods
        public void SetHeight(double height)
        {
            Height = height;
        }
        public void Cut()
        {
            not_standard = true;
            Name = "Steel corner bar (Cut)";
            //Methode pour calculer par combien il faut couper les cornieres 
            //faut envoyer la difference a enlever en parametre
        }

    }
}
