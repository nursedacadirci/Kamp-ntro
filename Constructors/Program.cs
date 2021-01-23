using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id=1, FirstName="Nurseda",LastName="Çadırcı", City="İstanbul"};

            Customer customer3 = new Customer();
            customer3.Id = 3;


            Customer customer2 = new Customer (2,"Serap","Çadırcı","İstanbul");
            //Method(2, "seda","çadırcı",);
            Console.WriteLine(customer2);


        }

        //static void Method(int id, string firstName,string lastName, string city) 
        //{
                   
        
        //}
    }

    class Customer 
    {
        //ctor tab tab
        //default constuctor
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            //Console.WriteLine("Yapıcı blok çalıştı");
            Id= id;
            FirstName= firstName;
            LastName= lastName;
            City = city;

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set;  }


    }
}
