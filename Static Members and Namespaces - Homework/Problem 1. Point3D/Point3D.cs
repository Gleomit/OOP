namespace HomeworkStaticMembersAndNamespaces
{
    using System;

    public class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D startingPoint;

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Point3D(double x, double y)
            : this(x, y, 0)
        {

        }

        public Point3D(double value)
            : this(value, value, value)
        {

        }

        public Point3D()
            : this(0, 0, 0)
        {
            
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public Point3D StartingPoint
        {
            get { return startingPoint; }
        }

        public override string ToString()
        {
            return this.X + ", " + this.Y + ", " + this.Z;
        }
    }
}
