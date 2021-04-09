using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_King_Unit3_PartB
{
    class myProgram
    {
        static void Main(string[] args)
        {
            //*********************************************************
            //****Assignment 3, Part B, Section 1
            //*********************************************************

            Console.WriteLine();
            Console.WriteLine("*********************************************");
            Console.WriteLine("***************** Section 1 *****************");
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine();


            try
            {
                String[] mammals = new string[] { "Bear", "Gorilla", "Tiger", "Polar Bear", "Lion", "Monkey" };
                var setMammals = new HashSet<String>(mammals);
                Console.WriteLine(string.Join(",", setMammals));
                SortedSet<string> sortedMammals = new SortedSet<string>(mammals);
                Console.WriteLine(string.Join(",", sortedMammals));
            }
            catch
            {
                Console.WriteLine("There is an Error in the Code. Please Check Your Error:");
            }
            

            //*********************************************************
            //****Assignment 3, Part B, Section 2
            //*********************************************************

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*********************************************");
            Console.WriteLine("***************** Section 2 *****************");
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine();

            LinkedList<string> myFriends = new LinkedList<string>();

            myFriends.AddFirst("Fred 602-299-3300");
            myFriends.AddLast("Ann 602-555-4949");
            myFriends.AddLast("Grace 520-544-9898");
            myFriends.AddLast("Sam 602-343-8723");
            myFriends.AddLast("Dorothy 520-689-9745");
            myFriends.AddLast("Mary 520-788-3457");
            myFriends.AddLast("Susan 520-981-8745");
            myFriends.AddLast("Bill 520-456-9823");

            Console.WriteLine("The original contents of myFriends is: \n");
            foreach (var item in myFriends)
            {
                Console.WriteLine(item);
            }

            myFriends.Remove("Bill 520-456-9823");

            myFriends.RemoveFirst();
            myFriends.RemoveLast();

            myFriends.Find("Mary 520-788-3457").Value = "Mary 520-897-4567";

            Console.WriteLine("\nThe contents of myFriends after the changes is: \n");
            foreach (var item in myFriends)
            {
                Console.WriteLine(item);
            }

            int numberOfFriends = myFriends.Count;

            Console.WriteLine("\nmyFriends contains " + numberOfFriends + " friends\n");

            Console.WriteLine(myFriends.Contains("Fred 602-299-3300"));


            //*********************************************************
            //****Assignment 3, Part B, Section 3
            //*********************************************************

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*********************************************");
            Console.WriteLine("***************** Section 3 *****************");
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine();

            //creates a new binary tree object which will initialize itself and print its contents

            new BinaryTree().create();

            Console.ReadKey();

        }

        static void DisplayList(List<String> lst)
        {
            Console.Write("[");
            for (int i = 0; i < lst.Count(); i++)
            {
                Console.Write(lst[i]);
                if (i != lst.Count() - 1)
                    Console.Write(", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }

    public class Node
    {
        public Node left;
        public Node right;
        public int value;
        public Node(int value)
        { this.value = value; }
    }

    public class BinaryTree
    {
        public void create()
        {
            Node rootnode = new Node(50);
            insert(rootnode, 30);
            insert(rootnode, 45);
            insert(rootnode, 12);
            insert(rootnode, 29);
            Console.WriteLine("The contents of the binary tree are: ");
            traverse(rootnode);
        }

        public void traverse(Node rootnode)
        {
            printInOrder(rootnode); // printInOrder uses recursion to traverse the tree
        }

        public void insert(Node node, int value)
        {
            if (value < node.value)
            {
                if (node.left != null)
                {
                    insert(node.left, value);
                }
                else
                {
                    //Console.WriteLine(" Inserted " + value + " to left of node " + node.value);
                    node.left = new Node(value);
                }
            }
            else if (value > node.value)
            {
                if (node.right != null) { insert(node.right, value); }
                else
                {
                    //Console.WriteLine(" Inserted " + value + " to right of node " + node.value);
                    node.right = new Node(value);
                }
            }
        }

        public void printInOrder(Node node)
        {
            if (node != null)
            {
                printInOrder(node.left); Console.WriteLine(" Traversed " + node.value);
                printInOrder(node.right);
            }
        }

    }
}