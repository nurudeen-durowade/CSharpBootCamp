namespace MiniBankingPractice.Models
{
    
    public class BankAccount
    {
        public string AccountHolder {get; private set;}

        //event
        public event EventHandler<DepositEventArgs>? OnDeposit;

        public decimal Balance {get; private set;}

        public string? AccountNickname { get; set; }
        public TransactionHistory History {get;} = new TransactionHistory();

        public Transaction? Transactions { get; private set; }

        public BankAccount(string accountHolder, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(accountHolder))
                throw new ArgumentException("Account holder is required", nameof(accountHolder));
            if (initialBalance < 0)
                throw new ArgumentOutOfRangeException(nameof(initialBalance),"Initial balance must be non-negative");
            AccountHolder = accountHolder;

            Balance = initialBalance;
        }

        public string GetAccountDisplayName()
        {
           if(!string.IsNullOrWhiteSpace(AccountNickname))
               return AccountNickname.Trim();
           return AccountHolder.Trim();
        }



        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"The Amount to deposit must be positive");
            }

            Balance += amount;
            Transactions = new Transaction(TransactionType.Deposit, amount);
          
            //Transact;
            History.AddTransaction(Transactions);

            OnDeposit?.Invoke(this, new DepositEventArgs(amount));
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"The Amount to withdraw must be positive");
            }
            if (amount > Balance)
            {
                throw new InsufficientFundsException(amount, Balance);
            }
            Balance -= amount;
            Transactions = new Transaction(TransactionType.Withdrawal, amount);
            History.AddTransaction(Transactions);
        }
    }
}
