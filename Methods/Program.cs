using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(20, 30);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1, number2);

            //var result = Add2(20); // number2=30 eşit old için sonuç 50 çıkar
            //Console.WriteLine(result);

            Console.WriteLine(result2);//sonuç 130
            Console.WriteLine(number1);//sonuç 20
            Console.ReadLine();


        }


        static void Add() 
        {
            Console.WriteLine("Added!!!");
                
        }

        //static int Add2(int number1, int number2)
        //static int Add2(int number1, int number2=30)
        //static int Add2(int number1=20, int number2)-- Bu kod çalışmaz!!
        static int Add2(int number1=20, int number2=30)

        {
            var result = number1 + number2;
            return result;
        
        
        }

        static int Add3(int number1, int number2) 
        {
            number1 = 30;
            return number1 + number2;
        
        }
    }
}
