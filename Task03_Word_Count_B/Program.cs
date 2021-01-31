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

            string pathToRead = Path.Combine("data", "words.txt");
            using (StreamReader readFile = new StreamReader(pathToRead))
            {
                string[] keys = readFile.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (string key in keys)
                {
                    wordsCounter.Add(key, 0);
                }
            }

            pathToRead = Path.Combine("data", "text.txt");
            using (StreamReader readFile = new StreamReader(pathToRead))
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

            string pathToWrite = Path.Combine("data", "output.txt");
            using (StreamWriter writeToFile = new StreamWriter(pathToWrite))
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
