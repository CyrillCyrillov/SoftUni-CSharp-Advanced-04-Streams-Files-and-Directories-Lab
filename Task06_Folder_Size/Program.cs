using System;
using System.IO;

namespace Task06_Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToRead = Path.Combine("data", "TestFolder");

            var filesInfo = Directory.GetFiles(pathToRead); // string[] fileInfo = ...

            double allFilesSize = 0;

            foreach (string file in filesInfo)
            {
                var curentMetaDatas = new FileInfo(file);
                allFilesSize += curentMetaDatas.Length;
            }

            string pathToWrite = Path.Combine("data", "Output.txt");

            File.WriteAllText(pathToWrite, (allFilesSize / 1024 / 1024).ToString());

            //Console.WriteLine(allFilesSize / 1024 / 1024);
        }
    }
}
