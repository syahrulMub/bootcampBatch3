using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> myStack = new Stack<string>();

        // Menambahkan elemen ke dalam stack
        myStack.Push("apel");
        myStack.Push("pisang");
        myStack.Push("jeruk");

        // Menghapus elemen teratas dari stack
        string removedItem = myStack.Pop();
        Console.WriteLine($"Elemen teratas yang dihapus: {removedItem}");

        // Menambahkan elemen baru
        myStack.Push("mangga");

        // Menampilkan isi stack
        Console.WriteLine("Isi stack saat ini:");
        foreach (var item in myStack)
        {
            Console.WriteLine(item);
        }
    }
}