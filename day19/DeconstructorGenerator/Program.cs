using System;
using System.Diagnostics;

namespace GarbageCollectionDemo;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        Console.ReadLine();
    }

    static void ObjectGenerator()
    {
        MyClass1 obj1 = new MyClass1();
        MyClass2 obj2 = new MyClass2();
    }
}
public class MyClass1
{
    ~MyClass1()
    {

    }
}

public class MyClass2
{
    ~MyClass2()
    {

    }
}