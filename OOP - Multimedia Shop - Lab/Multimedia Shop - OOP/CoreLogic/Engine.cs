namespace MultimediaShop.CoreLogic
{
    using System;
    using System.Linq;
    using System.Globalization;
    using System.Collections.Generic;

    using MultimediaShop.Interfaces;
    using MultimediaShop.Models.Items;
    using MultimediaShop.Models;
    using MultimediaShop.Exceptions;
    using MultimediaShop.Enumerations;

    class Engine
    {
        private Dictionary<IItem, int> supplies = new Dictionary<IItem,int>();
        private RentManager rentManager = new RentManager();
        private SaleManager saleManager = new SaleManager();

        public void Run()
        {
            while(true)
            {
                string inputLine = Console.ReadLine();
                string[] parameters = inputLine.Split(
                    new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                ExecuteCommand(parameters);
            }
        }

        private void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "supply":
                    Supply(inputParams);
                    break;
                case "sell":
                    Sell(inputParams);
                    break;
                case "rent":
                    Rent(inputParams);
                    break;
                case "return":
                    Return(inputParams);
                    break;
                case "report":
                    this.Report(inputParams);
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }

        private void Report(string[] inputParams)
        {
            switch(inputParams[1])
            {
                case "rents":
                    ReportRents();
                    break;
                case "sales":
                    ReportSales(inputParams);
                    break;
                default:
                    break;
            }
        }

        private void ReportSales(string[] inputParams)
        {
            Console.WriteLine(this.saleManager.GetReport(
                DateTime.ParseExact(inputParams[2], "dd-MM-yyyy", CultureInfo.CurrentCulture)).ToString());
        }

        private void ReportRents()
        {
            List<IRent> rents = rentManager.GetReport();
            foreach(IRent rent in rents)
            {
                Console.WriteLine("\n" + rent.ToString());
            }
        }

        private void Supply(string[] inputParams)
        {
            Dictionary<string, string> theParams = GetParams(inputParams[3]);
            if(inputParams[1] == "book")
            {
                Book book = new Book(theParams["id"], theParams["title"], Decimal.Parse(theParams["price"]),
                    theParams["author"], theParams["genre"]);
                this.supplies.Add(book, Int32.Parse(inputParams[2]));
            }
            else if (inputParams[1] == "movie")
            {
                Movie movie = new Movie(theParams["id"], theParams["title"], Decimal.Parse(theParams["price"]),
                    Int32.Parse(theParams["length"]), theParams["genre"]);
                this.supplies.Add(movie, Int32.Parse(inputParams[2]));
            }
            else if (inputParams[1] == "game")
            {
                AgeRestriction ageRestriction = AgeRestriction.Minor;
                if(theParams["ageRestriction"] == "Teen")
                {
                    ageRestriction = AgeRestriction.Teen;
                }
                else if(theParams["ageRestriction"] == "Adult")
                {
                    ageRestriction = AgeRestriction.Adult;
                }

                Game game = new Game(theParams["id"], theParams["title"], Decimal.Parse(theParams["price"]),
                   theParams["genre"], ageRestriction);
                this.supplies.Add(game, Int32.Parse(inputParams[2]));
            }
        }

        private void Sell(string[] inputParams)
        {
            IItem item = supplies.Keys.First(supply => supply.ID == inputParams[1]);
            if (item != null)
            {
                if(supplies[item] < 1)
                {
                    throw new InsufficientSuppliesException("The item you specified is currently out of stock.");
                }
                else
                {
                    Sale sale = new Sale((Item)item, DateTime.ParseExact(inputParams[2], "dd-MM-yyyy", CultureInfo.CurrentCulture));
                    saleManager.AddSale(sale);
                    supplies[item] -= 1;
                }
            }
            else
            {
                throw new InsufficientSuppliesException("There is no item with the ID you specified!");
            }
        }

        private void Rent(string[] inputParams)
        {
            IItem item = supplies.Keys.First(supply => supply.ID == inputParams[1]);
            if (item != null)
            {
                if (supplies[item] < 1)
                {
                    throw new InsufficientSuppliesException("The item you specified is currently out of stock.");
                }
                else
                {
                    Rent rent = new Rent((Item)item, 
                        DateTime.ParseExact(inputParams[2], "dd-MM-yyyy", CultureInfo.CurrentCulture),
                        DateTime.ParseExact(inputParams[3], "dd-MM-yyyy", CultureInfo.CurrentCulture));
                    rentManager.AddRent(rent);
                    supplies[item] -= 1;
                }
            }
            else
            {
                Console.WriteLine("There is no such item in the shop!");
            }
        }

        private void Return(string[] inputParams)
        {
            IItem item = supplies.Keys.First(supply => supply.ID == inputParams[1]);
            if (item != null)
            {
                rentManager.ReturnRentedItem(inputParams[1]);
            }
            else
            {
                Console.WriteLine("There is no such item in the shop!");
            }
        }

        private Dictionary<string, string> GetParams(string paramsString)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            string[] pairs = paramsString.Split('&');

            foreach (var pair in pairs)
            {
                string[] keyValuePair = pair.Split('=');
                keyValuePairs[keyValuePair[0]] = keyValuePair[1];
            }
            return keyValuePairs;
        }
    }
}
