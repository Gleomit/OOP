namespace Problem_1.Shapes
{
    using System;

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public Circle()
            : this(0)
        {

        }
        public double Radius
        {
            get { return this.radius; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("The radius cannot be negative.");
                }
                else
                {
                    this.radius = value;
                }
            }
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override string ToString()
        {
            return "I am a circle";
        }
    }
}
