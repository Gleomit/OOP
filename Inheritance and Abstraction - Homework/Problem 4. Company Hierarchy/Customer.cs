namespace CompanyHierarchy
{
    class Customer : Person
    {
        private double netPurchaseAmount;

        public Customer(int id, string firstName, string lastName, double netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.netPurchaseAmount = netPurchaseAmount;
        }

        public override string ToString()
        {
            return "I am a customer!";
        }
    }
}
