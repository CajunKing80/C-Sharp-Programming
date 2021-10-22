// Arithmetic Operators


// You need to buy a parquet floor for your rectangular living room.
// Write a program to take the room's length and width as input and calculate the area of the room (in square meters).
// The variables for length and width are already defined.

// Sample Input
// 5.4
// 2.3

// Sample Output
// 12.42

// Hint
// To calculate the area, multiply the length by the width. In this case 5.4*2.3=12.42.
// Notice that the variables for lengths are double type, which allows us to do calculations with the floating point numeric types (real numbers). 


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
            //sides of the room
            double length;
            double width;
            length = Convert.ToDouble(Console.ReadLine());
            width = Convert.ToDouble(Console.ReadLine());
                     
            Console.WriteLine(length * width);
        }
    }
}