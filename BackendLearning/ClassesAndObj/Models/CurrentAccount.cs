namespace ClassesAndObj.Models;

public class CurrentAccount : BankAccount, IMonthlyFeeCalculator
{
    public CurrentAccount(string accountHolder, decimal initialBalance)
        : base(accountHolder, initialBalance)
    {
    }

    public override decimal CalculateMonthlyFee()
    {
        return 1000m; // Example monthly fee for a current account.
    }


}