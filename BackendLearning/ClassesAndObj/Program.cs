
using ClassesAndObj.Models;

//BankAccount account1 = new("Amina", 5000m);
//BankAccount account2 = new("David", 12000m);

// BankAccount is the declared variable type, but the actual object is of type SavingsAccount.
BankAccount savingsAccount1 = new SavingsAccount("Gracey", 1000m);

IMonthlyFeeCalculator savingsFee = new SavingsAccount("Jahn", 2500m);

IMonthlyFeeCalculator currentFee = new CurrentAccount("Sean", 4000m);

Console.WriteLine($"Jahn's Monthly Fee: {savingsFee.CalculateMonthlyFee()}");
Console.WriteLine($"Sean's Monthly Fee: {currentFee.CalculateMonthlyFee()}");

// BankAccount is the declared variable type, but the actual object is of type CurrentAccount.
BankAccount currentAccount1 = new CurrentAccount("Michael", 2000m);

savingsAccount1.Deposit(500m);
//savingsAccount1.ApplyInterest(0.08m);

savingsAccount1.DisplayAccountInfo();

Console.WriteLine($"Gracey's savings account balance: {savingsAccount1.Balance}");
Console.WriteLine($"Gracey's Monthly Fee: {savingsAccount1.CalculateMonthlyFee()}");

Console.WriteLine();

currentAccount1.Deposit(1000m);
currentAccount1.DisplayAccountInfo();

Console.WriteLine($"Michael's Monthly Fee: {currentAccount1.CalculateMonthlyFee()}");
Console.WriteLine($"Michael's current account balance: {currentAccount1.Balance}");

//Console.WriteLine(account1.Balance);

//Console.WriteLine($"My Bank Name: {BankAccount.BankName}");

//This is a static method. It can be called on the class itself without creating an account object.
//Console.WriteLine($"Total Accounts Created: {BankAccount.GetAccountsCreated()}");

// account1.Deposit(2000m);

// account1.DisplayAccountInfo();

// Console.WriteLine();

// account2.Deposit(-500m);
// account2.DisplayAccountInfo();


// Onboarding customer1 = new("Amina", DateTime.Now);

// customer1.DisplayOnboardingInfo();

// Onboarding customer2 = new("David", DateTime.Now);
// customer2.DisplayOnboardingInfo();



// Customer newcustomer1 = new("Amina",30);
// newcustomer1.DisplayCustomerInfo();

// Customer newcustomer2 = new("David", 25);
// newcustomer2.DisplayCustomerInfo();




// Customer newCustomer3 = new("Grace",28);

// newCustomer3.DisplayCustomerInfo();

// Console.WriteLine();


// newCustomer3.UpdateAge(30);
// Console.WriteLine($"Updated Customer Age: {newCustomer3.Age}");

// newCustomer3.UpdateAge(-3);
// Console.WriteLine($"After invalid update Customer Age: {newCustomer3.Age}");


// Using the Implicitly defined parameterless constructor to create a new customer
// Customer newCustomer4 = new();
// newCustomer4.DisplayCustomerInfo();

// newCustomer4.Age = 35;
