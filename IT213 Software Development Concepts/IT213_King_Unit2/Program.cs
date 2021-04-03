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

            Console.WriteLine("******************************");
            Console.WriteLine("**Unit 2 Project Section 1**\n");
            Console.WriteLine("******************************");

            // Initialize Variables

            int wholeNumber1;
            int wholeNumber2;
            double userGrade;
            int userMonth;
            int weekday;

 
            // Display Results

            Console.Write("Please Enter a Whole Nummber: \n");
            Console.WriteLine();
            wholeNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please Enter a Second Whole Nummber: \n");
            Console.WriteLine();
            wholeNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            // Processing

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
            Console.WriteLine();

            //************************************************************************************
            //***** Assignment 2 Section 2
            //************************************************************************************

            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine("**Unit 2 Project Section 2**\n");
            Console.WriteLine("******************************");
            Console.Write("Please Enter a Grade {A - F}: \n");
            Console.WriteLine();
            userGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (userGrade >= 60)
                Console.WriteLine("Congratulations, you passed.");
            else
                Console.WriteLine("Sorry, you failed.");
            Console.WriteLine();


            //************************************************************************************
            //***** Assignment 2 Section 3
            //************************************************************************************

            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine("**Unit 2 Project Section 3**\n");
            Console.WriteLine("******************************");
            Console.Write("Please Enter a Numeric Month {1 -12}: \n");
            Console.WriteLine();
            userMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userMonth == 1)
            {
                Console.WriteLine("The month is January.");
            }
            else if (userMonth == 2)
            {
                Console.WriteLine("The month is February.");
            }
            else if (userMonth == 3)
            {
                Console.WriteLine("The month is March.");
            }
            else if (userMonth == 4)
            {
                Console.WriteLine("The month is April.");
            }
            else if (userMonth == 5)
            {
                Console.WriteLine("The month is May.");
            }
            else if (userMonth == 6)
            {
                Console.WriteLine("The month is June.");
            }
            else if (userMonth == 7)
            {
                Console.WriteLine("The month is July.");
            }
            else if (userMonth == 8)
            {
                Console.WriteLine("The month is August.");
            }
            else if (userMonth == 9)
            {
                Console.WriteLine("The month is September.");
            }
            else if (userMonth == 10)
            {
                Console.WriteLine("The month is October.");
            }
            else if (userMonth == 11)
            {
                Console.WriteLine("The month is November.");
            }
            else if (userMonth == 12)
            {
                Console.WriteLine("The month is December.");
            }
            else
                Console.WriteLine("You entered an invalid month.");
            Console.WriteLine();


            //************************************************************************************
            //***** Assignment 2 Section 4
            //************************************************************************************

            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine("**Unit 2 Project Section 4**\n");
            Console.WriteLine("******************************");
            Console.Write("Please Enter a Numeric Weekday {1 -7}: \n");
            Console.WriteLine();
            weekday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (weekday) 
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("You entered an invalid day.");
                    break;
            }
            // End of Program
            Console.Read();
        }
    }
}