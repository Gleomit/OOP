namespace HomeworkStaticMembersAndNamespaces
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class Storage
    {
        public static List<Path3D> LoadPaths(string filePath_NoExtension)
        {
            List<Path3D> paths = new List<Path3D>();

            using (StreamReader reader = new StreamReader(filePath_NoExtension + ".txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Path3D path;
                    List<Point3D> points = new List<Point3D>();
                    string[] text_points = line.Trim().Split('|');
                    foreach (string text_point in text_points)
                    {
                        string[] text_point_coordinate = text_point.Trim().Split(',');
                        for (int i = 0; i < text_point_coordinate.Length; i++)
                            text_point_coordinate[i] = text_point_coordinate[i].Trim();
                        points.Add(new Point3D(Convert.ToDouble(text_point_coordinate[0]),
                                                Convert.ToDouble(text_point_coordinate[1]),
                                                Convert.ToDouble(text_point_coordinate[2])));
                    }
                    path = new Path3D(points);
                    paths.Add(path);
                }
                reader.Close();
            }
            return paths;
        }

        public static bool SavePaths(string filePath_NoExtension, List<Path3D> paths)
        {
            using (StreamWriter writer = new StreamWriter(filePath_NoExtension + ".txt"))
            {
                foreach (Path3D path in paths)
                {
                    writer.WriteLine(path.ToString());
                }
                writer.Close();
                return true;
            }
            return false;
        }
    }
}
