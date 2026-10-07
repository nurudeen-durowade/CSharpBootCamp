using System;

class Program
{
    static void Main(string[] args)
    {
        string myName = "     John Doe.  ";

        Console.WriteLine($"[{myName}]");

        string trimmedName = myName.TrimStart();

        Console.WriteLine($"[{trimmedName}]");
    }
}