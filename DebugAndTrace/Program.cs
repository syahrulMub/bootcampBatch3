using system.Diagnostics;
using System.IO;

class Program 
{
    static void Main(string[] args)
    {
        int a  = 5 , b = 9;
        
        Debug.WriteLine("Running Program ");
        Debug.WriteLine("x = " + a);
        Debug.WriteLine("y = " + b);

        debug.WriteLine(" ");

        Trace.WriteLine("Calculater number ");
        int sum = a + b;
        Trace.WriteLine("x + y = " + sum);
        


    }
}