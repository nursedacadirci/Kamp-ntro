using System;
using System.Linq;

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

            //int number1 = 20;//ref te number 1 i mutlaka yazman gerek. out ta öyle bir şart yok!!!
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);
            //var result2 = Add3(out number1, number2);

            //var result = Add2(20); // number2=30 eşit old için sonuç 50 çıkar
            //Console.WriteLine(result);

            //Console.WriteLine(result2);//sonuç 130
            //Console.WriteLine(number1);//sonuç 20

            Console.WriteLine(Multiply(2,4));// 8
            Console.WriteLine(Multiply(2,4,5));//40

            Console.WriteLine(Add4(1,2,3,4,5,6));
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

        static int Add3(ref int number1, int number2) 
        {
            number1 = 30;
            return number1 + number2;
        }

        //static int Add3(out int number1, int number2)
        //{
        //    number1 = 30;// outta bu değeri tanımlaman gerek
        //    return number1 + number2;
        //}

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4 (params int[] numbers) 
        {
            return numbers.Sum(); //sonuç 21 dir
        }
        static int Add4(int number,params int[] numbers)
        {
            return numbers.Sum(); //sonuç 20 dir. çünkü ilk değere sen number atadın,
        }

    }
}
