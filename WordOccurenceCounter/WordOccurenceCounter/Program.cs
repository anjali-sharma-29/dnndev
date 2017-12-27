using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WordOccurenceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> searchWords = new SortedDictionary<string, int>();
            Console.WriteLine("Enter input");
            String input = Console.ReadLine().ToUpper();
            Console.WriteLine("\nEnter words to be search \n\n use . to serach");
            do
            {
                 string word = Console.ReadLine();
                
                if(word== ".")
                {
                    break;
                }
                searchWords.Add(word, 0);

            } while (true);
            var keyValue = searchWords.Keys.ToList();
            foreach( string key in keyValue )
            {
                searchWords[key] = Regex.Matches(input, key.ToUpper()).Count;
            }
            keyValue.Sort();
            Console.WriteLine("\nWord    Count");
            foreach(string key in keyValue)
            {
                Console.WriteLine(" {0}    {1}  ",key,searchWords[key]);
            }
            Console.ReadLine();
            Console.ReadLine();      
        }
    }
}
