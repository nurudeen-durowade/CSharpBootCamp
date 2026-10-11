using System;

class Program
{
    static void Main()
    {


    int accountBalance = 5000;

        if (accountBalance >= 10000)
        {
            Console.WriteLine("Withdrawal approved");
        }
        else if (accountBalance >= 5000)
        {
            Console.WriteLine("Withdrawal approved with a fee");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }

    }
}