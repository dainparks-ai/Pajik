using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Barangay { get; set; }
        public string ContactNumber { get; set; }

        public User(string username, string password, string firstName,
                    string lastName, string address, string city,
                    string barangay, string contactNumber)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            Barangay = barangay;
            ContactNumber = contactNumber;
        }
    }
}
