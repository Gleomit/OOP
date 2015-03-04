namespace MultimediaShop.Interfaces
{
    using MultimediaShop.Models;
    using MultimediaShop.Models.Items;
    using MultimediaShop.Enumerations;

    using System;

    interface IRent
    {
        Item Item { get; set; }
        DateTime RentDate { get; set; }
        DateTime ReturnDeadline { get; set; }
        DateTime ReturnDate { get; set; }
        RentState RentState { get; set; }

        decimal RentFine { get; }
    }
}
