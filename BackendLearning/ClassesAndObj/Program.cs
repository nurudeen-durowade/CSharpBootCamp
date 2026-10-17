
using ClassesAndObj.Models;

BankAccount account1 = new("Amina", 5000m);
BankAccount account2 = new("David", 12000m);

account1.DisplayAccountInfo();


Console.WriteLine();

account2.DisplayAccountInfo();


Onboarding customer1 = new("Amina", DateTime.Now);

customer1.DisplayOnboardingInfo();

Onboarding customer2 = new("David", DateTime.Now);
customer2.DisplayOnboardingInfo();



Customer newcustomer1 = new("Amina",30);
newcustomer1.DisplayCustomerInfo();

Customer newcustomer2 = new("David", 25);
newcustomer2.DisplayCustomerInfo();
