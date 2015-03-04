namespace Problem_1.Shapes
{
    using System;
    using System.Collections.Generic;

    public class ShapesMain
    {
        public static void Main()
        {
            List<IShape> shapes = new List<IShape>()
            {
                new Triangle(5, 2),
                new Circle(10),
                new Rectangle(5,2)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("----------");
                Console.WriteLine(shape.ToString());
                Console.WriteLine("My area = " + shape.CalculateArea());
                Console.WriteLine("My perimeter = " + shape.CalculatePerimeter());
                Console.WriteLine("----------");
            }
            Console.Read();
        }
    }
}
