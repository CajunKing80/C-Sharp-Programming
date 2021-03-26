using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Unit1 
{ 

    class Program 
    { 
    
        static void Main(string[] args) 
        {

            //*********************************************************
            //****Assignment 1, Section 1
            //*********************************************************

            Console.WriteLine();
            Console.WriteLine("**********Section 1 * *********");
            Console.WriteLine();
            Console.Write("The Fibonacci value of 10 is: ");
            Console.WriteLine(fibonacci(10));
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("**********Section 2 * *********");
            Console.WriteLine();
            for (int counter = 1; counter <= 4; counter++)
            {
                Console.WriteLine("{0}! = {1}", counter, factorial(counter));
            }
        } // End of Main 
        public static int fibonacci(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }
            return fibonacci(number - 1) + fibonacci(number - 2);
        } // End of Fibonacci
        public static int factorial(int number)
        {
            if (number <= 1)
                return 1;
            else
                return number * factorial(number - 1);
        } // End of Factorial
    }
}
