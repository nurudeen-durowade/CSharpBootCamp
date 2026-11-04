
using MiniBankingPractice.Models;

//BankAccount Object Creation
BankAccount account = new("Gracey", 100000m)
{
    AccountNickname = "Emergency Fund"
};

Console.WriteLine($"Account Display Name: {account.GetAccountDisplayName()}");
Console.WriteLine($"Opening Balance {account.Balance:N2}");
Console.WriteLine($"\nProcessing withdrawals...\n");

// try
// {
//     account.Withdraw(30000m);
//     account.Withdraw(90000m);

//     account.History.GetTransactions();
//     Console.WriteLine("Withdraw successful!");
// }
// catch (ArgumentOutOfRangeException ex)
// {

//     Console.WriteLine($"Withdrawal failed {ex.Message}");
// }
// finally
// {
//     IReadOnlyList<Transaction> transactionsCompleted = account.History.GetTransactions();
//     foreach (var transaction in transactionsCompleted)
//     {
//           Console.WriteLine($"Transaction: {transaction.Amount} on {transaction.CreatedAt}");
//     }
//     Console.WriteLine($"Withdrawal processing finished, total Transactions {transactionsCompleted.Count}");
//     Console.WriteLine($"Current Balance {account.Balance}");

// }



decimal[] withdrawalRequests =
[
    30000m,
    90000m,
    150000m,
    5000m,
    -2000m
];






// foreach (decimal amount in withdrawalRequests)
// {
//     try
//     {
//         account.Withdraw(amount);
//         Console.WriteLine($"Withdrawal of {amount:N2} successful!");
//         successfulWithdrawals++;
//         Console.WriteLine($"Successful Withdrawals: {successfulWithdrawals}");

//     }
//     catch (ArgumentOutOfRangeException ex)
//     {
//         Console.WriteLine($"Withdrawal of {amount:N2} failed: {ex.Message}");
//         failedWithdrawals++;
//         Console.WriteLine($"Failed Withdrawals: {failedWithdrawals}");
//     }
//     finally
//     {
//         Console.WriteLine($"Successful Withdrawals: {successfulWithdrawals}");
//         Console.WriteLine($"Failed Withdrawals: {failedWithdrawals}");
//     }
// }

// IReadOnlyList<Transaction> transactionsCompleted = account.History.GetTransactions();

// Console.WriteLine("\n======== TRANSACTION SUMMARY ===========");

// Console.WriteLine($"Successful Withdrawals: {successfulWithdrawals}");
// Console.WriteLine($"Failed Withdrawals: {failedWithdrawals}");
// Console.WriteLine($"Total Transactions: {transactionsCompleted.Count}");
// Console.WriteLine($"Final Balance: {account.Balance:N2}");




static void ProcessWithdrawal(BankAccount account, decimal[] withdrawalRequests)
{
    int successfulWithdrawals = 0;

    int failedWithdrawals = 0;
    foreach (var amount in withdrawalRequests)
    {
        try
        {

            account.Withdraw(amount);
            Console.WriteLine($"Withdrawal of {amount:N2} successful!");
            successfulWithdrawals++;
            Console.WriteLine($"Successful Withdrawals: {successfulWithdrawals}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Invalid amount: {ex.Message}");
            failedWithdrawals++;
            Console.WriteLine($"Failed Withdrawals: {failedWithdrawals}");
            
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Insufficient funds: Requested {ex.RequestedAmount:N2}, Available {ex.AvailableBalance:N2}, Shortfall {ex.Shortfall:N2}");
            failedWithdrawals++;
            Console.WriteLine($"Failed Withdrawals: {failedWithdrawals}");
            
        }

    }

    Console.WriteLine("\n--- Withdrawal Summary ---");
    Console.WriteLine($"Successful: {successfulWithdrawals}");
    Console.WriteLine($"Failed: {failedWithdrawals}");
    Console.WriteLine($"Final Balance: {account.Balance:N2}");

}


    ProcessWithdrawal(account, withdrawalRequests);




BankAccount lona = new BankAccount("Amina", 20000m);

lona.OnDeposit += SendNotification;
lona.OnDeposit += RecordAudit;



static void SendNotification(object? sender, DepositEventArgs e)
{
    Console.WriteLine($"Customer deposited {e.Amount}");

    Console.WriteLine($"Event raised by: {sender?.GetType().Name}");
}

