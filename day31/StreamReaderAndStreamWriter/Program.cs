using System;
using System.IO;

namespace WriteRead
{
    class Program
    {
        static void Main()
        {
            string path = @"..\..\bootcampBatch3\";

            if (Directory.Exists(path))
            {
                Console.WriteLine("Exists: " + path);
            }
            else
            {
                Console.WriteLine("Does not exist: " + path);
            }
            string pathText = "example4.txt";
            using ( FileStream fs = new FileStream(pathText, FileMode.OpenOrCreate))
            {
                fs.Close();
                Console.WriteLine("new file created or open: " + pathText);
            }

            using ( StreamWriter writer = new StreamWriter(File.Open(pathText, FileMode.Append)))
            {
                writer.WriteLine("this is text from StreamWriter 4");
                writer.WriteLine("lets have a good learn path 4");
            }

            using (StreamReader reader = new StreamReader(File.Open(pathText, FileMode.Open)))
            {
                    foreach (var line in reader.ReadToEnd())
                    {
                        Console.Write(line);
                    }
            }
        }
    }
}