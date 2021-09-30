using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    class UC4_Addressbook
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Email { get; set; }

        public static List<UC4_Addressbook> ContactDetail = new List<UC4_Addressbook>();
        public static void AddBook2()
        {

            UC4_Addressbook person = new UC4_Addressbook();
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
            Console.Write("Enter Number AddressBook Id to be Created: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {

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
            ////To Delete The Entry
            Console.WriteLine("Are you sure you want to Delete Address Book Entry? (Y/N)");
            string choice = Convert.ToString(Console.ReadLine());
            switch (choice)
            {
                case "Y":
                    var Edit1 = Console.ReadLine();
                    var editobj1 = ContactDetail.Find(x => x.FirstName == Edit1);
                    ContactDetail.Remove(person);
                    Console.WriteLine("First Name: " + person.FirstName);
                    Console.WriteLine("Last Name: " + person.LastName);
                    Console.WriteLine("Mobile Number: " + person.MobileNumber);
                    Console.WriteLine("Address : " + person.Address);
                    Console.WriteLine("State : " + person.State);
                    Console.WriteLine("ZipCode : " + person.Zipcode);
                    Console.WriteLine("Email : " + person.Email);
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Entry Deleted");
                    break;
                default:
                    Console.WriteLine("No Entry to Delete");
                    break;
            }
            Console.ReadKey();
        }
    }
}

