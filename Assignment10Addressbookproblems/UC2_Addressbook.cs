using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    class UC2_Addressbook
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City  { get; set; }
        public string Zipcode { get; set; }
        public string Email { get; set; }

        public static List<UC2_Addressbook> ContactDetail = new List<UC2_Addressbook>();
        public static void AddPerson()
        {
            UC2_Addressbook person = new UC2_Addressbook();
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

            Console.Write("Enter City: ");
            person.City = Console.ReadLine();


            Console.Write("Enter ZipCode : ");
            person.Zipcode = Console.ReadLine();

            Console.Write("Enter Email : ");
            person.Email = Console.ReadLine();

            ContactDetail.Add(person);
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Mobile Number: " + person.MobileNumber);
            Console.WriteLine("Address : " + person.Address);
            Console.WriteLine("State : " + person.State);
            Console.WriteLine("ZipCode : " + person.Zipcode);
            Console.WriteLine("Email : " + person.Email);
            Console.WriteLine("-------------------------------------------");
            ////edit 1 or more Entries
            Console.Write("Enter Number AddressBook Id to be Created: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("AddressBook ID=" + (100 + i));

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

                ContactDetail.Add(person);
                Console.WriteLine("First Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("Mobile Number: " + person.MobileNumber);
                Console.WriteLine("Address : " + person.Address);
                Console.WriteLine("State : " + person.State);
                Console.WriteLine("ZipCode : " + person.Zipcode);
                Console.WriteLine("Email : " + person.Email);
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
