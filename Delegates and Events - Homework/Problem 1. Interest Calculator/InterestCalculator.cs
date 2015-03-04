namespace InterestCalculator
{
    using System;

    delegate double CalculateInterestDelegate(double sumMoney, double interest, int years);

    class InterestCalculator
    {
        private int years;
        private CalculateInterestDelegate handler;

        public double Money
        {
            get;
            private set;
        }

        public double Interest
        {
            get;
            private set;
        }

        public double Calculate()
        {
            return this.handler(this.Money, this.Interest / 100, this.Years);
        }

        public int Years
        {
            get { return this.years; }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Years cannot be negative number.");
                }
                else
                {
                    this.years = value;
                }
            }
        }

        public InterestCalculator(double money, double interest, int years, CalculateInterestDelegate calculateDelegate)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.handler = calculateDelegate;
        }
    }  
}
