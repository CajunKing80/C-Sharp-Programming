using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class myProgram
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

            //*********************************************************
            //****Assignment 1, Section 2
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine("**********Section 2 * *********");
            Console.WriteLine();
            Console.Write("The factorial of 4 is: ");
            Console.WriteLine();
        }
        public static int fibonacci(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }
            return fibonacci(number - 1) + fibonacci(number - 2);
        } // end of Fibonnaci
    } // end of myProgram
} // end of namespace


//=============================================================================================
//==================================SECTION 2==================================================
//=============================================================================================