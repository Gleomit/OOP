namespace MultimediaShop.Models.Items
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Movie : Item
    {
        private double minutes;

        public Movie(string id, string title, decimal price, int length, List<string> genres)
            : base(id, title, price, genres)
        {
            this.Minutes = length;
        }

        public Movie(string id, string title, decimal price, int length, string genre)
            : this(id, title, price, length, new List<string>() { genre })
        {
        }

        public double Minutes
        {
            get { return this.minutes; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Video minutes cannot be negative number!");
                }
                else
                {
                    this.minutes = value;
                }
            }
        }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("Movie {0}\nLength: {1}\n{2}\n",
                this.ID, this.Minutes, base.ToString()).ToString();
        }
    }
}
