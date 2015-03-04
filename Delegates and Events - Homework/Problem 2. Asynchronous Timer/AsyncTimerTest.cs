namespace AsynchronousTimer
{
    using System;

    public class AsyncTimerTest
    {
        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        public static void Main()
        {
            AsyncTimer timer = new AsyncTimer(PrintHello, 4, 300);

            Console.Read();
        }
    }
}
