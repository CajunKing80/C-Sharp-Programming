// Birthday Party


// You are organizing a birthday party and need N number of balloons. You already have 14 balloons for decoration.
// The given program takes the N required number of balloons as input.

// Task
// Calculate and output how many balloons you need to buy.

// Sample Input
// 30

// Sample Output
// 16

// Explanation
// The count of the balloons you need to buy is calculated by this formula: balloons-14. So, in this case, the count is 30-14=16.
// Use - operator for calculating.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int balloons = Convert.ToInt32(Console.ReadLine());
            int x = 14;
            
            Console.WriteLine(balloons-x);
            
        }
    }
}
