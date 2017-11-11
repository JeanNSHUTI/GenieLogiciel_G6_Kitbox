using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public class CabinetKit 
    {
        /*------------------------------------------------------------------------------------------------
         * This class represents a Kitbox cabinet kit.
         * A cabinet kit contains a list of racks which directly contains the full list of elements
         * needed to construct the cabinet kit(s) that was or were orderd.
         * Last update 15/03/2017 - Added comments by Jean-Rene N.
         * -----------------------------------------------------------------------------------------------
         */

        //Fields
        private string name = "Cabinet Kit";
        private int indexID = -1;   //Used to identify which cabinet has been selected in form2 
        double totalprice;
        private int nbr_racks;
        private double width;
        private double depth;
        private double identical_rack_heights;
        bool identical_rack_height;
        private List<Rack> list_of_racks;
        private List<Steel_CornerBar> steel_corner_bars;

        //Constructors
        public CabinetKit() 
        {
            indexID++;
            list_of_racks = new List<Rack>();
            steel_corner_bars = new List<Steel_CornerBar>();


        }
        public CabinetKit(int nbr_racks, double width, double depth, bool identical_rack_height)
        {
            indexID++;
            Nbr_racks = nbr_racks;
            Width = width;
            Depth = depth;
            Identical_rack_height = identical_rack_height;
            list_of_racks = new List<Rack>();
            steel_corner_bars = new List<Steel_CornerBar>();
        }
        public CabinetKit(List<Rack> list_of_racks, List<Steel_CornerBar> steel_corner_bars)
        {
            indexID++;
            list_of_racks = new List<Rack>();
            steel_corner_bars = new List<Steel_CornerBar>();
            List_of_racks = list_of_racks;
            Steel_corner_bars = steel_corner_bars;
        }

        //Properties/Accessors
        public List<Rack> List_of_racks
        {
            get { return list_of_racks; }
            set { list_of_racks = value; }
        }
        public List<Steel_CornerBar> Steel_corner_bars
        {
            get { return steel_corner_bars; }
            set { steel_corner_bars = value; }
        }
        public int Nbr_racks
        {
            get { return nbr_racks; }
            set { nbr_racks = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Totalprice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }
        public double Depth
        {
            get { return depth; }
            set { depth = value; }
        }
        public bool Identical_rack_height
        {
            get { return identical_rack_height; }
            set { identical_rack_height = value; }
        }
        public double Identical_rack_heights
        {
            get { return identical_rack_heights; }
            set { identical_rack_heights = value; }
        }
        public string Name
        {
            get { return name; }
        }
        public int IndexID
        {
            get { return indexID; }
        }

        //Methods

        //Add rack to list of racks
        public void AddRack(Rack rack)
        {
            List_of_racks.Add(rack);
        }

        //Calculate height of Cabinet kit and steel corner bars
        public double CalculateHeight()
        {
            double totalheight = 0;
            foreach(Rack rack in List_of_racks)
            {
                totalheight = totalheight + rack.Height;
            }
            return totalheight;
        }

        //Calculate total price for cabinet kit
        public void CalculatePrice()
        {
            double totalprice = 0;
            foreach (Rack rack in List_of_racks)
            {
                foreach(Element element in rack.List_of_elements)
                {
                    totalprice = totalprice + element.Price_client;
                }               
            }
            Totalprice = totalprice;
        }

        //Display of Cabinet dimensions
        public override string ToString()
        {
            return Width + " x " + Depth;
        }

        //Future --> integration of Form4.AddSteelCornerbars() as a class method
    }
}
