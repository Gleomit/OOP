namespace HomeworkStaticMembersAndNamespaces
{
    using System;
    using System.Collections.Generic;

    public class Paths
    {
        public static void Main()
        {
            List<Path3D> paths = Storage.LoadPaths("F:\\test");
            Console.WriteLine(paths[0].ToString());
            Storage.SavePaths("F:\\testTwo", paths);
            Console.ReadKey();
        }
    }
}
