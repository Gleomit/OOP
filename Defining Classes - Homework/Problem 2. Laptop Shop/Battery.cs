namespace HomeworkDefiningClasses
{
    using System;

    public class Battery
    {
        private string batteryType;
        private int batteryCells;
        private int batteryCapacity;

        public Battery(string batteryType, int batteryCells, int batteryCapacity)
        {
            this.BatteryType = batteryType;
            this.BatteryCells = batteryCells;
            this.BatteryCapacity = batteryCapacity;
        }

        public Battery(string batteryType, int batteryCells)
            : this(batteryType, batteryCells, 0)
        {

        }

        public Battery(string batteryType)
            : this(batteryType, 0, 0)
        {

        }

        public Battery()
            : this(null, 0, 0)
        {

        }

        public string BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (value != null && value.Trim() == String.Empty)
                    throw new ArgumentException("Invalid battery information!");
                else
                    this.batteryType = value;
            }
        }

        public int BatteryCapacity
        {
            get { return this.batteryCapacity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Battery capacity cannot be negative!");
                else
                    this.batteryCapacity = value;
            }
        }

        public int BatteryCells
        {
            get { return this.batteryCells; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Battery cells cannot be negative!");
                else
                    this.batteryCells = value;
            }
        }

        public override string ToString()
        {
            return "\n" + this.BatteryType + ", " + this.BatteryCells.ToString() + ", " + this.BatteryCapacity;
        }
    }
}
