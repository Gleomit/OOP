namespace MultimediaShop.Models
{
    using MultimediaShop.Interfaces;
    using MultimediaShop.Enumerations;
    using Items;

    using System;
    using System.Text;

    public class Rent : IRent
    {
        private Item item;
        private RentState rentState;

        public Rent(Item item, DateTime rentDate, DateTime deadline)
        {
            this.Item = item;
            this.RentDate = rentDate;
            this.ReturnDeadline = deadline;
            
        }

        public Rent(Item item, DateTime rentDate)
            : this(item, rentDate, rentDate.AddDays(30))
        {
        }

        public Rent(Item item)
            : this(item, DateTime.Now, DateTime.Now.AddDays(30))
        {
        }

        public void ReturnItem()
        {
            this.ReturnDate = DateTime.Now;
            this.RentState = RentState.Returned;
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

        public RentState RentState
        {
            get
            {
                if (this.rentState == RentState.Returned)
                {
                    return RentState.Returned;
                }
                else if (DateTime.Now > this.ReturnDeadline && this.rentState != RentState.Returned)
                {
                    return RentState.Overdue;
                }
                else
                {
                    return RentState.Pending;
                }
            }
            set
            {
                this.rentState = value;
            }
        }

        public DateTime RentDate
        {
            get;
            set;
        }

        public DateTime ReturnDate
        {
            get;
            set;
        }

        public DateTime ReturnDeadline
        {
            get;
            set;
        }

        public decimal RentFine
        {
            get
            {
                decimal fine = 0;
                
                if (this.RentState == RentState.Overdue)
                {
                    int days = (DateTime.Now - this.ReturnDeadline).Days;
                    fine = (decimal)0.01 * (this.Item.Price * days);
                }
                else if(this.RentState == RentState.Returned && this.ReturnDate > this.ReturnDeadline)
                {
                    int days = (this.ReturnDate - this.ReturnDeadline).Days;
                    fine = (decimal)0.01 * (this.Item.Price * days);
                }
                return fine;
            }
        }

        public override string ToString()
        {
            return new StringBuilder().
                AppendFormat("- Rent {0}\n{1}\nRent fine: {2:0.00}",
                this.RentState.ToString(), this.Item.ToString(), this.RentFine).ToString();
        }
    }
}
