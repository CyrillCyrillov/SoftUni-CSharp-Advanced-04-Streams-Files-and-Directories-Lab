using System;
using System.IO;

namespace Task02_Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader readFromFile = new StreamReader(@"..\..\..\Input.txt")) // or absolute path: @"C:\_Home\Soft_Uni\Advanced_C#\04_Resources\02. Line Numbers\Input.txt"
            {
                using (StreamWriter writeToFile = new StreamWriter(@"..\..\..\Output.txt"))  // or absolute path: @"C:\_Home\Soft_Uni\Advanced_C#\04_Resources\02. Line Numbers\Output.txt"
                {
                    int lineNumber = 0;
                    while (true)
                    {
                        string nextLine = readFromFile.ReadLine();
                        if(nextLine == null)
                        {
                            break;
                        }

                        lineNumber++;

                        //Console.WriteLine($"{lineNumber}. {nextLine}");
                        writeToFile.WriteLine($"{lineNumber}. {nextLine}");
                        
                    }
                }
            }
            
            //Console.WriteLine("Hello World!");
        }
    }
}
