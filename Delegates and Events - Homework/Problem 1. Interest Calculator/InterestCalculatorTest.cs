namespace InterestCalculator
{
    using System;

    public class InterestCalculatorTest
    {
        public static double GetSimpleInterest(double sum, double interest, int years)
        {
            return sum * (1 + interest * years);
        }

        public static double GetCompoundInterest(double sum, double interest, int years)
        {
            return sum * Math.Pow((1 + interest / 12), years * 12);
        }

        public static void Main()
        {
            InterestCalculator compountInterest = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            InterestCalculator simpleInterest = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine("Compount interest - {0:.0000}", compountInterest.Calculate());
            Console.WriteLine("Simple interest - {0:.0000}", simpleInterest.Calculate());

            Console.Read();
        }
    }
}
