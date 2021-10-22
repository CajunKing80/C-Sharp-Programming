// Getting User Input


// You are making an authorization program for your application.
// The given code takes the name of the person as input and outputs it in the given format.
// Complete the program to also take their age as input and output the corresponding text in the provided format.

// Sample Input
// Tom
// 26

// Sample Output
// Name: Tom
// Age: 26
// Note that there is a space after the colon.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Age: "+ age);
        }
    }
}