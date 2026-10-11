using System;

class Program
{
    static void Main(string[] args)
    {
      
        Greet();

        GreetCustomer("Jonathan");

        decimal total = CalculateTotaldebit(amount:1000m, charges:30m);

        Console.WriteLine(total);

        decimal balance = 5000m;

        decimal amount = 10000m;

        bool canTransfer = HasSufficientBalance(balance, amount);


       string  message = canTransfer switch
       {
           true => "Customer can transfer the amount.",
           false => "Customer cannot transfer the amount."
       };
       Console.WriteLine(message);
        
    }

      // Method Declaration/Signature
        static void Greet()
        {
            Console.WriteLine("Welcome to the Banking Application!");
        }

        static void GreetCustomer(string name)
    {
        Console.WriteLine($"Welcome {name}, how are you doing today");
    }

    // Calculate total debit.

    static decimal CalculateTotaldebit(decimal amount, decimal charges)
    {
        return amount + charges;

    }

    static bool HasSufficientBalance(decimal balance, decimal amount)
    {
        return balance >= amount;
    }

    
}
