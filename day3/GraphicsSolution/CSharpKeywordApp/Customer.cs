using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public partial class Customer
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public Customer() { }
        public Customer(string Name, string Age, String ContactNumber, String Email, String Location)
        {
            this.Name = Name;
            this.Age = Age;
            this.ContactNumber = ContactNumber;
            this.Email = Email;
            this.Location = Location;


        }
        public override string ToString()
        {
            return "name is: " + this.Name + "age: " + this.Age + " Contactno: " + this.ContactNumber + "  Email: " +this.Email+"Location: "+this.Location;

        }
    }
}
