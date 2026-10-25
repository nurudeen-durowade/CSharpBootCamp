
using MiniBankingPractice.Models;

//BankAccount Object Creation
// BankAccount account = new BankAccount("Gracey", 10000m);


// BankAccount lona = new BankAccount("Amina", 20000m);


// List<string> customers = ["Gracey", "Amina", "Lona"];


// Console.WriteLine($"Number of customers: {customers.Count}");

// customers.Add("David");

// Console.WriteLine($"Count after Adding David {customers.Count}");

// customers.Remove("Amina");



// Console.WriteLine($"First customer {customers[0]}");

// foreach(var customer in customers)
// {
// Console.WriteLine(customer);

// }


// Console.WriteLine($"Count after removing Amina {customers.Count}");

// customers.RemoveAt(1);

// foreach(var customer in customers)
// {
//     Console.WriteLine(customer);
// }

HashSet<int> numbers = [1002, 1003, 1005, 1006, 1008, 1200];


bool firstAttempt = numbers.Add(1002);
bool secondAttempt = numbers.Add(1009);

Console.WriteLine(firstAttempt);
Console.WriteLine(secondAttempt);

Console.WriteLine(numbers.Count);

bool isExist = numbers.Contains(1);

Console.WriteLine($"It Exist: {isExist}");




// Dictionary<int, BankAccount> accounts = new()
// {
//     [1002] =  new BankAccount("Biodun", 5000m),
//     [1003] = new BankAccount("Chidi", 7000m),
//     [1004] = new BankAccount("Efe", 6000m),
//     [1005] = new BankAccount("Femi", 4000m),
//     [1006] = new BankAccount("Grace", 3000m),
//     [1007] = new BankAccount("Hakeem", 2000m)
// };

// Console.WriteLine(accounts[1002].AccountHolder);

// Console.WriteLine("Enter account number: ");
// string? userInputAccount = Console.ReadLine();


// if(int.TryParse(userInputAccount, out int accountNumber))
// {
//    if (accounts.TryGetValue(accountNumber, out BankAccount? account))
//     {
//         Console.WriteLine($"Account Holder: {account.AccountHolder}");
//         Console.WriteLine($"Account Balance: {account.Balance}");
//     }
//     else
//     {
//         Console.WriteLine("Account not found");
//     }
// }
// else
// {
//     Console.WriteLine("Please enter a valide Numeric Account Number");
// }

// Console.WriteLine("Enter a new Account Number");
// string? newAccountInput = Console.ReadLine();

// if (int.TryParse(newAccountInput, out int newAccountNumber))
// {

//     if (accounts.ContainsKey(newAccountNumber))
//     {
//         Console.WriteLine("Account number already exists");
//     }
//     else
//     {
//         Console.Write("Enter account holder's name: ");
//         string? userName = Console.ReadLine();

//         Console.Write("Enter opening balance: ");
//         string? balance = Console.ReadLine();

//         if (string.IsNullOrWhiteSpace(userName))
//         {
//             Console.WriteLine("Account Holder name is required");
//             return;
//         }

//         else if (!decimal.TryParse(balance, out decimal OpeningBalance))
//         {
//             Console.WriteLine("Please enter a valid opening balance");
//             return;
//         }

//         else if (OpeningBalance < 0)
//         {
//             Console.WriteLine("Opening balance cannot be negative");
//             return;
//         }
//         else
//         {
//             accounts.Add(newAccountNumber, new BankAccount(userName, OpeningBalance));
//             Console.WriteLine("Account successfully created");
//         }
        
//     }
    

// }
// else
// {
//     Console.WriteLine("Please enter a valid numeric account number");
// }

// Dictionary<int, string> customersList = new()
// {
//     [1002] = "Biodun",
//     [1003] = "Chidi",
//     [1004] = "Efe"
// };

// customersList.Add(1005, "Femi");


// //check if key exists
// bool exist = customersList.ContainsKey(1002);


// Console.WriteLine(customersList[1002]);

// //try get value safely without risking a missing key exception

// if (customersList.TryGetValue(1008, out string? customerName))
// {
//     Console.WriteLine(customerName);
// }

// customersList.Remove(1003);




// try
// {
//     BankAccount InvalidAccount = new BankAccount(" ", 0);
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Account creation failed: {ex.Message}");
// }

// lona.Deposit(300m);

// try
// {
//     lona.Withdraw(25000m);
// }
// catch (ArgumentOutOfRangeException ex)
// {
    
//     Console.WriteLine($"Withdrawal Failed: {ex.Message}");
// }


// Console.WriteLine($"Balance after withdrawal: {lona.Balance}");

// Console.WriteLine($"Transaction Count: {lona.History.GetTransactions().Count}");

// IReadOnlyList<Transaction> transactions = lona.History.GetTransactions();

// Console.WriteLine($"Before Count: {transactions.Count}");

// // List<Transaction> editableTransaction = (List<Transaction>)transactions;

// // editableTransaction.Clear();

// Console.WriteLine($"After Count: {transactions.Count}");

// foreach (Transaction transaction in lona.History.GetTransactions())
// {
//     Console.WriteLine($"Transaction Type is {transaction.Type}, Amount is {transaction.Amount} and the Date is {transaction.CreatedAt}");
// }


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

