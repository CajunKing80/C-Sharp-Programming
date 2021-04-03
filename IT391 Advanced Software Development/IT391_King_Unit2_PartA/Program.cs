using System;
using System.Collections;
using System.Collections.Generic;


namespace IT391_King_Unit2_PartA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Section 1

            Console.WriteLine("********** Section 1 **********");
            Console.WriteLine();
            Console.WriteLine("Please Enter a Word Without Spaces: ");

            string userInput = Console.ReadLine();

            String reversedString = revString(userInput);

            Console.WriteLine();
            Console.WriteLine("Your Word in Reverse is: " + reversedString);

            // Section 2

            Console.WriteLine();
            Console.WriteLine("********** Section 2 **********");
            Console.WriteLine();

            // Run the Queue
            doQueue();

            // Delay for Screenshot
            Console.ReadKey();
        }

        public static String revString(String userInput) 
        {

            Stack st = new Stack();

            // Add Characters to Stack 
            for (int i = 0; i < userInput.Length; i++)
            {
                st.Push(userInput.Substring(i, 1));
            }

            String reversed = "";

            // Pop Characters Off the Stack 
            while (st.Count != 0)
            {
                reversed += st.Pop();
            }

            // Return the Reversed Word
            return reversed;
        }

        static void doQueue()
        {
            // Create and Fill Queue
            Queue <String> shoppers = new Queue<string>();
            shoppers.Enqueue("Jane");
            shoppers.Enqueue("Bob");
            shoppers.Enqueue("Lisa");
            shoppers.Enqueue("Tom");
            shoppers.Enqueue("Mary");

            // Print Number in Queue
            System.Console.WriteLine("The Number of Shoppers at the Grocery Store is: " + shoppers.Count);

            // Gets Value and Does Not Remove Element From Queue
            System.Console.WriteLine("The First Shopper in Line is; " + shoppers.Peek());

            // Add Shoppers
            shoppers.Enqueue("Stephen");
            shoppers.Enqueue("Ellen"); 

            // Remove Three Shoppers
            for (int i = 1; i < 4; i++)
            {
                shoppers.Dequeue();
            }

            // Print the Number of Shoppers Now
            System.Console.WriteLine("The Number of Shoppers Now in Line is: " + shoppers.Count);

            // Print the Shopper at the Head of the Line
            System.Console.WriteLine("The Shopper Currently First in Line is: " + shoppers.Peek());
        }
    }
}
