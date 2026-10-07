using System;


class Program
{
    static void Main()
    {
        string greetings = "Hello, World!";

        Console.WriteLine(greetings);

        greetings = greetings.Replace("World", "C#");
        greetings = greetings.Replace("Hello", "Greetings");
        Console.WriteLine(greetings);

        greetings = greetings.ToUpper();
        Console.WriteLine(greetings);

        greetings = greetings.ToLower();
        Console.WriteLine(greetings);
    }
}