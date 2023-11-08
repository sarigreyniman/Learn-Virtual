namespace LearnVirtual.Entities
{
    public class LearningMatirials:Courses
    {
        public int LearningMatirialsForCourseId { get; set; }
        public string LearningMatirialsDescription { get; set; }

        public LearningMatirials(int learningMatirialsForCourseId, string learningMatirialsDescription)
        {
            LearningMatirialsForCourseId = learningMatirialsForCourseId;
            LearningMatirialsDescription = learningMatirialsDescription;
        }
    }
}
