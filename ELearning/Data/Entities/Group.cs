using Data.Entities.Base;

namespace Data.Entities
{
    public class Group : AppEntityBase
    {
        public Group()
        {
            GroupDetails = new HashSet<GroupDetails>();
            HandOutExams = new HashSet<HandOutExam>();
        }
        public string GroupName { get; set; }
        public string InvitationCode { get; set; } // mã mời nhóm
        public int Quantity { get; set; }
        public string Note { get; set; }
        public int AcademicYear { get; set; }      // Năm học
        public int Semester { get; set; }
        public bool Status { get; set; }
        public string Teacher { get; set; }
        public bool Display { get; set; } // hien thi man hinh
        public int SubjectId { get; set; } // FK 

        //fk
        public Subject subject { get; set; }
        public ICollection<GroupDetails> GroupDetails { get; set; }
        public ICollection<HandOutExam> HandOutExams { get; set; }
    }
}
