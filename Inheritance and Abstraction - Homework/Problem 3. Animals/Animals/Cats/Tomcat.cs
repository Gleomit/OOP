namespace Animals.Cats
{
    using System;

    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Gender.Male)
        {
            
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Tomcat");
        }
    }
}
