using System;

namespace IT213_King_Unit7
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempInF = 0;
            double tempOne = 35.5;
            double tempTwo = 30.5;
            double tempThree = 22.2;
            double tempFour = 16.1;
            double tempFive = 7.3;
            double tempSix = -1;
            string adv = " ";

            Console.Write("Assignment 7 - Functions and Type Conversion\n\n");

            tempInF = fahrenheit(tempOne);
            adv = weatherStatement(tempInF);
            Console.Write("The temperature is " + tempOne + "C or " + tempInF + "F. " + adv + "\n");

            tempInF = fahrenheit(tempTwo);
            adv = weatherStatement(tempInF);
            Console.Write("The temperature is " + tempTwo + "C or " + tempInF + "F. " + adv + "\n");

            tempInF = fahrenheit(tempThree);
            adv = weatherStatement(tempInF);
            Console.Write("The temperature is " + tempThree + "C or " + tempInF + "F. " + adv + "\n");

            tempInF = fahrenheit(tempFour);
            adv = weatherStatement(tempInF);
            Console.Write("The temperature is " + tempFour + "C or " + tempInF + "F. " + adv + "\n");

            tempInF = fahrenheit(tempFive);
            adv = weatherStatement(tempInF);
            Console.Write("The temperature is " + tempFive + "C or " + tempInF + "F. " + adv + "\n");

            tempInF = fahrenheit(tempSix);
            adv = weatherStatement(tempInF);
            Console.Write("The temperature is " + tempSix + "C or " + tempInF + "F. " + adv + "\n");

            Console.Read();
        }


        public static int fahrenheit(double myTemp)
        {
            int intTemp = (int)(myTemp * 9.0 / 5.0 + 32 + .5);
            return intTemp;
        }

        public static string weatherStatement(int tempInF)
        {
            if (tempInF >= 95)
            {
                return "A heat advisory has been issued";
            }

            else if (tempInF >= 85)
            {
                return "Pleasant but warm";
            }

            else if (tempInF >= 70)
            {
                return "Very pleasant weather today";
            }

            else if (tempInF >= 50)
            {
                return "Pleasant but cool";
            }

            else if (tempInF >= 33)
            {
                return "Cold weather";
            }

            else
            {
                return "A freeze warning has been issued";
            }
        }
    }
}