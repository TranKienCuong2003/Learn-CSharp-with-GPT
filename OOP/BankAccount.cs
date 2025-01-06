namespace OOP
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount()
        {
            balance = 0;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
