using System;

namespace MiniBankingPractice.Models;

public class Transaction
{
    public Guid Id { get; } = Guid.NewGuid();
    public TransactionType Type { get; private set; }
    public decimal Amount { get; private set; }
    public DateTime CreatedAt { get; }


    public Transaction(TransactionType type, decimal amount)
    {
        if (!Enum.IsDefined(typeof(TransactionType), type))
        {
            throw new ArgumentException("Invalid transaction type", nameof(type));
        }
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Transaction amount must be positive");
        }
        Type = type;
        Amount = amount;
        CreatedAt = DateTime.UtcNow;
    }

    public static string GetTransactionStatus(decimal amount)
    {
        return amount switch
        {
            <= 0 => "Invalid",
            > 0 and < 1000 => "Small",
            >= 1000 and <= 50000 => "Medium",
            > 50000 => "Large",

        };
    }
    public  static (bool Success, decimal Balance, int TransactionCount) GetAccountSummary(BankAccount? account)
    {
        if (account == null)
        {
            return (false, 0m, 0);
        }
       
            return (true, account.Balance, account.History.GetTransactions().Count);
        
    }

    public static string ClassifyTransaction(Transaction? transaction)
    {
        return transaction switch
        {
            null => "Missing Transaction",
            { Type: TransactionType.Deposit, Amount: > 0 } => "Valid Deposit",
            { Type: TransactionType.Withdrawal, Amount: > 0 } => "Valid Withdrawal",
            { Amount: <= 0 } => "Invalid Amount",
            _ => "Unknown Transaction"
        };
    }


    public static string EvaluateWithdrawal(Transaction? transaction)
    {
        return transaction switch
        {
            null => "Missing Transaction",
            { Type: not TransactionType.Withdrawal } => "Invalid Transaction Type",
            { Amount: <= 0 } => "Invalid Amount",
            { Type: TransactionType.Withdrawal, Amount: > 0 and <= 50000 } => "Approved",
            { Type: TransactionType.Withdrawal, Amount: > 50000 and <= 200000 } => "Requires Manual Review",
            { Type: TransactionType.Withdrawal, Amount: > 200000 } => "Exceeds withdrawal limit",


        };
    }

        public static IEnumerable<Transaction> GetDeposit(IEnumerable<Transaction> transactions)
    {

        foreach(var transaction in transactions)
        {
            if(transaction.Type == TransactionType.Deposit)
                yield return transaction;
        }

        
    }

    public static string GetTransactionDescription(TransactionType type)
    {
        return type switch
        {
            TransactionType.Deposit => "Money added to your account",
            TransactionType.Withdrawal => "Money removed from your account",
            TransactionType.Transfer => "Money sent to another account",
            _ => "Unknown Transaction"

        };
    }
}