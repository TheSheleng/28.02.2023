using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            var dict = new SortedDictionary<string, int>();
            foreach(string word in text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)) 
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] += 1;
                }
                else dict.Add(word, 1);
            }

            Console.WriteLine();
            foreach (var item in dict)
            {
                Console.WriteLine($"\t{item.Key} : {item.Value}");
            }
            Console.ReadKey();
        }
    }
}
