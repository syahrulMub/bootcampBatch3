using System;
using System.Diagnostics;
namespace GarbageCollectionDemo
{
    class Program
    {

        public static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for ( int i = 0; i < 10000; i++ )
            {
                ObjectGenerator();
            }
            timer.Stop();
            Console.WriteLine("Elapsed time: " + timer.Elapsed);
        }

        public static void ObjectGenerator()
        {
            Player1 player1 = new Player1();
            player1.Dispose();
        }
    }

    public class Player1 : IDisposable
    {
        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if ( !disposedValue)
            {
                if (disposing)
                {

                }
            disposedValue = true;
            }
        }
        ~Player1()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
