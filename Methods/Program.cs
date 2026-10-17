using System;

class Program
{
    static void Main(string[] args)
    {
      
        Greet();

        GreetCustomer("Jonathan");

        GreetMyCustomer();
        GreetMyCustomer("Ada");

        SendTransfer("1234567890");
        SendTransfer("1234567890", 500m);

        CreateTransfer(sourceAccount: "1234567890", destinationAccount: "0987654321", amount: 500m);



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

    //optional parameter example

    static void GreetMyCustomer(string name = "Customer")
    {
        Console.WriteLine($"Welcome {name}, how are you doing today");
    }

static void SendTransfer(string accountnumber, decimal amount = 100m)
    {
        Console.WriteLine($"Account:{accountnumber}) Amount:{amount}");


    }

    // Named Arguments Example

static void CreateTransfer(string sourceAccount, string destinationAccount, decimal amount)
{
    Console.WriteLine($"Transfer from {sourceAccount} to {destinationAccount} of amount {amount}");
}
    
}
