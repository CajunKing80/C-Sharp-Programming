using System;
using System.Collections;
using System.Collections.Generic;


namespace IT391_King_Unit2_PartB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Section 1**********");
            Console.WriteLine();

            // Execute the Queue
            doQueue();

            Console.WriteLine();
            Console.WriteLine("************Section 2**********");
            Console.WriteLine();

            Console.WriteLine("Please Enter a Sentence: ");
            string message = Console.ReadLine();

            // Call the Stack
            doStack(message);

            // Delay for Screenshot
            Console.ReadKey();
        }


        static void doQueue()
        {
            // Create and Fill Queue
            Queue customers = new Queue();
            customers.Enqueue("Jim");
            customers.Enqueue("Bob");
            customers.Enqueue("Susan");
            customers.Enqueue("Liz");
            customers.Enqueue("Alex");

            // Print Number in Queue
            Console.WriteLine("The number of people in line at the bank is: " + customers.Count);
            Console.WriteLine();
            Console.WriteLine("The names of the customers in line at the bank are: ");
            Console.WriteLine();

            // For Loop
            foreach (string customer in customers)
                Console.WriteLine(customer);

            Console.WriteLine();
            Console.WriteLine("The first customer in line is: " + customers.Peek());
            Console.WriteLine();

            // Remove first customer
            customers.Dequeue();

            // Add Customers
            customers.Enqueue("Andy");
            customers.Enqueue("Rhonda");

            // Remove Three Customers
            for (int i = 1; i <= 3; i++)
            {
                customers.Dequeue();
            }

            Console.WriteLine("The number of customers in line now is: " + customers.Count);
        }

        private static void doStack(string str)
        {
            Stack stack = new Stack();

            // Split the sentence into words
            string[] splitSentence = str.Split(' ');

            // Push words onto the Stack
            for (int i = 0; i < splitSentence.Length; i++)
                stack.Push(splitSentence[i]);

            // Print reversed words
            for (int i = 0; i < splitSentence.Length; i++)
                Console.WriteLine(stack.Pop());
        }
    }
}
