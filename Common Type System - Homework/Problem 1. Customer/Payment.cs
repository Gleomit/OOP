namespace CommonTypeSystem.Customer
{
    using System;

    public class Payment
    {
        private double price;
        private string productName;

        public Payment(string productName, double price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public string ProductName 
        {
            get { return this.productName; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product name cannot be null or empty.");
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
                    throw new ArgumentException("The price cannot be negative.");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Product name - {0}, Price - {1}", this.ProductName, this.Price);
        }
    }
}
