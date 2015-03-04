namespace CompanyHierarchy
{
    using System;
    using CompanyHierarchy.Enumerations;
    using CompanyHierarchy.Interfaces;

    class Project : IProject
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private State state;

        public Project(string projectName, DateTime projectStartDate, string details)
        {
            
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The project name cannot be null or empty.");
                }
                else
                {
                    this.projectName = value;
                }
            }
        }

        public DateTime ProjectStartDate
        {
            get { return this.projectStartDate; }
            set
            {
                this.projectStartDate = value;
            }
        }

        public State State
        {
            get { return this.state; }
        }

        public void CloseProject()
        {
            this.state = State.Closed;
        }

        public override string ToString()
        {
            return "I am a project!";
        }
    }
}
