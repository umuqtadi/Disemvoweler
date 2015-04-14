using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            // keep the console open
            Console.ReadKey();
        }

        /// <summary>
        /// removes vowels from sentence. prints the resulting sentence, along with the vowels that were taken out 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Disemvoweler(string input)
        {
            input = input.ToLower();
            //empty string to store vowels in
            string tempString1 = string.Empty;
            //empty string to store all other letters in
            string tempString2 = string.Empty;
            
            //loops through the sentene one character at time and determines if the letter is a vowel or  not
            for (int i = 0; i < input.Length; i++)
            {
                if ("aeiou".Contains(input[i]))
                {
                    tempString1 = tempString1 + input[i];
                }
                if ("bcdfghjklmnpqrstvwxyz".Contains(input[i]))
                {
                    tempString2 = tempString2 + input[i];
                }
            }
            
            // Write out the various string results
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Disemvoweled: " + tempString2);
            Console.WriteLine("Vowels Removed: " + tempString1);
            Console.WriteLine("\n");
            // Return the Disemvoweled string as well for testing
            return tempString2;
        }
    }
}
