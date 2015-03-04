namespace HomeworkStaticMembersAndNamespaces
{
    using System;
    using System.Collections.Generic;

    public class Path3D
    {
        private List<Point3D> points;

        public Path3D(List<Point3D> points) : this()
        {
            this.setThePoints(points);
        }

        public Path3D()
        {
            this.points = new List<Point3D>();
        }

        public void setThePoints(List<Point3D> points)
        {
            this.points = points;
        }

        public override string ToString()
        {
            List<string> Tpoints = new List<string>();
            foreach (Point3D point in this.points)
            {
                Tpoints.Add(point.ToString());
            }
            return String.Join(" | ", Tpoints);
        }
    }
}
