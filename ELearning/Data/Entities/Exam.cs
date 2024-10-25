using Data.Entities.Base;

namespace Data.Entities
{
    public class Exam : AppEntityBase
    {
        public Exam()
        {
            examDetails = new HashSet<ExamDetails>();
            automaticExams = new HashSet<AutomaticExam>();
            results = new HashSet<Result>();
            handOutExams = new HashSet<HandOutExam>();
        }
        public int SubjectId { get; set; }
        public string Title { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public bool ShowWork { get; set; }      // Display
        public bool SeeAnswer { get; set; }
        public bool MixQuestion { get; set; }
        public bool MixAnswer { get; set; }
        public bool SubmitAndExit { get; set; } // Exit Page When Submitting
        public int EQCount { get; set; }        // number of easy questions
        public int MQCount { get; set; }        // number of medium questions
        public int HQCount { get; set; }        // number of hard questions
        public bool Status { get; set; }

        public Subject Subject { get; set; }
        public ICollection<ExamDetails> examDetails { get; set; }
        public ICollection<AutomaticExam> automaticExams { get; set; }
        public ICollection<Result> results { get; set; }
        public ICollection<HandOutExam> handOutExams { get; set; }
    }
}