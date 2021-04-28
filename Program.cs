using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        //Creating a struct of Person
     /*   struct Person
        {

            public string FirstName;
            public string MiddleName;
            public string LastName;
            public string Street1;
            public string Street2;
            public string City;
            public string State;
            public string Zip;
            public string Phone;
            public string Email;





        } */
        
        // Converting the struct to a class
        class NewPerson
        {

            public string FirstName;
            public string MiddleName;
            public string LastName;
            public string Street1;
            public string Street2;
            public string City;
            public string State;
            public string Zip;
            public string Phone;
            public string Email;





        }

        class person
        {

            private string firstName;
            private string middleName;
            private string lastName;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zip;
            private string phone;
            private string email;

            public string Firstname
            {
                get
                {
                    return firstName;
                }

                set
                {
                    firstName = value;
                }



            }

            public string Middlename
            {
                get
                {
                    return middleName;
                }

                set
                {
                    middleName = value;
                }



            }

            public string Lastname
            {
                get
                {
                    return lastName;
                }

                set
                {
                   lastName = value;
                }



            }



            public string Street1
            {
                get
                {
                    return street1;
                }

                set
                {
                    street1 = value;
                }



            }
            public string Street2
            {
                get
                {
                    return street2;
                }

                set
                {
                    street2 = value;
                }



            }

            public string City
            {
                get
                {
                    return city;
                }

                set
                {
                    city = value;
                }



            }

            public string State
            {
                get
                {
                    return state;
                }

                set
                {
                    state = value;
                }



            }

            public string Zip
            {
                get
                {
                    return zip;
                }

                set
                {
                    zip = value;
                }



            }

            public string Phone
            {
                get
                {
                    return phone;
                }

                set
                {
                    phone = value;
                }



            }

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    email = value;
                }



            }





        }


        static void Main(string[] args)
        {
           // bool blnResult = false;
           // Struct ----------------------------------
          /*  Person temp = new Person();

            Console.Write("\nPlease enter the first name: ");
            temp.FirstName = Console.ReadLine();

            Console.Write("\nPlease enter the middle name: ");
            temp.MiddleName = Console.ReadLine();

            Console.Write("\nPlease enter the last name: ");
            temp.LastName = Console.ReadLine();

            Console.Write("\nPlease enter street 1: ");
            temp.Street1 = Console.ReadLine();

            Console.Write("\nPlease enter street 2: ");
            temp.Street2 = Console.ReadLine();

            Console.Write("\nPlease enter the city: ");
            temp.City = Console.ReadLine();

            Console.Write("\nPlease enter the state: ");
            temp.State = Console.ReadLine();

            Console.Write("\nPlease enter the zip: ");
            temp.Zip = Console.ReadLine();
            
            

            Console.Write("\nPlease enter the phone number: ");
            temp.Phone = Console.ReadLine();

            Console.Write("\nPlease enter the email: ");
            temp.Email = Console.ReadLine();



             Console.WriteLine($"\n First name: {temp.FirstName}");
             Console.WriteLine($"\n Middle name: {temp.MiddleName}");
             Console.WriteLine($"\n Last name: {temp.LastName}");
             Console.WriteLine($"\n Street 1: {temp.Street1}");
             Console.WriteLine($"\n Street 2: {temp.Street2}");
             Console.WriteLine($"\n City: {temp.City}");
             Console.WriteLine($"\n State: {temp.State}");
             Console.WriteLine($"\n Zip: {temp.Zip}");
             Console.WriteLine($"\n Phone: {temp.Phone}");
             Console.WriteLine($"\n Email: {temp.Email}");
             Console.ReadLine(); */

            // Class Section---------------------------------------------------------------------------------------------------------

            NewPerson Temp = new NewPerson();

            Console.Write("\nPlease enter the first name: ");
            Temp.FirstName = Console.ReadLine();
            Temp.FirstName += " Poopy";

            Console.Write("\nPlease enter the middle name: ");
            Temp.MiddleName = Console.ReadLine();

            Console.Write("\nPlease enter the last name: ");
            Temp.LastName = Console.ReadLine();

            Console.Write("\nPlease enter street 1: ");
            Temp.Street1 = Console.ReadLine();

            Console.Write("\nPlease enter street 2: ");
            Temp.Street2 = Console.ReadLine();

            Console.Write("\nPlease enter the city: ");
            Temp.City = Console.ReadLine();

            Console.Write("\nPlease enter the state: ");
            Temp.State = Console.ReadLine();

            Console.Write("\nPlease enter the zip: ");
            Temp.Zip = Console.ReadLine();



            Console.Write("\nPlease enter the phone number: ");
            Temp.Phone = Console.ReadLine();

            Console.Write("\nPlease enter the email: ");
            Temp.Email = Console.ReadLine();

            Console.WriteLine($"\n First name: {Temp.FirstName}");
            Console.WriteLine($"\n Middle name: {Temp.MiddleName}");
            Console.WriteLine($"\n Last name: {Temp.LastName}");
            Console.WriteLine($"\n Street 1: {Temp.Street1}");
            Console.WriteLine($"\n Street 2: {Temp.Street2}");
            Console.WriteLine($"\n City: {Temp.City}");
            Console.WriteLine($"\n State: {Temp.State}");
            Console.WriteLine($"\n Zip: {Temp.Zip}");
            Console.WriteLine($"\n Phone: {Temp.Phone}");
            Console.WriteLine($"\n Email: {Temp.Email}");
            Console.ReadLine();

            // Class, but they are private section--------------------------------------------------------------------------------------------------------------------------

            person temP = new person();

            Console.Write("\nPlease enter the first name: ");
            temP.Firstname = Console.ReadLine();
            temP.Firstname += " Poopy";

            Console.Write("\nPlease enter the middle name: ");
            temP.Middlename = Console.ReadLine();

            Console.Write("\nPlease enter the last name: ");
            temP.Lastname = Console.ReadLine();

            Console.Write("\nPlease enter street 1: ");
            temP.Street1 = Console.ReadLine();

            Console.Write("\nPlease enter street 2: ");
            temP.Street2 = Console.ReadLine();

            Console.Write("\nPlease enter the city: ");
            temP.City = Console.ReadLine();

            Console.Write("\nPlease enter the state: ");
            temP.State = Console.ReadLine();

            Console.Write("\nPlease enter the zip: ");
            temP.Zip = Console.ReadLine();



            Console.Write("\nPlease enter the phone number: ");
            temP.Phone = Console.ReadLine();

            Console.Write("\nPlease enter the email: ");
            temP.Email = Console.ReadLine();

            Console.WriteLine($"\n First name: {temP.Firstname}");
            Console.WriteLine($"\n Middle name: {temP.Middlename}");
            Console.WriteLine($"\n Last name: {temP.Lastname}");
            Console.WriteLine($"\n Street 1: {temP.Street1}");
            Console.WriteLine($"\n Street 2: {temP.Street2}");
            Console.WriteLine($"\n City: {temP.City}");
            Console.WriteLine($"\n State: {temP.State}");
            Console.WriteLine($"\n Zip: {temP.Zip}");
            Console.WriteLine($"\n Phone: {temP.Phone}");
            Console.WriteLine($"\n Email: {temP.Email}");
            Console.ReadLine();




        }
    }
}
