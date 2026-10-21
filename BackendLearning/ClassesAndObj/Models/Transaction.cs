using System;
namespace ClassesAndObj.Models;

public class Transaction
{
    public string Description {get;}

    public decimal Amount {get;}

    public DateTime TransactionDate {get;}

    public Transaction(string description, decimal amount)
    {
        Description = description;
        Amount = amount;
        TransactionDate = DateTime.UtcNow;
    }
}