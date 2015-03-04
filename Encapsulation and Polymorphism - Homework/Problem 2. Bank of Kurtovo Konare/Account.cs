namespace BankOfKurtovoKonare
{
    using System;

    public abstract class Account : IAccount, IDepositable
    {
        private decimal balance;
        private decimal interestRate;
        private Customer customer;

        public Account(decimal balance, decimal interestRate, Customer customer)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Customer = customer;
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative number.");
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate cannot be negative number.");
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }

        public Customer Customer
        {
            get { return this.customer; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Customer cannot be null.");
                }
                else
                {
                    this.customer = value;
                }
            }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public abstract decimal GetInterest(int months);
    }
}
