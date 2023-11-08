namespace LearnVirtual.Entities
{
    public class Students
    {
        public string StudentName { get; set; }
        public int StudentId { get; set; }
        public bool StudentStatus { get; set; }

        public Students(string studentName, int studentId, bool studentStatus)
        {
            StudentName = studentName;
            StudentId = studentId;
            StudentStatus = studentStatus;
        }
    }
}
