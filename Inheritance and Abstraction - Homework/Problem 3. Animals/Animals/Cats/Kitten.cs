namespace Animals.Cats
{
    using System;

    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Gender.Female)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kitten");
        }
    }
}
