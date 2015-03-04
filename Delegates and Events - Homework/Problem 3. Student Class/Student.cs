namespace StudentClass
{
    using System;

    delegate void OnProperyChangeHandler(object sender, PropertyChangedEventArgs eventArgs);

    class Student
    {
        private string name;
        private int age;
        public event OnProperyChangeHandler PropertyChanged;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, eventArgs);
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(value != null)
                {
                    PropertyChangedEventArgs eventArgs = new PropertyChangedEventArgs("Name", this.Name, value);
                    this.name = value;
                    this.OnPropertyChanged(eventArgs);
                }
                else
                {
                    throw new ArgumentException("Name cannot be null.");
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The age cannot be negative!");
                }
                else
                {
                    PropertyChangedEventArgs eventArgs = new PropertyChangedEventArgs("Age", this.Age.ToString(), value.ToString());
                    this.age = value;
                    this.OnPropertyChanged(eventArgs);
                }
            }
        }
    }
}
