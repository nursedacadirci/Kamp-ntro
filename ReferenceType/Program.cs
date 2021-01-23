using System;

namespace ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int,decimal,float,enum, boolean: value types(değer tipleri)
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("Sayı 1 :" + sayi1);//sonuç: 20


            ////arrays,class,interface...reference type(referans tipleri)

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayılar1[0]: "+sayilar1[0]);//cevap 1000

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "NURSEDA";

            person2 = person1;
            person1.FirstName = "ERDAN";

            //Console.WriteLine(person2.FirstName); //Cevap: ERDAN 



            Customer customer = new Customer();
            customer.FirstName = "ALİHAN";
            customer.CrediCartNumber = "12345678910";

            Employee employee = new Employee();
            employee.FirstName = "SERAP";

            //Console.WriteLine(person3.FirstName);// cevap:ALİHAN

            Person person3 = customer;
            customer.FirstName = "ASYA";

            //Console.WriteLine(((Customer)person3).CrediCartNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

        }
    }

    class Person 
    {
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    //(Temel Sınıf)base class: Person

    class Customer:Person
    {
        public string CrediCartNumber { get; set; }
    }
    class Employee: Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager 
    {
        public void Add(Person person) 
        {
            Console.WriteLine(person.FirstName);
        }
    
    }




}
