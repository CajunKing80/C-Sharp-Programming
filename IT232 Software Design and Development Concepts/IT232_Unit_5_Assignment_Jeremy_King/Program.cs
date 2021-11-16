using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IT_232_Unit_5_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // *******************************
            // **** Assignment 5 Section 1 ***
            // *******************************

            ArrayList produceList = new ArrayList();

            produceList.Add("bananas 0.59");
            produceList.Add("grapes 2.99");
            produceList.Add("apples 1.49");
            produceList.Add("pears 1.39");
            produceList.Add("lettuce 0.99");
            produceList.Add("onions 0.79");
            produceList.Add("potatoes 0.59");
            produceList.Add("peaches 1.59");

            using (StreamWriter writeFile = new StreamWriter(@"ProducePrice.txt"))
            {
                for (int i = 0; i < produceList.Count; i++)
                {
                    writeFile.WriteLine(produceList[i]);
                }
                writeFile.Close();
            }

            Console.WriteLine("There are " + FileLineCount("ProducePrice.txt") + " products in the file.");

            // *******************************
            // **** Assignment 5 Section 2***
            // *******************************

            using (StreamWriter appendFile = new StreamWriter(@"ProducePrice.txt", true))
            {
                appendFile.WriteLine("peppers 0.99");
                appendFile.WriteLine("celery 1.29");
                appendFile.WriteLine("cabbage 0.79");
                appendFile.WriteLine("tomatoes 1.19");
                appendFile.Close();
            }

            Console.WriteLine("There are " + FileLineCount("ProducePrice.txt") + " products in the file.");
            Console.WriteLine();

            // *******************************
            // **** Assignment 5 Section 3 ***
            // *******************************

            ArrayList producePrices = new ArrayList();
            int lineCounter = 1;
            string line;

            using (StreamReader readFile = new StreamReader(@"ProducePrice.txt", true))
            {
                while ((line = readFile.ReadLine()) != null)
                {
                    producePrices.Add(line);
                    Console.WriteLine(lineCounter + ". " + line);
                    lineCounter++;
                }
                readFile.Close();
            }

            Console.WriteLine();
            Console.WriteLine("There are " + producePrices.Count + " products in the producePrices ArrayList");

            Console.ReadLine();

        }

        static int FileLineCount(string filename)
        {
            int lineCounter = 0;
            string line;
            using (StreamReader readFile = new StreamReader(filename))
            {
                while ((readFile.ReadLine()) != null)
                {
                    lineCounter++;
                }
                readFile.Close();
            }
            return lineCounter;
        }
    }
}
