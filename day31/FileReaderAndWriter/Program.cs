using System.IO;
using System.Security.AccessControl;
using System.Text;

class Program
{
    static void Main()
    {
        string path = @"example3.txt";

        using (FileStream fs = new FileStream(path, FileMode.Create))
        {
            byte[] data = Encoding.UTF8.GetBytes("this is example for create file add read and write for using file");
            fs.Write(data, 0, data.Length);
        }

        //open file fore reading the text
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            byte [] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            string content = Encoding.UTF8.GetString(buffer);
            Console.WriteLine(content);
        }
    }
}