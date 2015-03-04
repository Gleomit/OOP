using System;
using TheSlum.GameEngine;

namespace TheSlum
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExtendedEngine engine = new ExtendedEngine();
            engine.Run();

            Console.Read();
        }
    }
}
