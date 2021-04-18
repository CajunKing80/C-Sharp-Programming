using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_King_Unit4_PartB

{
    class Program
    {
        static void Main(string[] args)
        {
            //*********************************************************
            //****Assignment 4, Part B, Section 1
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine("**********Section 1 - Bubble Sort **********");
            Console.WriteLine();

            Program bubble = new Program();

            int[] studentGrades = { 65, 95, 75, 55, 56, 90, 98, 88, 97, 78 };

            Console.Write("The unsorted list of grades is: \n");
            bubble.printArray(studentGrades);
            bubble.sortArrayDescBS(studentGrades);
            Console.WriteLine("The grades in descending order are: ");
            bubble.printArray(studentGrades);
            bubble.sortArrayAscBS(studentGrades);
            Console.WriteLine("The grades in ascending order are: ");
            bubble.printArray(studentGrades);




            //*********************************************************
            //****Assignment 4, Part B, Section 2
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********Section 2 - Quick Sort **********");
            Console.WriteLine();

            Program quick = new Program();

            quick.sortArrayDescQS(studentGrades, 0, 9);
            Console.WriteLine("The grades in descending order are, ");
            quick.printArray(studentGrades);

            quick.sortArrayAscQS(studentGrades, 0, 9);
            Console.WriteLine("The grades in ascending order are, ");
            quick.printArray(studentGrades);




            //*********************************************************
            //****Assignment 4, Part B, Section 3
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********Section 3 - Sequential Search**********");
            Console.WriteLine();

            Program sequential = new Program();

            Console.WriteLine("The grades in ascending order are, ");
            sequential.sortArrayAscQS(studentGrades, 0, 9);
            sequential.printArray(studentGrades);

            int grade = 75;
            string value = sequential.seqSearch(studentGrades, grade);

            Console.WriteLine(value);

            grade = 80;
            value = sequential.seqSearch(studentGrades, grade);
            Console.WriteLine(value);




            //*********************************************************
            //****Assignment 4, Part B, Section 4
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********Section 4 - Binary Search**********");
            Console.WriteLine();
            Console.WriteLine("The contents of the grade array are, ");


            sequential.sortArrayAscQS(studentGrades, 0, 9);
            sequential.printArray(studentGrades);

            string message = binarySearch(studentGrades, 0, 9, 56);

            Console.WriteLine(message);
            message = binarySearch(studentGrades, 0, 9, 50);
            Console.WriteLine(message);

            Console.ReadKey();

        }




        public void sortArrayAscBS(int[] x)
        {
            int temp = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length - 1; j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        temp = x[j + 1];
                        x[j + 1] = x[j];
                        x[j] = temp;
                    }
                }
            }
        }



        public void sortArrayDescBS(int[] x)
        {
            int temp = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length - 1; j++)
                {
                    if (x[j] < x[j + 1])
                    {
                        temp = x[j + 1];
                        x[j + 1] = x[j];
                        x[j] = temp;
                    }
                }
            }
        }





        public void sortArrayDescQS(int[] x, int low, int high)
        {
            if (x == null || x.Length == 0)
                return;

            if (low >= high)
                return;

            int middle = low + (high - low) / 2;
            int pivot = x[middle];

            int i = low, j = high;
            while (i <= j)
            {
                while (x[i] > pivot)
                {
                    i++;
                }
                while (x[j] < pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = x[i];
                    x[i] = x[j];
                    x[j] = temp;
                    i++;
                    j--;
                }
            }

            if (low < j)
                sortArrayDescQS(x, low, j);

            if (high > i)
                sortArrayDescQS(x, i, high);

        }




        public void sortArrayAscQS(int[] x, int low, int high)
        {
            if (x == null || x.Length == 0)
                return;

            if (low >= high)
                return;

            int middle = low + (high - low) / 2;
            int pivot = x[middle];

            int i = low, j = high;
            while (i <= j)
            {
                while (x[i] < pivot)
                {
                    i++;
                }
                while (x[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = x[i];
                    x[i] = x[j];
                    x[j] = temp;
                    i++;
                    j--;
                }
            }

            if (low < j)
                sortArrayAscQS(x, low, j);

            if (high > i)
                sortArrayAscQS(x, i, high);

        }




        public string seqSearch(int[] x, int key)
        {
            string message = "";

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == key)
                {
                    return "The grade " + key + " is found at index " + i + ".";
                }
                else
                {
                    message = "The grade " + key + " is not found."; 
                }
            }

            return message;

        }




        public static string binarySearch (int[] x, int lowerbound, int upperbound, int key)

        {
            string message = "";
            int position;
            position = (lowerbound + upperbound) / 2;

            while ((x[position] != key) && (lowerbound <= upperbound))
            {
                if (x[position] > key)
                {
                    upperbound = position - 1;
                }
                else
                {
                    lowerbound = position + 1;
                }
                position = (lowerbound + upperbound) / 2;
            }
            if (lowerbound <= upperbound)
            {
                return "the grade " + x[position] + " was found at index " + position + ".";
            }
            else
            {
                message = key + " is not in the arrary.";
            }

            return message;
        }




        public void printArray(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }

            Console.WriteLine(" ");
        }
    }     
}