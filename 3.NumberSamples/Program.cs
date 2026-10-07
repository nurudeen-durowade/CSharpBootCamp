using System;

class Program
{
    static void Main(string[] args)
    {
      decimal min = decimal.MinValue;
      decimal max = decimal.MaxValue;

        Console.WriteLine($"The minimum value of decimal is: {min}");
        Console.WriteLine($"The maximum value of decimal is: {max}");


        double a = 1.0;

        double b = 3.0;

        Console.WriteLine($"The result of {a} divided by {b} is: {a / b}");


        decimal c = 1.0m;
        decimal d = 3.0m;

        Console.WriteLine($"The result of {c} divided by {d} is: {c / d}");
    }
}
