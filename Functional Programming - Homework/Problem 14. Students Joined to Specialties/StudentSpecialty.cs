namespace StudentsJoinedToSpecialties
{
    public class StudentSpecialty
    {
        public StudentSpecialty(string specialtyName, long facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }

        public string SpecialtyName { get; private set; }
        public long FacultyNumber { get; private set; }
    }
}
