namespace BankOfKurtovoKonare
{
    class MortgageAccount : Account
    {
        public MortgageAccount(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {

        }

        public override decimal GetInterest(int months)
        {
            decimal interest = 0;
            if(this.Customer is Company)
            {
                if(months <= 12)
                {
                    interest = (this.Balance * (1 + this.InterestRate * months)) / 2;
                }
                else
                {
                    interest = ((this.Balance * (1 + this.InterestRate * 12)) / 2) + (this.Balance * (1 + this.InterestRate * (months - 12)));
                }
            }
            else if (this.Customer is Individual)
            {
                if (months > 6)
                {
                    interest = (this.Balance * (1 + this.InterestRate * (months - 6)));
                }
            }
            return interest;
        }
    }
}
