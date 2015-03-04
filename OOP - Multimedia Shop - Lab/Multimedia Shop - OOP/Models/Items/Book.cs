namespace MultimediaShop.Models.Items
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Book : Item
    {
        private string author;

        public Book(string id, string title, decimal price, string author, List<string> genres)
            : base(id, title, price, genres)
        {
            this.Author = author;
        }

        public Book(string id, string title, decimal price, string author, string genre)
            : this(id, title, price, author, new List<string>() { genre })
        {
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                if(value.Trim() == string.Empty || value.Trim().Length < 3)
                {
                    throw new ArgumentException("The Author cannot be empty, and cannot be less than 3 symbols");
                }
                else
                {
                    this.author = value;
                }
            }
        }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("Book {0}\nAuthor: {1}\n{2}\n",
                this.ID, this.Author, base.ToString()).ToString();
        }
    }
}
