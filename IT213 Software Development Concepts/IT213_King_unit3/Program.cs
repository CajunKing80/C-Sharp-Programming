﻿using System;

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


        }
    }
}