using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    internal class Program
    {
        class FileHandler
        {
            public void WriteToFile(string fileName, string content)
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(content);
                }
            }
            public string ReadFromFile(string fileName)
            {
                using(StreamReader reader = new StreamReader(fileName)) 
                    return reader.ReadToEnd();
            }

            public void AppendFile(string fileName, string content)
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    writer.WriteLine(content);
                }
            }
        }

        static void Main(string[] args)
        {
            FileHandler fileHandler = new FileHandler();

            //Write file
            string filename = "example.txt";
            fileHandler.WriteToFile(filename, "This is the first line");

            //Read from file
            string content = fileHandler.ReadFromFile(filename);
            Console.WriteLine("File content after writing");
            Console.WriteLine(content);

            //Append fiel
            fileHandler.AppendFile(filename, "This is append line");

            //Read file again
            content = fileHandler.ReadFromFile(filename);
            Console.WriteLine("File content after Appending");
            Console.WriteLine(content);

        }
    }
}
