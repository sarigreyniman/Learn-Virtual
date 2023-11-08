namespace LearnVirtual.Entities
{
    public class Lecturers
    {
        public string LecturerName { get; set; }
        public int LecturerId { get; set; }
        public bool LecturerStatus { get; set; }

        public Lecturers(string lecturerName, int lecturerId, bool lecturerStatus)
        {
            LecturerName = lecturerName;
            LecturerId = lecturerId;
            LecturerStatus = lecturerStatus;
        }
    }
}
