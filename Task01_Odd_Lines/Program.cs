using System;
using System.IO;

namespace Task01_Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamReader readFromFile = new StreamReader(@"..\..\..\Input.txt")) // or absolute path: @"C:\_Home\Soft_Uni\Advanced_C#\04_Resources\01. Odd Lines\Input.txt"
            {
                using (StreamWriter writeToFile = new StreamWriter(@"..\..\..\Output.txt")) //or absolute path: @"C:\_Home\Soft_Uni\Advanced_C#\04_Resources\01. Odd Lines\Output.txt"
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
