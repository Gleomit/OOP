namespace FractionCalculator
{
    using System;

    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; }
            set
            {
                if (value < long.MinValue || value > long.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("The numerator must be in the range (" 
                        + long.MinValue + " - " + long.MaxValue + ")");
                }
                else
                {
                    this.numerator = value;
                }
            }
        }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value < long.MinValue || value > long.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("The denominator must be in the range ("
                        + long.MinValue + " - " + long.MaxValue + ")");
                }
                else if (value == 0)
                {
                    throw new ArgumentException("The denominator cannot be 0");
                }
                else
                {
                    this.denominator = value;
                }
            }
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            return new Fraction((first.Numerator * second.Denominator)
                + (second.Numerator * first.Denominator), first.Denominator * second.Denominator);
        }

        public static Fraction operator -(Fraction first, Fraction second)
        {
            return new Fraction((first.Numerator * second.Denominator) 
                - (second.Numerator * first.Denominator), first.Denominator * second.Denominator);
        }

        public override string ToString()
        {
            return ((decimal)this.Numerator / (decimal)this.Denominator).ToString();
        }
    }
}
