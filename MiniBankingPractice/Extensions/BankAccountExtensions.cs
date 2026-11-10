using System;
using MiniBankingPractice.Models;

namespace MiniBankingPractice.Extensions;


public static class BankAccountExtensions
{
    public static bool HasSufficientBalance(this BankAccount account, decimal amount)
    {
        if (account == null)
        {
            ArgumentNullException.ThrowIfNull(account);
        }
        return amount > 0 && account.Balance >= amount;
    }

    public static string GetFormattedBalance(this BankAccount account)
    {
        return $"NGN {account.Balance:N2}";
    }

    public static bool IsHighValueAccount(this BankAccount account)
    {
        return account.Balance >= 1000000m;

    }

    public static int GetTotalTransactions(this BankAccount account)
    {
        return account.History.GetTransactions().Count;
    }

    public static IEnumerable<Transaction> GetLargeTransactions(this BankAccount account, decimal minimalAmount)
    {
        ArgumentNullException.ThrowIfNull(account);
        //IList<Transaction> tran =  [];

        foreach (var transaction in account.History.GetTransactions())
        {
            if (transaction.Amount >= minimalAmount)
            {
                //tran.Add(transaction);
                yield return transaction;
            }
        }
        //return tran;
    }
}