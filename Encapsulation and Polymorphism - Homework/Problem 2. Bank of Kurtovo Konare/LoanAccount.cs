namespace BankOfKurtovoKonare
{
    class LoanAccount : Account
    {
        public LoanAccount(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {

        }

        public override decimal GetInterest(int months)
        {
            decimal interest = 0;
            if (this.Customer is Company)
            {
                if (months > 2)
                {
                    interest = (this.Balance * (1 + this.InterestRate * (months - 2)));
                }
            }
            else if (this.Customer is Individual)
            {
                if (months > 3)
                {
                    interest = (this.Balance * (1 + this.InterestRate * (months - 3)));
                }
            }
            return interest;
        }
    }
}
