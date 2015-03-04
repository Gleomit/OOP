namespace HomeworkDefiningClasses
{
    using System;

    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphics_card;
        private string hdd;
        private string screen;
        private Battery battery;
        private float price;
        private float battery_life;

        public Laptop(string model, string manufacturer, string processor, int ram, string graphics_card,
            string hdd, string screen, float price, Battery battery, float battery_life)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.Graphics_Card = graphics_card;
            this.HDD = hdd;
            this.Screen = screen;
            this.Price = price;
            this.BatteryLife = battery_life;
            this.battery = battery;
        }

        public Laptop(string model, string manufacturer, string processor, int ram, string graphics_card,
            string hdd, string screen, float price, Battery battery)
            : this(model, manufacturer, processor, ram, graphics_card,
            hdd, screen, price, battery, 0)
        {

        }

        public Laptop(string model, string manufacturer, string processor, int ram, string graphics_card,
            string hdd, string screen, float price, float battery_life)
            : this(model, manufacturer, processor, ram, graphics_card,
            hdd, screen, price, null, battery_life)
        {

        }

        public Laptop(string model, string manufacturer, string processor, int ram, string graphics_card,
            string hdd, string screen, float price)
            : this(model, manufacturer, processor, ram, graphics_card,
            hdd, screen, price, null, 0)
        {

        }

        public Laptop(string model, float price)
            : this(model, null, null, 0, null, null, null, price)
        {

        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Invalid model data!");
                else
                    this.model = value;
            }
        }

        public float BatteryLife
        {
            get { return this.battery_life; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The battery life cannot be negative!");
                else
                    this.battery_life = value;
            }
        }

        public float Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The price cannot be negative!");
                else
                    this.price = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value != null && value.Trim() == String.Empty)
                    throw new ArgumentException("Invalid or empty data!");
                else
                    this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value != null && value.Trim() == String.Empty)
                    throw new ArgumentException("Invalid or empty data!");
                else
                    this.processor = value;
            }
        }

        public int RAM
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The RAM cannot be negative!");
                else
                    this.ram = value;
            }
        }

        public string Graphics_Card
        {
            get { return this.graphics_card; }
            set
            {
                if (value != null && value.Trim() == String.Empty)
                    throw new ArgumentException("Invalid or empty data!");
                else
                    this.graphics_card = value;
            }
        }

        public string HDD
        {
            get { return this.hdd; }
            set
            {
                if (value != null && value.Trim() == String.Empty)
                    throw new ArgumentException("Invalid or empty data!");
                else
                    this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value != null && value.Trim() == String.Empty)
                    throw new ArgumentException("Invalid or empty data!");
                else
                    this.screen = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set
            {
                this.battery = value;
            }
        }

        public override string ToString()
        {
            return "Model - " + this.Model
                + "\nManufacturer - " + (this.Manufacturer != null ? this.Manufacturer : "undefined")
                + "\nProcessor - " + (this.Processor != null ? this.Processor : "undefined")
                + "\nRAM - " + this.RAM.ToString() + " GB"
                + "\nGraphics Card - " + (this.Graphics_Card != null ? this.Graphics_Card : "undefined")
                + "\nHDD - " + (this.HDD != null ? this.HDD : "undefined")
                + "\nScreen - " + (this.Screen != null ? this.Screen : "undefined")
                + this.battery.ToString()
                + "\nPrice - " + this.Price.ToString() + " lv";
        }
    }
}
