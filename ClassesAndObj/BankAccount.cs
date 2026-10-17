using System;

public class BankAccount
{
    public string AccountHolder;
    

    private decimal Balance;

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Balance: {Balance}");
    }
}