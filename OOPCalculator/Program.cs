using OOPCalculator;
using System;

var calculator = new Calculator();

Console.WriteLine("=== OOP Calculator ===");
Console.WriteLine("Type 'exit' at any prompt to quit.");

try
{
    while (true)
    {
        Console.Write("Enter Operation (add, sub, mul, div): ");
        string operation = Console.ReadLine();
        if (operation.Equals("exit", StringComparison.OrdinalIgnoreCase))
            break;

        Console.Write("Enter 1st number: ");
        string inputA = Console.ReadLine();
        if (inputA.Equals("exit", StringComparison.OrdinalIgnoreCase))
            break;

        Console.Write("Enter 2nd number: ");
        string inputB = Console.ReadLine();
        if (inputB.Equals("exit", StringComparison.OrdinalIgnoreCase))
            break;

        double a = Convert.ToDouble(inputA);
        double b = Convert.ToDouble(inputB);

        double result = calculator.Calculate(operation, a, b);
        Console.WriteLine($"Result: {result}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine("Goodbye!");