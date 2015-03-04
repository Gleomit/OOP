namespace MultimediaShop.Models
{
    using MultimediaShop.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public abstract class Item : IItem
    {
        private string id;
        private string title;
        private decimal price;

        public Item(string id, string title, decimal price)
        {
            this.ID = id;
            this.Title = title;
            this.Price = price;
            this.Genres = new List<string>();
        }

        public Item(string id, string title, decimal price, List<string> genres)
            : this(id, title, price)
        {
            this.Genres = genres;
        }

        public string ID
        {
            get { return this.id; }
            set
            {
                if(value.Trim() == string.Empty || value.Trim().Length < 4)
                {
                    throw new ArgumentException("Item ID should be 4 symbols or more long and cannot be empty string!");
                }
                else
                {
                    this.id = value;
                }
            }
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (value.Trim() == string.Empty)
                {
                    throw new ArgumentException("Item title cannot be empty string!");
                }
                else
                {
                    this.title = value;
                }
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Item price cannot be negative!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public List<string> Genres
        {
            get;
            set;
        }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("Title: {0}\nPrice: {1}\nGenres: {2}",
                this.Title, this.Price, String.Join(", ", this.Genres)).ToString();
        }
    }
}
