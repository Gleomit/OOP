namespace HomeworkDefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SULSTest
    {
        public static void Main()
        {
            List<Person> personObjects = new List<Person>() 
            {
                new OnsiteStudent("Avram","Bakalina",10,101,5.4,"PHP",10),
                new OnlineStudent("Boiko","Borisov",51,666,6,"C#"),
                new SeniorTrainer("Pesho","Krustoputov",24),
                new JuniorTrainer("Gosho","Kurtev",27),
                new GraduateStudent("Mitko","Slonev",40,134,4.5),
                new DropoutStudent("Desislava","Kremvirshova",15,93,4.99,"Bad language"),
                new CurrentStudent("Temenujka","Margaritova",21,300,5, "Java"),
                new Person("Borislav","Tuhlev",34),
                new Trainer("Gergana","Paqkova",17),
                new Student("Hobit","Frodov",16,111,6)
            };
            CurrentStudent temp;
            var currentStudents =   from person in personObjects.ToArray()
                            where person.GetType().IsSubclassOf(typeof(CurrentStudent)) || 
                                  person.GetType().IsEquivalentTo(typeof(CurrentStudent))
                            orderby (temp = (CurrentStudent)person).AverageGrade
                            select person;

            foreach (Object student in currentStudents)
            {
                Console.WriteLine(student.ToString() + "\n\n");
            }
            Console.Read();
        }
    }
}
