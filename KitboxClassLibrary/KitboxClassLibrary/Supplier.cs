using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public class Supplier
    {
        //Fields
        private string name;
        private string supplier_company;
        private string supplier_function;
        private string address_line1;
        private string address_line2;

        //Constructors
        public Supplier(string name, string supplier_company, string supplier_function, string address_line1, string address_line2)
        {
            this.name = name;
            this.supplier_company = supplier_company;
            this.supplier_function = supplier_function;
            this.address_line1 = address_line1;
            this.address_line2 = address_line2;
        }

        //Properties
        public string Name
        {
            get { return name; }
        }

        public string Supplier_company
        {
            get { return supplier_company; }
        }
        public string Supplier_function
        {
            get { return supplier_function; }
        }
        public string Address_line1
        {
            get { return address_line1; }
        }
        public string Address_line2
        {
            get { return address_line2; }
        }

        //Methods
        public override string ToString()
        {
            return Name + "\n------------------\n\n" + Supplier_company + "\n" + Supplier_function + "\n" + Address_line1 + "\n" + Address_line2;
        }
    }
}
