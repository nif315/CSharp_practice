using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Where_my_anagrams_at
{
    class Program
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> anagramsList = new List<string>();
            string[] anagrams = words.ToArray();
            for (int i = 0; i < anagrams.Length; i++)
            {
                char[] char1 = word.ToLower().ToCharArray();
                char[] char2 = anagrams[i].ToLower().ToCharArray(); 
                Array.Sort(char1);
                Array.Sort(char2);
                string givenWord = new string(char1);
                string anagram = new string(char2);
                if (anagram == givenWord)
                {
                    anagramsList.Add(anagrams[i]);
                }
            }
            return anagramsList;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input the word:");
            string word = Console.ReadLine();
            Console.WriteLine("Input anagrams:");
            string[] anagrams = new string[5];
            List<string> words = new List<string>();
            for (int i = 0; i < anagrams.Length; i++)
            {
                anagrams[i] = Console.ReadLine();
                words.Add(anagrams[i]);
            }
            //Console.WriteLine(string.Join(",", words));
            Console.WriteLine(string.Join(",",Anagrams(word, words)));
            Console.ReadKey();
        }
    }
}