static void RecordAudit(object? sender, DepositEventArgs e)
{
    Console.WriteLine($"Audit recorded: {e.Amount} ");
}

List<BankAccount> customersAccount =
[
    new BankAccount("Gracey", 10000m),
    new BankAccount("Amina", 20000m),
    new BankAccount("Lona", 30000m),
    new BankAccount("David", 40000m)
];

IEnumerable<string> wealthyAccounts = customersAccount
                     .Where(account => account.Balance > 10000m)
                     .OrderByDescending(account => account.Balance)
                     .Select(account => account.AccountHolder);



static decimal ProcessAmount(decimal amount,
    Func<decimal, decimal> operation)
{
    return operation(amount);
}

decimal deposit = ProcessAmount(3000, amount => amount + 3000);

decimal discounted = ProcessAmount(1000, amount => amount - 1000);




foreach (string name in wealthyAccounts)
{
    Console.WriteLine(name);
}


DataContainer<string> businessName = new("Abbey");
DataContainer<decimal> accountBalance = new(5000m);

businessName.Value = "Abbey Ltd";
accountBalance.Value = 10000m;

Console.WriteLine($"Business Name: {businessName.Value}");
Console.WriteLine($"Account Balance: {accountBalance.Value}");






RecentOperations recent = new();

recent.PushOperation("Create Account");
recent.PushOperation("Deposit");
recent.PushOperation("Withdraw");

while (recent.TryGetOperations(out string? operation))
{
    Console.WriteLine($"Recent Operation {operation}");
}



Queue<string> references = new();

references.Enqueue("TXT101");
references.Enqueue("TXT102");
references.Enqueue("TXT103");

//process  transactions untill the queue is empty.

while (references.Count > 0)
{
    Console.WriteLine($"Processing reference: {references.Peek()}");
    string reference = references.Dequeue();

    Console.WriteLine($"Processing reference: {reference}");
}

Console.WriteLine("Finished processing all references.");




Queue<int> numbers = new();

numbers.Enqueue(10);
numbers.Enqueue(20);
numbers.Enqueue(30);

Console.WriteLine(numbers.Dequeue());
Console.WriteLine(numbers.Peek());
Console.WriteLine(numbers.Count);

PendingTransactionQueue pendingQueue = new();
pendingQueue.AddReference("TXT101");
pendingQueue.AddReference("TXT102");
pendingQueue.AddReference("TXT103");

while (pendingQueue.TryGetNextReference(out string? reference))
{
    Console.WriteLine("Processing next pending transaction.");
    Console.WriteLine($"Reference: {reference}");
}
Console.WriteLine("Finished processing pending transactions.");

pendingQueue.AddReference("TXT104");




TransactionReferenceTracker tracker = new();




// 1. Call TryProcess("TXT100") and print the result.

bool isAdded = tracker.TryProcess("TXT100");

Console.WriteLine(isAdded);

//2. Call TryProcess("TXT100") again and print the result.


Console.WriteLine(tracker.TryProcess("TXT100"));

Console.WriteLine(tracker.TryProcess(" "));



List<string> customers = ["Gracey", "Amina", "Lona"];


Console.WriteLine($"Number of customers: {customers.Count}");

customers.Add("David");

Console.WriteLine($"Count after Adding David {customers.Count}");

customers.Remove("Amina");



Console.WriteLine($"First customer {customers[0]}");

foreach (var customer in customers)
{
    Console.WriteLine(customer);

}


Console.WriteLine($"Count after removing Amina {customers.Count}");

customers.RemoveAt(1);

foreach (var customer in customers)
{
    Console.WriteLine(customer);
}

HashSet<int> blockedaccountnumbers = [1002, 1003, 1005, 1006, 1008, 1200];

// check whether 1005 is blocked
if (blockedaccountnumbers.Contains(1005))
{
    Console.WriteLine("1005 is blocked");
}

//Attempt to block 1005 again and report the duplicate.

if (!blockedaccountnumbers.Add(1005))
{
    Console.WriteLine("1005 is already blocked");
}

//Unblock 1005
blockedaccountnumbers.Remove(1005);


// Check whether it is still blocked.
if (!blockedaccountnumbers.Contains(1005))
{
    Console.WriteLine("1005 is no longer blocked");
}
else
{
    Console.WriteLine("1005 is still blovked.");
}



//Print the final number of blocked accounts

