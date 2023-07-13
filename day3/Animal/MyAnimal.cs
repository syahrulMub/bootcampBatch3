using System;
namespace MyAnimal;
class Animal
{
    public string? name { get; set; }
    public int? age { get; set; }

    public void GetInfo()
    {
        Console.WriteLine("Nama : " + name);
        Console.WriteLine("Umur : " + age);
    }
    public string Eat(string makanan)
    {
        return $"{name} makanannya adalah {makanan}";
    }

}
class Cat : Animal
{
    public string catSound = "Meow";
    public void CatSound()
    {
        Console.WriteLine(name + " sound : " + catSound);
    }
}

class Bird : Animal
{
    public string birdSound = "Assalamualaikum";
    public void BirdSound()
    {
    Console.WriteLine(name + " sound : " + birdSound );
    }
}
