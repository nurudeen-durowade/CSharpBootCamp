using System;
using System.Collections.Generic;
namespace ClassesAndObj.Models;

public class TransactionHistory 
{
    // Private list to store all transactions in the history

    private readonly List<Transaction> transactions = [];

    public void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
    }


    public List<Transaction> GetTransactions()
    {
        return transactions;
    }

    // Method to get all transactions in the history
    // public List<Transaction> GetTransactions()
    // {
    //     return transactions;
    // }
}