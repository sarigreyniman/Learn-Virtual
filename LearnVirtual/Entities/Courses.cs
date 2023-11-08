namespace LearnVirtual.Entities
{
    public class Courses
    {
        public string CourseName { get; set; }
        public int CourseId { get; set; }
        public List<Students> StudentsInTheCourse { get; set; }
       
    }
}
