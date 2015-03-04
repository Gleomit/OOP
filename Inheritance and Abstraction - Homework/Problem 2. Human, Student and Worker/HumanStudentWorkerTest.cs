namespace HumanStudentAndWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HumanStudentWorkerTest
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("studentFirst1", "studentLast1", "11111"),
                new Student("studentFirst2", "studentLast2", "11112"),
                new Student("studentFirst3", "studentLast3", "11113"),
                new Student("studentFirst4", "studentLast4", "11114"),
                new Student("studentFirst5", "studentLast5", "11115"),
                new Student("studentFirst6", "studentLast6", "11116"),
                new Student("studentFirst7", "studentLast7", "11117"),
                new Student("studentFirst8", "studentLast8", "11118"),
                new Student("studentFirst9", "studentLast9", "11119"),
                new Student("studentFirst10", "studentLast10", "11120")
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("workerFirst1", "workerLast1", 123.54231, 5),
                new Worker("workerFirst2", "workerLast2", 323.575, 10),
                new Worker("workerFirst3", "workerLast3", 423.55, 7),
                new Worker("workerFirst4", "workerLast4", 223.56, 12),
                new Worker("workerFirst5", "workerLast5", 523.51, 16),
                new Worker("workerFirst6", "workerLast6", 723.52, 9),
                new Worker("workerFirst7", "workerLast7", 623.546, 15),
                new Worker("workerFirst8", "workerLast8", 823.543, 20),
                new Worker("workerFirst9", "workerLast9", 923.4, 17),
                new Worker("workerFirst10", "workerLast10", 1123.5, 3)
            };

            students = students.OrderBy(student => student.FaultyNumber).ToList();
            workers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            humans = humans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName).ToList();

            foreach (Human human in humans)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
            Console.ReadKey();
        }
    }
}
