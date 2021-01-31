using System;
using System.IO;

namespace Task01_Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToRead = Path.Combine("data", "Input.txt");
            string pathToWrite = Path.Combine("data", "Output.txt");
            
            using (StreamReader readFromFile = new StreamReader(pathToRead))
            {
                using (StreamWriter writeToFile = new StreamWriter(pathToWrite)) 
                {
                    int rowcount = -1;

                    while (true)
                    {
                        string nextLine = readFromFile.ReadLine();
                        if (nextLine == null)
                        {
                            break;
                        }

                        rowcount++;

                        if (rowcount % 2 != 0)
                        {
                            Console.WriteLine(nextLine);
                            writeToFile.WriteLine(nextLine);
                        }
                    }
                }
                
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