foreach (var accountblocked in blockedaccountnumbers)
{
    //Console.WriteLine($"The List of Blocked accounts {accountblocked}");
    Console.WriteLine($"Total blocked accounts: {accountblocked}");
}

string[] incomingReferences =
[
    "TXT100", "TXT101", "TXT100", "TXT102", "TXT101"
];

HashSet<string> processedReference =
[
    "TXT100",
    "TXT101",
    "TXT102",
    "TXT102",
    "TXT101",
    "TXT104",
];



foreach (string item in incomingReferences)
{
    if (processedReference.Add(item))
    {
        Console.WriteLine($"Transaction reference accepted {item} ");
    }
    else
    {
        Console.WriteLine($"Duplicate transaction reference {item}");
    }
}







Dictionary<int, BankAccount> accounts = new()
{
    [1002] = new BankAccount("Biodun", 5000m),
    [1003] = new BankAccount("Chidi", 7000m),
    [1004] = new BankAccount("Efe", 6000m),
    [1005] = new BankAccount("Femi", 4000m),
    [1006] = new BankAccount("Grace", 3000m),
    [1007] = new BankAccount("Hakeem", 2000m)
};

Console.WriteLine(accounts[1002].AccountHolder);

Console.WriteLine("Enter account number: ");
string? userInputAccount = Console.ReadLine();


if (int.TryParse(userInputAccount, out int accountNumber))
{
    if (accounts.TryGetValue(accountNumber, out BankAccount? acc))
    {
        Console.WriteLine($"Account Holder: {acc.AccountHolder}");
        Console.WriteLine($"Account Balance: {acc.Balance}");
    }
    else
    {
        Console.WriteLine("Account not found");
    }
}
else
{
    Console.WriteLine("Please enter a valide Numeric Account Number");
}

Console.WriteLine("Enter a new Account Number");
string? newAccountInput = Console.ReadLine();

if (int.TryParse(newAccountInput, out int newAccountNumber))
{

    if (accounts.ContainsKey(newAccountNumber))
    {
        Console.WriteLine("Account number already exists");
    }
    else
    {
        Console.Write("Enter account holder's name: ");
        string? userName = Console.ReadLine();

        Console.Write("Enter opening balance: ");
        string? balance = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userName))
        {
            Console.WriteLine("Account Holder name is required");
            return;
        }

        else if (!decimal.TryParse(balance, out decimal OpeningBalance))
        {
            Console.WriteLine("Please enter a valid opening balance");
            return;
        }

        else if (OpeningBalance < 0)
        {
            Console.WriteLine("Opening balance cannot be negative");
            return;
        }
        else
        {
            accounts.Add(newAccountNumber, new BankAccount(userName, OpeningBalance));
            Console.WriteLine("Account successfully created");
        }

    }


}
else
{
    Console.WriteLine("Please enter a valid numeric account number");
}

Dictionary<int, string> customersList = new()
{
    [1002] = "Biodun",
    [1003] = "Chidi",
    [1004] = "Efe"
};

customersList.Add(1005, "Femi");


//check if key exists
bool exist = customersList.ContainsKey(1002);


Console.WriteLine(customersList[1002]);

//try get value safely without risking a missing key exception

if (customersList.TryGetValue(1008, out string? customerName))
{
    Console.WriteLine(customerName);
}

customersList.Remove(1003);




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


account.Deposit(2000m);
account.Deposit(500m);

Console.WriteLine($"Account holder: {account.AccountHolder}");
Console.WriteLine($"Balance: {account.Balance}");
Console.WriteLine($"Transaction count: {account.History.GetTransactions().Count}");


foreach (Transaction transaction in account.History.GetTransactions())
{
    Console.WriteLine($"Transaction Type is {transaction.Type}, Amount is {transaction.Amount} and the Date is {transaction.CreatedAt}");
}

Console.WriteLine($"Opening Balance: {account.Balance}");

//Transaction Object Creation

Transaction depositTransaction = new Transaction(TransactionType.Deposit, 500m);
Console.WriteLine($"Transaction Created: {depositTransaction.Type} of amount {depositTransaction.Amount} at {depositTransaction.CreatedAt}");


try
{
    account.Deposit(-500m);
    Console.WriteLine($"Balance after deposit: {account.Balance}");
}
catch (ArgumentOutOfRangeException ex)
{

    Console.WriteLine($"Desposit Failed: {ex.Message}");
}
finally
{
    Console.WriteLine($"Final Balance: {account.Balance}");
}

