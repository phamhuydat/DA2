using Data.Entities.Base;

namespace Data.Entities
{
    public class ExamDetails : AppEntityBase
    {
        public int ExamId { get; set; }
        public int QuestionId { get; set; }

        public Exam Exam { get; set; }
        public Question Question { get; set; }
    }
}