
using MiniBankingPractice.Models;

//BankAccount Object Creation
BankAccount account = new BankAccount("Gracey", 10000m);


BankAccount lona = new BankAccount("Amina", 20000m);


List<string> customers = ["Gracey", "Amina", "Lona"];


Console.WriteLine($"Number of customers: {customers.Count}");

customers.Add("David");

Console.WriteLine($"Count after Adding David {customers.Count}");

customers.Remove("Amina");



Console.WriteLine($"First customer {customers[0]}");

foreach(var customer in customers)
{
Console.WriteLine(customer);

}


Console.WriteLine($"Count after removing Amina {customers.Count}");

customers.RemoveAt(1);

foreach(var customer in customers)
{
    Console.WriteLine(customer);
}

Dictionary<int, string> customersList = new()
{
    [1002] = "Biodun",
    [1003] = "Chidi",
    [1004] = "Efe"
};

customersList.Add(1005, "Femi");
Console.WriteLine(customersList[1002]);




try
{
    BankAccount InvalidAccount = new BankAccount(" ", 0);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Account creation failed: {ex.Message}");
}

lona.Deposit(300m);

try
{
    lona.Withdraw(25000m);
}
catch (ArgumentOutOfRangeException ex)
{
    
    Console.WriteLine($"Withdrawal Failed: {ex.Message}");
}


Console.WriteLine($"Balance after withdrawal: {lona.Balance}");

Console.WriteLine($"Transaction Count: {lona.History.GetTransactions().Count}");

IReadOnlyList<Transaction> transactions = lona.History.GetTransactions();

Console.WriteLine($"Before Count: {transactions.Count}");

// List<Transaction> editableTransaction = (List<Transaction>)transactions;

// editableTransaction.Clear();

Console.WriteLine($"After Count: {transactions.Count}");

foreach (Transaction transaction in lona.History.GetTransactions())
{
    Console.WriteLine($"Transaction Type is {transaction.Type}, Amount is {transaction.Amount} and the Date is {transaction.CreatedAt}");
}


// account.Deposit(2000m);
// account.Deposit(500m);

// Console.WriteLine($"Account holder: {account.AccountHolder}");
// Console.WriteLine($"Balance: {account.Balance}");
// Console.WriteLine($"Transaction count: {account.History.GetTransactions().Count}");


// foreach(Transaction transaction in account.History.GetTransactions())
// {
//     Console.WriteLine($"Transaction Type is {transaction.Type}, Amount is {transaction.Amount} and the Date is {transaction.CreatedAt}");
// }

// Console.WriteLine($"Opening Balance: {account.Balance}");

//Transaction Object Creation

// Transaction depositTransaction = new Transaction("Deposit", 500m);
// Console.WriteLine($"Transaction Created: {depositTransaction.Type} of amount {depositTransaction.Amount} at {depositTransaction.CreatedAt}");


// try
// {
//     account.Deposit(-500m);
//     Console.WriteLine($"Balance after deposit: {account.Balance}");
// }
// catch (ArgumentOutOfRangeException ex)
// {
    
//    Console.WriteLine($"Desposit Failed: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine($"Final Balance: {account.Balance}");
// }

