namespace HomeworkDefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Computer> computers = new List<Computer>() 
            {
                new Computer("Sampe PC"),
                new Computer("Common PC", new Component("Test Motherboard", 23f)),
                new Computer("Extra PC", new Component("OmegaK XJG987", 150f),
                    new Component("XFX Radeon HD 5450 1GB 64-bit DDR3", 100f)),
                new Computer("Super PC", new Component("SuperX BH543", 300.25f),
                    new Component("Gigabyte GV-N210D3-1GI", 79.34f), new Component("Intel Core i7 4700", 500f)),
            };
            computers = computers.OrderBy(computer=>computer.getTotalPrice()).ToList();
            foreach (Computer comp in computers)
            {
                comp.displayInfo();
            }
            Console.ReadLine();
        }
    }
}
