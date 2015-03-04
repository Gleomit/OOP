namespace HomeworkExceptionHandling
{
    using System;

    public class SquareRoot
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            try
            {
                int number = Convert.ToInt32(input);
                if (number < 0)
                {
                    throw new Exception("The number cannot be negative!");
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(number));
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");   
            }
            Console.ReadLine();
        }
    }
}
