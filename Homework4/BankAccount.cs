namespace Homework4
{
    internal class BankAccount
    {
        public string Name { get; private set; }
        public decimal AccountBalance { get; private set; }
        public decimal DepositAmount { get; private set; }
        public decimal WithdrawalAmount { get; private set; }
        public decimal InterestAmount { get; private set; }

        public BankAccount(string name, decimal initialBalance)
        {
            Name = name;
            AccountBalance = initialBalance;
        }

        public void deposite(decimal amount)
        {
            DepositAmount = amount;
            AccountBalance += amount;
        }

        public void withdraw(decimal amount)
        {
            if (amount <= AccountBalance)
            {
                WithdrawalAmount = amount;
                AccountBalance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public void interest(decimal amount)
        {
            InterestAmount = AccountBalance * amount;
            AccountBalance += InterestAmount;
        }

        public void ShowAccountBalance()
        {
            Console.WriteLine($"Account Balance: {AccountBalance}");
        }
    }

}
