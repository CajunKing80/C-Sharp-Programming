// Getting User Input


// You are organizing an important event and you should greet each participant with a welcome message․ The given code outputs the message.

// Task
// Complete the program to take the participant's name as input and assign it to the "name" variable.

// Sample Input
// Tom

// Sample Output
// Hello Tom. Welcome to our event
// Note that the variable for name is already defined.


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
            string name;
            
    // Console.WriteLine("What is your name?");

            name = Console.ReadLine();            
            
            Console.WriteLine("Hello {0}. Welcome to our event",name);
        }
    }
}