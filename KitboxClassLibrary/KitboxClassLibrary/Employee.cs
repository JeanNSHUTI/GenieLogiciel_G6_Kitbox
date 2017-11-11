using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public class Employee: Client
    {
        //Fields
        private bool editorder_flag;

        //Constructors
        public Employee(string email, string password, string lastname, string firstname)
        {
            Lastname = lastname;
            Firstname = firstname;
            Password = password;
            Email = email;
            editorder_flag = false;
        }
        public Employee(string email, string password)
        {
            Password = password;
            Email = email;
            editorder_flag = false;
        }
        public Employee()
        {
            editorder_flag = false;
        }

        // Properties
        public bool Editorder_flag
        {
            get { return editorder_flag; }
            set { editorder_flag = value; }
        }

        //Methods
        public override string ToString()
        {
            return "FirstName: " + Firstname + "   LastName: " + Lastname + "Email: " + Email;
        }
    }
}
