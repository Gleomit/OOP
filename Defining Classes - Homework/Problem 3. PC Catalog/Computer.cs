namespace HomeworkDefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class Computer
    {
        private string name;
        private float price;
        private Component motherboard;
        private Component graphics_card;
        private Component processor;
        private List<Component> otherComponents;

        public Computer(string name)
        {
            this.otherComponents = new List<Component>();

            this.motherboard = new Component("Sample motherboard", 100.4f);
            this.graphics_card = new Component("Sample graphics card", 300f);
            this.processor = new Component("Sample processor", 600f);

            this.Name = name;
        }

        public Computer(string name, Component motherboard)
            : this(name)
        {
            this.Motherboard = motherboard;
        }

        public Computer(string name, Component motherboard,
            Component graphicsCard)
            : this(name, motherboard)
        {
            this.Graphics_Card = graphicsCard;
        }

        public Computer(string name, Component motherboard,
            Component graphicsCard, Component processorModel)
            : this(name, motherboard, graphicsCard)
        {
            this.Processor = processorModel;
        }

        public void displayInfo()
        {
            string output = "Computer name - "
                + this.Name
                + "\nMotherboard:" + this.Motherboard.ToString()
                + "\nGraphics card:" + this.Graphics_Card.ToString()
                + "\nProcessor:" + this.Processor.ToString()
                + "\nOther Components:";
            if (this.otherComponents.Count <= 0)
                output += "This PC doesn't have other components";
            else
            {
                for (int i = 0; i < this.otherComponents.Count; i++)
                {
                    output += "\n" + this.otherComponents[i].ToString();
                }
            }
            output += "\nTotal Price: " + this.getTotalPrice();
            Console.WriteLine(output);
        }

        public float getTotalPrice()
        {
            float price = Motherboard.Price + Graphics_Card.Price + Processor.Price;
            for (int i = 0; i < this.otherComponents.Count; i++)
            {
                price += this.otherComponents[i].Price;
            }
            return price;
        }

        public Component Motherboard
        {
            get { return this.motherboard; }
            set { this.motherboard = value; }
        }

        public Component Graphics_Card
        {
            get { return this.graphics_card; }
            set { this.graphics_card = value; }
        }

        public Component Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or empty!");
                else
                    this.name = value;
            }
        }

        public float Price
        {
            get { return this.getTotalPrice(); }
        }
    }
}
