using System;
namespace ClassesAndObj.Models;

//One important detail: a class can inherit from only one class directly, but it can implement multiple interfaces.
public class SavingsAccount : BankAccount, IMonthlyFeeCalculator
{
    public SavingsAccount(string accountHolder, decimal initialBalance):
    base(accountHolder, initialBalance)
    {

    }
public void ApplyInterest(decimal interestRate)
    {
        if(interestRate <= 0)
        {
            Console.WriteLine("Interest rate must be positive.");
            return;
        }
        Balance += Balance * interestRate;
    }

public override decimal CalculateMonthlyFee()
    {
        return 500m; // Example monthly fee for a savings account.
    }

}