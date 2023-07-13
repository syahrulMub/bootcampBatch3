﻿using System;
using MyAnimal;

class Program
{
	public static void Main(string[] args)
	{
		//membuat objek baru dari class child
		Cat Leo = new Cat();
		Bird Jago = new Bird();

		//membuat properti child dari parent
		Leo.name = "Leo";
		Leo.age = 2;
		Jago.name = "Jago";
		Jago.age = 1;

		//fungsi untuk memanggil deskripsi
		 Leo.GetInfo();
		 Leo.CatSound();
		 Console.WriteLine(Leo.Eat("wiskas"));
		 Jago.GetInfo();
		 Jago.BirdSound();
		 Console.WriteLine(Jago.Eat("biji-biji"));



	}
}