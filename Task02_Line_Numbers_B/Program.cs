using System;
using System.IO;

namespace Task02_Line_Numbers_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToRead = Path.Combine("data", "Input.txt");
            string pathToWrite = Path.Combine("data", "Output.txt");

            var lines = File.ReadAllLines(pathToRead); //string[] lines .... 

            int lineNumber = 1;
            string[] numberedLines = new string[lines.Length];
            
            foreach (string line in lines)
            {
                numberedLines[lineNumber - 1] = $"{lineNumber}. {line}";
                //Console.WriteLine(numberedLines[lineNumber - 1]);
                lineNumber++;
            }

            File.WriteAllLines(pathToWrite, numberedLines);
            
            //Console.WriteLine("Hello World!");
        }
    }
}
