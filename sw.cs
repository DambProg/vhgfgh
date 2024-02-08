using System;

public class Main
{
	public Main(string[] args)
	{
		Console.WriteLine("Введите А:");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Введите B:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((a+b) + "\n" + (a - b) + "\n" + (a / b) + "\n" + (a * b) + "\n")
	}
}

