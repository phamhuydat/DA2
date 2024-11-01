using Data.Entities;

namespace Web.Areas.Admin.ViewModels.QuestionVM
{
    public class ListQuestionVM : ListItemBaseVM
    {
        public string Content { get; set; }
        public int Level { get; set; }
        public string SubjectName { get; set; }
        public string ChapterName { get; set; }

        public ICollection<Answer> Answers { get; set; }

    }
}
