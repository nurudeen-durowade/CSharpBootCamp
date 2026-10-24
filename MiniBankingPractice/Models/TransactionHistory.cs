using System.Collections.Generic;

namespace MiniBankingPractice.Models;

public class TransactionHistory
{
    private List<Transaction> _transactions = [];

public void AddTransaction(Transaction transaction)
{
    _transactions.Add(transaction);
}

public IReadOnlyList<Transaction> GetTransactions()
{
    return _transactions.AsReadOnly();
}


}