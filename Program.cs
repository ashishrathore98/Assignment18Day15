using Assignment18Day15;
using System;

class Program
{
    static void Main()
    {
        Smartphone smartphone = new Smartphone();
        smartphone.Connect();
        smartphone.Charge(120);
        Console.WriteLine($"Smartphone connected: {smartphone.Connect()}");
        Console.WriteLine($"Smartphone Battery Level: {smartphone.BatteryLevel}");
        Console.WriteLine(smartphone.Display());

        Console.WriteLine();

        Laptop laptop = new Laptop();
        laptop.Connect();
        laptop.Charge(60);
        Console.WriteLine($"Laptop connected: {laptop.Connect()}");
        Console.WriteLine($"Laptop Battery Level: {laptop.BatteryLevel}");
        Console.WriteLine(laptop.Display());
    }
}