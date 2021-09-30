using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    class UC1_Addressbook
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Email { get; set; }

        public static List<UC1_Addressbook> ContactDetails = new List<UC1_Addressbook>();
        public static void Contact()
        {
            UC1_Addressbook person = new UC1_Addressbook();

            Console.Write("Enter FirstName: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter LastName: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Mobile Number: ");
            person.MobileNumber = Console.ReadLine();

            Console.Write("Enter Address : ");
            person.Address = Console.ReadLine();

            Console.Write("Enter State : ");
            person.State = Console.ReadLine();

            Console.Write("Enter ZipCode : ");
            person.Zipcode = Console.ReadLine();

            Console.Write("Enter Email : ");
            person.Email = Console.ReadLine();

            ContactDetails.Add(person);

            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Mobile Number: " + person.MobileNumber);
            Console.WriteLine("Address : " + person.Address);
            Console.WriteLine("State : " + person.State);
            Console.WriteLine("ZipCode : " + person.Zipcode);
            Console.WriteLine("Email : " + person.Email);
            Console.ReadKey();
        }
    }
}

   
