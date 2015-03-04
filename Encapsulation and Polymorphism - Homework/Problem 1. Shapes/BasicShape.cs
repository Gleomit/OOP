namespace Problem_1.Shapes
{
    using System;

    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
    }
}
