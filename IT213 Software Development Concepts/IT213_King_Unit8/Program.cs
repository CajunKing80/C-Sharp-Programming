using System;

namespace IT213_King_Unit8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 56, 77, 23, 12, 88, 59, 97, 33, 38, 64 };
            string[] stringArray = new string[10];
            int maxNumIndex = findMax(numberArray, numberArray.Length);

            evenOrOdd(numberArray, stringArray, numberArray.Length);

            Console.WriteLine("**** Assignment 8 - Arrays ****\n\n");
            Console.WriteLine("The largest value in the array is " + numberArray[maxNumIndex] + " located at array index " + maxNumIndex);
            Console.WriteLine("The numbers were:");

            for (int i = 0; i < numberArray.Length; i++)

                Console.WriteLine(numberArray[i] + " is " + stringArray[i]);

            Console.Read();
        }

        public static int findMax(int[] numArray, int length)
        {
            int maxValue = numArray[0];
            int maxValuePosition = 0;

            for (int i = 0; i < length; i++)
            {
                if (numArray[i] > maxValue)
                {
                    maxValue = numArray[i];
                    maxValuePosition = i;
                }
            }
            return maxValuePosition;
        }

        public static void evenOrOdd(int[] numArray, String[] strArray, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (numArray[i] % 2 == 0)
                {
                    strArray[i] = "even";
                }
                else
                {
                    strArray[i] = "odd";
                }
            }
        }
    }
}
