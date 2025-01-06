// BankAccount.cs
using System;

namespace OOP
{
    public class BankAccount
    {
        private double balance;

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
