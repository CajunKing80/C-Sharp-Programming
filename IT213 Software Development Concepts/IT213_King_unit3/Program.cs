using System;

namespace IT213_King_unit3
{
    class Program
    {
        static void Main(string[] args)
        {

            //************************************************************************************
            //***** Assignment 3 Section 1
            //************************************************************************************

            Console.WriteLine("******************************************************************");
            Console.WriteLine("***** Assignment 3: Section 1 - While Loop to Average Grades *****");
            Console.WriteLine("******************************************************************\n");


            // Initialize the Variables


            int counter = 1;
            int total = 0;
            int grade = 0;
            int average = 0;


            // Processing


            // Using a while loop structure, create a loop based on a counter variable which will cycle through 10 iterations.
            // With each iteration of the loop, request a grade from the user and add it to a running total.
            // After the loop has ended, print to the console the overall total and the class average.
            while (counter <= 10)
            {
                Console.Write("Please Enter a Grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                total = total + grade;
                counter += 1;
            }

            average = total / 10;


            // Display


            Console.WriteLine("\nThe Total For All 10 Grades Is: " + total);
            Console.WriteLine("The Class Average Is: " + average);

            //************************************************************************************
            //***** Assignment 3 Section 2
            //************************************************************************************

            Console.WriteLine("\n\n******************************************************************");
            Console.WriteLine("*********** Assignment 3: Section 2 - Nested For Loops ***********");
            Console.WriteLine("******************************************************************\n");


            // Processing


            // Create a set of two nested for loops.
            // The outer loop will iterate from 5 to 1, decrementing by 1 with each consecutive iteration. Use the letter ‘k’ for its counter variable name.
            // The inner loop will iterate from 0 to 10 by 2.Use the letter ‘i’ for its counter variable.Hint: Use the += operator to increment by 2.
            // With each iteration of the inner loop, print both loop index values such as k = 5, i = 0
            for (int k = 5; k >= 1; k--)
            {
                for (int i = 0; i <= 10; i += 2)
                {
                    Console.WriteLine("k = {0} i = {1}", k, i);
                }
            }

            //************************************************************************************
            //***** Assignment 3 Section 3
            //************************************************************************************

            Console.WriteLine("\n\n******************************************************************");
            Console.WriteLine("******* Assignment 3: Section 3 - While Loop With Sentinel *******");
            Console.WriteLine("******************************************************************\n");


            // Initialize the Variables


            int userNumber = 0;
            int runningTotal = 0;


            // Processing


            // Use a while loop to process user entered numbers.
            // Inform the user to enter a positive number to be added to the total or - 1 to end.
            // With each iteration of the loop, add the user entered value to a running total.
            // End the loop when the user enters - 1 and do not add that value to the running total.
            // Once the loop ends, print the total of the numbers entered, (excluding the sentinel value - 1.)
            while (userNumber != -1)
            {
                Console.WriteLine("Enter a Positive Number or -1 to End: ");
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber != -1)
                {
                    runningTotal = runningTotal + userNumber;
                }
            }


            //Display


            Console.WriteLine("The Sum of the Numbers Entered is: " + runningTotal);
            Console.Read();
        }
    }
}