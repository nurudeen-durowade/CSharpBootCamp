namespace MiniBankingPractice.Models
{
    
    public class BankAccount
    {
        public string AccountHolder {get; set;}

        public decimal Balance {get; private set;}

        public TransactionHistory History {get;} = new TransactionHistory();

        public BankAccount(string accountHolder, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(accountHolder))
                throw new ArgumentException(nameof(accountHolder),"Account holder is required");
            if (initialBalance < 0)
                throw new ArgumentOutOfRangeException(nameof(initialBalance),"Initial balance must be non-negative");
            AccountHolder = accountHolder;

            Balance = initialBalance;
        }


        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"The Amount to deposit must be positive");
            }

            Balance += amount;
            History.AddTransaction(new Transaction("Deposit",amount));
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"The Amount to withdraw must be positive");
            }
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Insufficient funds for withdrawal");
            }
            Balance -= amount;
            History.AddTransaction(new Transaction("Withdrawal", amount));
        }
    }
}
