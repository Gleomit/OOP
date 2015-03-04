namespace HomeworkDefiningClasses
{
    using System;

    public class Person
    {
        private string name;
        private string email;
        private int age;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {

        }

        public override string ToString()
        {
            return "Name - " + name + "\nAge - " + age.ToString() + "\nEmail - " + (email == null ? "Not entered" : email);
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Trim() == "")
                    throw new ArgumentException("Invalid name!");
                else
                    this.name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 1 || value > 100)
                    throw new ArgumentOutOfRangeException("The number must be in the range (1 - 100)");
                else
                    this.age = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value == null || value.Trim().Contains("@"))
                {
                    this.email = value;
                }
                else
                    throw new ArgumentException("Invalid email!");
            }
        }
    }
}
