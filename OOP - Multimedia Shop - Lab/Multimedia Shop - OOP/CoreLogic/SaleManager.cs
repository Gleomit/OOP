namespace MultimediaShop.CoreLogic
{
    using System.Collections.Generic;
    using MultimediaShop.Interfaces;
    using MultimediaShop.Models;
    using System;
    using System.Linq;

    class SaleManager
    {
        private HashSet<ISale> sales = new HashSet<ISale>();

        public void AddSale(ISale sale)
        {
            sales.Add(sale);
        }

        public decimal GetReport(DateTime startDate)
        {
            decimal sum = this.sales.Where(sale => sale.SaleDate >= startDate).Select(sale => sale.Item.Price).Sum();
            return sum;
        }
    }
}
