
namespace ClassesAndObj.Models;

public class BankAccount
{
    public string AccountHolder;
    private decimal balance;

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        AccountHolder = accountHolder;
        balance = initialBalance;
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Balance: {balance}");
    }
}
