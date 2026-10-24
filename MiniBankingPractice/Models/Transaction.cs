using System;

namespace MiniBankingPractice.Models;

public class Transaction
{
    public string Type { get; private set;}
    public decimal Amount { get; private set;}
    public DateTime CreatedAt { get;}
    

    public Transaction(string type, decimal amount)
    {
        Type = type;
        Amount = amount;
        CreatedAt = DateTime.Now;   
    }
}