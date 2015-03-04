namespace HomeworkStaticMembersAndNamespaces
{
    using System;
    
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D first, Point3D second)
        {
            double theDistance = Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2) + Math.Pow(first.Z - second.Z, 2));
            return theDistance;
        }
    }
}
