using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_King_Unit5_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            int current = 0;
            int blankPosition = 0;
            int wordcount = 0;
            string word;


            for (int i = 0; i < sentence.Length; i++)
            {
                current = i;
                blankPosition = sentence.IndexOf(" ", current);

                if (blankPosition == -1)
                {
                    word = sentence.Substring(current);
                    i = sentence.Length;
                }
                else
                {
                    word = sentence.Substring(current, blankPosition - current);
                    i = blankPosition; 
                }

                wordcount++;
                Console.WriteLine(wordcount + "  " + word);
            }
            Console.WriteLine("Total word count " + wordcount);
            Console.ReadKey();
        }
    }
}
