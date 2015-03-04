namespace BankOfKurtovoKonare
{
    class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {

        }

        public override decimal GetInterest(int months)
        {
            if(this.Balance > 0 && this.Balance >= 1000)
            {
                decimal interest = this.Balance * (1 + this.InterestRate * months);
                return interest;
            }
            else
            {
                return 0;
            }
        }

        public void Withdraw(decimal amount)
        {
            if(this.Balance - amount >= 0)
            {
                this.Balance -= amount;
            }
        }
    }
}
