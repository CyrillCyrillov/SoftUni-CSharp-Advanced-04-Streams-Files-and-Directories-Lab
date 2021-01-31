using System;
using System.IO;

namespace Task04_Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writeToFile = new StreamWriter(@"..\..\..\output.txt"))
            {
                using (StreamReader readFromFileOne = new StreamReader(@"..\..\..\FileOne.txt"))
                {
                    using (StreamReader readFromFileTwo = new StreamReader(@"..\..\..\FileTwo.txt"))
                    {
                        while (true)
                        {
                            string nextLineOne = readFromFileOne.ReadLine();
                            string nextLineTwo = readFromFileTwo.ReadLine();
                            if (nextLineOne == null && nextLineTwo == null)
                            {
                                break;
                            }

                            if(nextLineOne != null)
                            {
                                writeToFile.WriteLine(nextLineOne);
                                //Console.WriteLine(nextLineOne);
                            }

                            if (nextLineTwo != null)
                            {
                                writeToFile.WriteLine(nextLineTwo);
                                //Console.WriteLine(nextLineTwo);
                            }
                        }
                    }
                }
            }
            
            //Console.WriteLine("Hello World!");
        }
    }
}
