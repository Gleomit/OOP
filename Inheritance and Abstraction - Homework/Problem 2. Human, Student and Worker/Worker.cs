namespace HumanStudentAndWorker
{
    using System;

    public class Worker : Human
    {
        private double weekSalary;
        private int workHorsPerDay;

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHorsPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Week salary cannot be negative number.");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHorsPerDay; }
            set
            {
                if(value < 0 || value > 24)
                {
                    throw new Exception("Work hours per day cannot be negative number or greater than 24.");
                }
                else
                {
                    this.workHorsPerDay = value;
                }
            }
        }

        public double MoneyPerHour()
        {
            return ((this.WeekSalary / 7) / this.WorkHoursPerDay);
        }
    }
}
