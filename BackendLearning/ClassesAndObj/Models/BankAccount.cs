
namespace ClassesAndObj.Models;

public abstract class BankAccount 
{
    //private string _internalCode = "BANK-035";
    public string AccountHolder { get; private set; }

    public decimal Balance { get; protected set; }

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(initialBalance),
                "Initial balance cannot be negative.");
        }

        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit must be positive.");
            return;
        }

        Balance += amount;
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Balance: {Balance}");
    }

//Polymorphic method to calculate the monthly fee for the account.
    public virtual decimal CalculateMonthlyFee()
    {
        return 0m; // Default monthly fee is 0 for a generic bank account.
    }
}
