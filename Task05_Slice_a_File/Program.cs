using System;
using System.Collections.Generic;
using System.IO;


namespace Task05_Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fileNames = new List<string> { "Part-1.txt", "Part-2.txt", "Part-3.txt", "Part-4.txt" };

            using (var readFromFile = new FileStream(@"..\..\..\sliceMe.txt", FileMode.Open))
            {
                int partsSlice = 4;
                long everyPieceSize = (long)Math.Ceiling((double)readFromFile.Length / partsSlice);

                for (int i = 0; i < partsSlice; i++)
                {
                    long curentPieceSize = 0;

                    using (var writeToFile = new FileStream(@$"..\..\..\equal_parts\{fileNames[i]}", FileMode.Create))
                    {
                        byte[] bufer = new byte[4096];
                        while (readFromFile.Read(bufer, 0, bufer.Length) == bufer.Length)
                        {
                            curentPieceSize += bufer.Length;
                            writeToFile.Write(bufer, 0, bufer.Length);
                            if(curentPieceSize >= everyPieceSize)
                            {
                                break;
                            }
                        }


                    }
                }

            }

            //Console.WriteLine("Hello World!");
        }
    }
}
