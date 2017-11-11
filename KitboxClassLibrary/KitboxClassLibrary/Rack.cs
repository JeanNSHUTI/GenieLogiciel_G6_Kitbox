using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public class Rack
    {
        /*------------------------------------------------------------------------------------------------
         * This class represents a Kitbox cabinet rack.
         * A cabinet rack contains the list of elements which are needed to construct the 
         * cabinet kit(s) that was or were orderd.
         * Last update 21/03/2017 - started class by Jean-Rene N.
         * -----------------------------------------------------------------------------------------------
         */

        //Fields
        private bool door_addition;
        private bool handle_addition;
        private string name = "Rack";
        private double height;
        private double depth;
        private double width;
        private List<Element> list_of_elements;
        DbManager db = new DbManager();   //For Future use --> integration of Form4.InsertRackElements() as a class method
        private string[] colors;        //table used to display colors of panels selected by Client
        int dim = 5;

        //Constructor
        public Rack()
        {
            list_of_elements = new List<Element>();
            Colors = new string[dim];

        }
        public Rack(double height, double depth, double width)
        {
            Height = height;
            Depth = depth;
            Width = width;
            list_of_elements = new List<Element>();
            Colors = new string[dim];
        }
        public Rack(double depth, double width)
        {
            Depth = depth;
            Width = width;
            list_of_elements = new List<Element>();
            Colors = new string[dim];
        }

        //Properties
        public double Height
        {
            set { height = value; }
            get { return height; }
        }
        public double Depth
        {
            set { depth = value; }
            get { return depth; }
        }
        public double Width
        {
            set { width = value; }
            get { return width; }
        }
        public bool Door_addition
        {
            set { door_addition = value; }
            get { return door_addition; }
        }
        public bool Handle_addition
        {
            set { handle_addition = value; }
            get { return handle_addition; }
        }
        public List<Element> List_of_elements
        {
            get { return list_of_elements; }
            set { list_of_elements = value; }
        }
        public string[] Colors
        {
            get { return colors; }
            set { colors = value; }
        }
        public string Name
        {
            get { return name; }
        }


        //Methods
        public void AddElements(Element element)
        {
            List_of_elements.Add(element);
        }

    }
}
