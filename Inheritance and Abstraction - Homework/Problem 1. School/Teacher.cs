namespace School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People
    {
        private List<Discipline> disciplines;

        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.disciplines = disciplines;
        }
    }
}
