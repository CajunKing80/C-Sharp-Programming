using System;

namespace IT213_KingJeremy_Unit2
{
    class Program
    {
        static void Main(string[] args)
        {

            //************************************************************************************
            //***** Assignment 2 Section 1
            //************************************************************************************

            Console.WriteLine("Unit 2 Project\n\n");

            // Initialize Variables

            int wholeNumber1;
            int wholeNumber2;

            // Processing

            // Display Results

            Console.Write("Please Enter a Whole Nummber: \n");
            Console.WriteLine();
            wholeNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please Enter a Second Whole Nummber: \n");
            Console.WriteLine();
            wholeNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (wholeNumber1 > wholeNumber2)
                Console.WriteLine(wholeNumber1 + " > " + wholeNumber2);
            if (wholeNumber1 < wholeNumber2)
                Console.WriteLine(wholeNumber1 + " < " + wholeNumber2);
            if (wholeNumber1 >= wholeNumber2)
                Console.WriteLine(wholeNumber1 + " >= " + wholeNumber2);
            if (wholeNumber1 <= wholeNumber2)
                Console.WriteLine(wholeNumber1 + " <= " + wholeNumber2);
            if (wholeNumber1 == wholeNumber2)
                Console.WriteLine(wholeNumber1 + " == " + wholeNumber2);
            if (wholeNumber1 != wholeNumber2)
                Console.WriteLine(wholeNumber1 + " != " + wholeNumber2);


            //************************************************************************************
            //***** Assignment 2 Section 2
            //************************************************************************************

            // Initialize Variables

            int userGrade;
            
            Console.Write("Please Enter a Grade {A - F}: \n");
            userGrade = Convert.ToInt32(Console.ReadLine());

            if (userGrade >= 60)
                Console.WriteLine("Congratulations, you passed.");
            else
                Console.WriteLine("Sorry, you failed.");

            // Processing

            // Display Results


            //************************************************************************************
            //***** Assignment 2 Section 1
            //************************************************************************************

            // Initialize Variables



            // End of Program
            Console.Read();
        }
    }
}