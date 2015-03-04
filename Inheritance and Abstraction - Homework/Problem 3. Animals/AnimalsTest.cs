namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Animals.Cats;

    public class AnimalsTest
    {
        public static void Main()
        {
            Animal[] animals = new Animal[]
            {
                new Frog("booty", 10, Gender.Male),
                new Dog("badass", 18, Gender.Male),
                new Kitten("kitty", 15),
                new Tomcat("pussay", 17),
                new Cat("misterious", 20, Gender.Male)
            };

            Console.WriteLine((from animal in animals select animal.Age).Average());
            Console.ReadKey();
        }
    }
}
