namespace LearnVirtual.Entities
{
    public class Tasks:Courses
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime AssignmentSubmissionDate { get; set; }
        public int TaskForCourseId { get; set; }

        public Tasks(string taskName, string taskDescription, DateTime assignmentSubmissionDate, int taskForCourseId)
        {
            TaskName = taskName;
            TaskDescription = taskDescription;
            AssignmentSubmissionDate = assignmentSubmissionDate;
            TaskForCourseId = taskForCourseId;
        }
    }
}
