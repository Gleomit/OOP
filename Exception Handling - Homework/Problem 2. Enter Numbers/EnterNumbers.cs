namespace HomeworkExceptionHandling
{
    using System;

    public class EnterNumbers
    {
        public static void Main()
        {
            int start = 1;
            int counter = 1;
            
            while (counter <= 10)
            {
                Console.WriteLine("a" + counter + "(" + start + " - 100):");
                int[] result = ReadNumber(start, 100);
                if(result[0] == 0 && result[1] < 99)
                {
                    start = result[1];
                    counter++;   
                }
                else if(result[0] == 0 && result[1] == 99)
                {
                    counter = 12;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            if (counter == 11)
            {
                Console.WriteLine("You've entered 10 numbers! Congratulations!");
            }
            else if (counter == 12)
            {
                Console.WriteLine("There are no more possible numbers to enter!");
            }
            Console.ReadLine();
        }

        public static int[] ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            int result = 0;
            int number = 0;
            try
            {
                number = Convert.ToInt32(input);
                if (number <= start || number >= end)
                {
                    result = 1;
                    throw new Exception("The number must be in the range (" + start.ToString() + " - " + end.ToString() + ")!");
                }
            }
            catch (Exception exception)
            {
                if (result == 1)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            if (result == 1)
            {
                return new int[]{1, 1};
            }
            else
            {
                return new int[] {0, number};
            }
        }
    }
}
