using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitboxClassLibrary
{
    public class Client
    {
        //Fields
        private string password;
        private string firstname;
        private string lastname;
        private string address;
        private string city;
        private string postal_code;
        private string country;
        private string email;
        private int id;
        private Random randID = new Random();
        private string tel;
        private List<Order> listOrders;

        //Construtors
        public Client(string firstname, string lastname, string password, string email, string address, string city, string postal_code, string telephone, string country)
        {
            Firstname = firstname;
            Lastname = lastname;
            Password = password;
            Email = email;
            Address = address;
            City = city;
            Postalcode = postal_code;
            Tel = telephone;
            Country = country;
            id = randID.Next(5002, 7002); ;
        }
        public Client(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public Client()
        {

        }

        // Properties
        public string Password
        {
            get { return password;}
            set {password = value;}
        }

        public string Firstname
        {
            get {return firstname; }
            set {firstname = value;}
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Email
        {
            get {return email;}
            set {email = value;}
        }

        public int Id
        {
            get {return id;}
            set { id = value;}
        }

        public string Tel
        {
            get {return tel;}
            set {tel = value;}
        }

        public string Postalcode
        {
            get { return postal_code; }
            set { postal_code = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public List<Order> ListOrders
        {
            get {return listOrders;}
            set {listOrders = value;}
        }

        //methods
        public override string ToString()
        {
            return "FirstName: " + Firstname + "   LastName: " + Lastname + "Email: " + Email + "Id: " + Id;
        }
    }
}
