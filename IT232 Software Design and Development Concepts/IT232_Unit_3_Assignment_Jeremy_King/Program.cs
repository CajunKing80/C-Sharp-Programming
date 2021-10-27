using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Unit_3_Assignment_Jeremy_King
{
    class Program
    {
        static void Main(string[] args)
        {

            //****************************
            //****Assignment 3, Section 1
            //****************************

            Console.WriteLine();
            Console.WriteLine("********** Section 1: Two-Dimensional Array **********");
            Console.WriteLine();

            string[,] salesRegion = new string[,]
            {
                {"North", "Bob", "Stref", "Ron"},
                {"South", "Sue", "Janice", "Will"},
                {"East", "Nathan", "Henry", "Kimmy"},
                {"West", "Wanda", "Charles", "Pete"},
            };

            Console.WriteLine(salesRegion[0, 0]+ "  " +salesRegion[1,0]+ "  " +salesRegion[2,0] + "    " + salesRegion[3, 0]);
            Console.WriteLine(salesRegion[0, 1] + "    " + salesRegion[1, 1] + "    " + salesRegion[2, 1] + "  " + salesRegion[3, 1]);
            Console.WriteLine(salesRegion[0, 2] + "  " + salesRegion[1, 2] + " " + salesRegion[2, 2] + "   " + salesRegion[3, 2]);
            Console.WriteLine(salesRegion[0, 3] + "    " + salesRegion[1, 3] + "   " + salesRegion[2, 3] + "   " + salesRegion[3, 3]);
            Console.WriteLine(); 

            foreach (string row in salesRegion)
            {
                Console.WriteLine(row);
            } 

            //****************************
            //****Assignment 3, Section 2
            //****************************

            Console.WriteLine();
            Console.WriteLine("********** Section 2: Array List **********");
            Console.WriteLine();

            ArrayList salesTeam = new ArrayList();
            salesTeam.Add("Bob");
            salesTeam.Add("Stref");
            salesTeam.Add("Ron");

            Console.WriteLine("There are " + salesTeam.Count + " names in the salesTeam ArrayList.");

            salesTeam.Add("Sue");
            salesTeam.Add("Janice");
            salesTeam.Add("Will");

            if (salesTeam.Contains("Stref"))
            {
                Console.WriteLine("Stref is in the salesTeam ArrayList.");
            }

            Console.WriteLine("There are " + salesTeam.Count + " names in the salesTeam ArrayList.");

            salesTeam.Remove("Janice");
            salesTeam.Remove("Ron");

            Console.WriteLine("There are " + salesTeam.Count + " names in the salesTeam ArrayList.");

            Console.WriteLine("Names currently in the salesTeam ArrayList are: ");
            Console.WriteLine();
            foreach (string name in salesTeam)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();

            //End of Assignment
        }
    }
}
