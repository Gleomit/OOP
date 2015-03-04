namespace HomeworkDefiningClasses
{
    using System;

    public class Component
    {
        private string name;
        private string details;
        private float price;

        public Component(string name, float price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, float price, string details)
            : this(name, price)
        {
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or empty!");
                else
                    this.name = value;
            }
        }

        public float Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative!");
                else
                    this.price = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value != null && value.Trim() == String.Empty)
                    throw new ArgumentException("Details cannot be empty string!");
                else
                    this.details = value;
            }
        }

        public override string ToString()
        {
            return "\n\tComponent name - "
                + this.Name
                + "\n\tComponent price - " + this.Price.ToString();
        }
    }
}
