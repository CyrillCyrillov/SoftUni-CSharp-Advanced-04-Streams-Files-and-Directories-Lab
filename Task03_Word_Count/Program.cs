using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Task03_Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCounter = new Dictionary<string, int>();
            
            using (StreamReader readFile = new StreamReader(@"..\..\..\words.txt"))
            {
                string[] keys = readFile.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (string key in keys)
                {
                    wordsCounter.Add(key, 0);
                }
            }

            using (StreamReader readFile = new StreamReader(@"..\..\..\text.txt"))
            {
                while (true)
                {
                    string nextLine = readFile.ReadLine();

                    if(nextLine == null)
                    {
                        break;
                    }

                    string[] wordsToChek = nextLine.Split(new char[] { ',', '.', '!', '?', ' ', '-', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    foreach (string word in wordsToChek)
                    {
                        if(wordsCounter.ContainsKey(word.ToLower()))
                        {
                            wordsCounter[word.ToLower()]++;
                        }
                    }
                }
            }

            using (StreamWriter writeToFile = new StreamWriter(@"..\..\..\output.txt"))
            {
                foreach (var element in wordsCounter.OrderByDescending(x => x.Value))
                {
                   // Console.WriteLine($"{element.Key} - {element.Value}");
                   writeToFile.WriteLine($"{element.Key} - {element.Value}");
                }
            }
            

            //Console.WriteLine("Hello World!");
        }
    }
}
