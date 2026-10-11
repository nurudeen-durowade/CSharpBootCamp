using System;


class Program
{
    static void Main()
    {
        // Suppose a customer wants to transfer ₦10,000. The account must be active, and the balance must be sufficient.
        bool isAccountActive = true;

        int accountBalance = 5000;

        int transferAmount = 10000;

        if(isAccountActive && accountBalance >= transferAmount)
        {
            Console.WriteLine("Transfer approved.");
        }
        else
        {
            Console.WriteLine("Transfer rejected. Please check your account status and balance.");
        }


        bool isAdmin = false;

        bool isSupportStaff = true;

        if(isAdmin || isSupportStaff)
        {
            Console.WriteLine("Access granted to the system.");
        }
        else
        {
            Console.WriteLine("Access denied. You do not have the necessary permissions.");
        }


        bool isAccountBlocked = false;

        if(!isAccountBlocked)
        {
            Console.WriteLine("Account is active and not blocked.");
        }
        else
        {
            Console.WriteLine("Account is blocked. Please contact support.");
        }

        if (isAccountActive && !isAccountBlocked && accountBalance >= transferAmount)
        {
            Console.WriteLine("You can proceed with your transactions.");
        }
        else
        {
            Console.WriteLine("You cannot proceed with transactions. Please check your account status.");
        }

        //short-circuit evaluation is used in the above conditions. If the first condition is false, the second condition will not be evaluated, which can improve performance and prevent potential errors.


        int transactionAmount = 50000;


        if (transactionAmount < 10000)
        {
            Console.WriteLine("Low Value.");
        }
        else if (transactionAmount <= 100000)
        {
            Console.WriteLine("Medium Value.");
        }
        else
        {
            Console.WriteLine("High Value.");
        }
    }
}