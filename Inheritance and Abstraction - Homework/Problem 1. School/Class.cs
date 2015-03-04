namespace School
{
    using System;
    using System.Collections.Generic;

    public class Class : IDetailable
    {
        private List<Teacher> teachers;
        private string uniqueTextIdentifier;

        public Class(string uniqueTextIdentifier, List<Teacher> teachers) 
        {
            this.teachers = teachers;
            this.uniqueTextIdentifier = uniqueTextIdentifier;
        }

        public string TextIdentifier
        {
            get
            {
                return this.uniqueTextIdentifier;
            }
        }

        public string Details
        {
            get;
            set;
        }
    }
}
