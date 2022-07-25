using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        DBConnection db = new DBConnection();
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime DateofJoining { get; set; }
        public string Address { get; set; }
        public bool isActive { get; set; }
        public string Password { get; set; }
        public Customer(string name, string contact, DateTime birthdate, string address, string pass)
        {
            this.CustomerID = db.GetMaxCustomerId() + 1;
            this.Name = name;
            this.Contact = contact;
            this.Birthdate = birthdate;
            this.DateofJoining = DateTime.Now;
            this.Address = address;
            this.isActive = true;
            this.Password = pass;
        }
    }
}
