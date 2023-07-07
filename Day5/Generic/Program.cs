using System;

class MyInt<T>
{
    private T _value;
    public MyInt(T value)
    {
        _value = value;
    }
    public T GetValue() { return _value; }
}

class MyString<T>
{
    private T _value;
    public MyString(T value)
    {
        _value = value;
    }
    public T GetValue() { return _value; }
}

class MyGeneric<T1, T2>
{
    private T1 _value1;
    private T2 _value2;
    public MyGeneric(T1 value1, T2 value2)
    {
        _value1 = value1;
        _value2 = value2;
    }
    public T1 GetValue1() { return _value1; }
    public T2 GetValue2() { return _value2; }

    public void PrintInt(T1 value1)
    {
        Console.WriteLine(value1);
    }
    public void PrintString(T2 value2)
    {
        Console.WriteLine(value2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyInt<int> myInt = new MyInt<int>(10);
        Console.WriteLine(myInt.GetValue());
        
        MyString<string> myString = new MyString<string>("Hello");
        Console.WriteLine(myString.GetValue());

        int a = 60;
        string pernyataan = "Besok libur";
        double Phi = 3.14159;

        PrintValue(a);
        PrintValue(pernyataan);
        PrintValue(Phi);

        MyGeneric<int, string> myGeneric = new MyGeneric<int, string>(1, "besok");
        myGeneric.PrintInt(myGeneric.GetValue1());
        myGeneric.PrintString(myGeneric.GetValue2());

        Console.ReadLine();
    }

    static void PrintValue<T>(T value)
    {
        Console.WriteLine(value);
    }
}
