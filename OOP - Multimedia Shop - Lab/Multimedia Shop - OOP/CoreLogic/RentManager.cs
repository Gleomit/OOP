namespace MultimediaShop.CoreLogic
{
    using System.Linq;
    using System.Collections.Generic;

    using MultimediaShop.Interfaces;
    using MultimediaShop.Models;
    using MultimediaShop.Models.Items;
    using MultimediaShop.Enumerations;
    
    class RentManager
    {
        private HashSet<IRent> rents = new HashSet<IRent>();

        public void AddRent(IRent rent)
        {
            rents.Add(rent);
        }

        public void ReturnRentedItem(string itemID)
        {
            Rent rent = (Rent)rents.First(target => target.Item.ID == itemID);
            rent.ReturnItem();
        }

        public List<IRent> GetReport()
        {
            List<IRent> rents = this.rents.Where(rent=>rent.RentState == RentState.Overdue)
                .OrderBy(rent => rent.RentFine)
                .ThenBy(rent => rent.Item.Title).ToList();
            
            return rents;
        }
    }
}
