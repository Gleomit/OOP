namespace MultimediaShop.Models
{
    using MultimediaShop.Interfaces;
    using System;
    using System.Text;

    class Sale : ISale
    {
        private Item item;
        
        public Sale(Item item, DateTime saleDate)
        {
            this.Item = item;
            this.SaleDate = saleDate;
        }

        public Sale(Item item)
            : this(item, DateTime.Now)
        {
        }

        public Item Item
        {
            get { return this.item; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("The item cannot be null!");
                }
                else
                {
                    this.item = value;
                }
            }
        }

        public DateTime SaleDate
        {
            get;
            set;
        }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("- Sale {0}\n{1}", this.SaleDate.ToString(), this.Item.ToString()).ToString();
        }
    }
}
