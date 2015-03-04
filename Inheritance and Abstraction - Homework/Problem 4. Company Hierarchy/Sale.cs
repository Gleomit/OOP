namespace CompanyHierarchy
{
    using System;
    using CompanyHierarchy.Interfaces;

    class Sale : ISale
    {
        private string productName;
        private double price;
        private DateTime date;

        public Sale(string productName, double price, DateTime date)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Date = date;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Project name cannot be null or empty.");
                }
                else
                {
                    this.productName = value;
                }
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("The sale price cannot be negative.");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set
            {
                this.date = value;
            }
        }

        public override string ToString()
        {
            return "I am a sale!";
        }
    }
}
