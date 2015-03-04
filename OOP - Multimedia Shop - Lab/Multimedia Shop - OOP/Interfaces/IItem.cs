using System.Collections.Generic;
namespace MultimediaShop.Interfaces
{
    interface IItem
    {
        string ID { get; set; }
        string Title { get; set; }
        decimal Price { get; set; }
        List<string> Genres { get; set; }
    }
}
