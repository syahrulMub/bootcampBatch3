class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = a;
        b = 2;
        Console.WriteLine(a);
        Console.WriteLine(b);
        //class Parent 
        Parent P = new Parent(5);
        Parent C = P;
        C.x = 2;
        Console.WriteLine(P.x);
        Console.WriteLine(C.x);

        MyClass obj1 = new MyClass(10);
        obj1.value = 10;

        MyClass obj2 = obj1;
        obj2.value = 20;
        Console.WriteLine(obj1.value);
        Console.WriteLine(obj2.value);

        MyStruct obj3 = new MyStruct(10);
        obj3.value = 10;
        
        MyStruct obj4 = obj3;
        obj4.value = 20;
        Console.WriteLine(obj3.value);
        Console.WriteLine(obj4.value);
    }
}

class Parent
{
    public int x;
    public Parent(int x)
    {
        this.x = x;
    }
}

public class MyClass
{
    public int value;
    public MyClass(int value)
    {
        this.value = value;
    }

}

public struct MyStruct
{
    public int value;
    public MyStruct(int value)
    {
        this.value = value;
    }
}