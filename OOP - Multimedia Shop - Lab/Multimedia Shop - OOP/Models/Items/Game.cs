namespace MultimediaShop.Models.Items
{
    using Items;
    using MultimediaShop.Enumerations;

    using System.Collections.Generic;
    using System.Text;

    class Game : Item
    {
        public Game(string id, string title, decimal price, List<string> genres, AgeRestriction ageRestriction = AgeRestriction.Minor)
            : base(id, title, price, genres)
        {
            this.AgeRestriction = ageRestriction;
        }

        public Game(string id, string title, decimal price, string genre, AgeRestriction ageRestriction = AgeRestriction.Minor)
            : this(id, title, price, new List<string>() { genre }, ageRestriction)
        {
        }

        public AgeRestriction AgeRestriction
        {
            get;
            set;
        }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("Game {0}\nAge Restriction: {1}\n{2}\n",
                this.ID, this.AgeRestriction.ToString(), base.ToString()).ToString();
        }
    }
}
