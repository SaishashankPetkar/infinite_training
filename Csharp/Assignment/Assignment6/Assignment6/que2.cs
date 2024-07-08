using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class que2
    {
        public static void Charatercheck()
        {
            List<string> words = new List<string>();
            Console.Write("Enter how many Words you want to search : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Enter the {n} words on which you want to perform search operation  : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter {i + 1} word which has to be searched : ");
                string Word = Console.ReadLine();
                words.Add(Word.ToLower());
            }

            var match = words.Where(word => word.StartsWith("a") && word.EndsWith("m"))
                             .ToList();

            Console.WriteLine();
            Console.WriteLine("Words that starts 'a' and ends with 'm' are : ");
            foreach (var word in match)
            {
                Console.WriteLine($"The word is : {word}");
            }
        }
    }
}
