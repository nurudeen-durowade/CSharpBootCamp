namespace MiniBankingPractice.Models;

public class InsufficientFundsException(string message): Exception(message)
{
    public decimal RequestedAmount { get; }

    public decimal AvailableBalance { get; }

    public decimal Shortfall => RequestedAmount - AvailableBalance;

    public InsufficientFundsException(decimal requestedAmount, decimal availableBalance):
    this("Insufficient funds for the requested transaction")
    {
        RequestedAmount = requestedAmount;
        AvailableBalance = availableBalance;
    }


}