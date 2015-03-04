namespace GalacticGPS
{
    using System;

    struct Location
    {
        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if(value > double.MaxValue || value < double.MinValue)
                {
                    throw new ArgumentException("You entered bigger(positive or negative) number than this system can hold!");
                }
                else
                {
                    this.latitude = value;
                }
            }
        }

        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value > double.MaxValue || value < double.MinValue)
                {
                    throw new ArgumentException("You entered bigger(positive or negative) number than this system can hold!");
                }
                else
                {
                    this.longitude = value;
                }
            }
        }

        public Planet Planet
        {
            get;
            set;
        }

        public override string ToString()
        {
            return this.Latitude.ToString() + ", " + this.Longitude.ToString() + " - " + this.Planet.ToString();
        }
    }
}
