namespace MultimediaShop.Interfaces
{
    using MultimediaShop.Models;
    using System;
    interface ISale
    {
        Item Item { get; set; }
        DateTime SaleDate { get; set; }
    }
}
