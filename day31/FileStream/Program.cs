using System.IO;

class Program
{
    static void Main()
    {
        string path = @"C:\day31\";
        Directory.CreateDirectory(path);
        if (Directory.Exists(path))
        {
            Console.WriteLine("Directory exists");
        }
        else
        {
            Console.WriteLine("Directory does not exists");
        }

        // string filePath = Path.Combine(path, "example1.txt");
        // File.WriteAllText(filePath, "is false are input tp example?");

        string FilePath = @".\example2.txt";
        using (FileStream fileStream = new FileStream(FilePath, FileMode.Create))
        {
            fileStream.Close();
            Console.WriteLine("file has been created, with name '{0}'", FilePath);
        }
    }
}