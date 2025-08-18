using OOPCalculator;
using System;

var calculator = new Calculator();

Console.WriteLine("=== OOP Calculator ===");

try
{
    while (true)
    {
        Console.Write("Enter Operation (add, sub, mul, div): ");
        string operation = Console.ReadLine();

        Console.Write("Enter 1st number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter 2nd number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = calculator.Calculate(operation, a, b);
        Console.WriteLine($"Result: {result}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Result:{ex.Message}");
}