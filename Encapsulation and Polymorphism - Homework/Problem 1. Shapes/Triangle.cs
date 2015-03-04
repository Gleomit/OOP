namespace Problem_1.Shapes
{
    public class Triangle : BasicShape
    {
        public Triangle(double side, double height)
            : base(side, height)
        {

        }

        public override double CalculateArea()
        {
            return (this.Height * this.Width) / 2;
        }

        public override double CalculatePerimeter()
        {
            return 3 * this.Width;
        }

        public override string ToString()
        {
            return "I am a triangle";
        }
    }
}
