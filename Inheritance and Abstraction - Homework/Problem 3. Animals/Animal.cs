namespace Animals
{
    using System;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;

        public Animal(string name, int age, Gender gender)
            : this(name, age)
        {
            this.Gender = gender;  
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name 
        { 
            get { return this.name; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("The name cannot be null or empty!");
                else
                    this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                    throw new Exception("The age cannot be negative!");
                else
                    this.age = value;
            }
        }

        public Gender Gender
        {
            get;
            set;
        }

        public virtual void ProduceSound()
        { }
    }
}
