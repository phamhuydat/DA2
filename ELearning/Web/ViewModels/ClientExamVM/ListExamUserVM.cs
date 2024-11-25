using Web.Areas.Admin.ViewModels;

namespace Web.ViewModels.ClientExamVM
{
    public class ListExamUserVM : ListItemBaseVM
    {
        public string ExamName { get; set; }
        public string SubjectName { get; set; }
        public int WorkTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TotalQuestion { get; set; }

        public int IsStatus
        {
            get
            {
                if (DateTime.Now < StartTime)
                {
                    return 0;
                }
                else if (DateTime.Now > EndTime)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }


    }
}
