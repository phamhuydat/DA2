namespace Web.Areas.Admin.ViewModels.ExamVM
{
	public class ListStudentTakeExamVM : ListItemBaseVM
	{
		public string Mssv { get; set; }
		public int GroupId { get; set; }
		public string GroupName { get; set; }
		public string Email { get; set; }
		public string FullName { get; set; }
		public double TestScores { get; set; }
		public DateTime StartTime { get; set; }
		public int TotalWorkingTime { get; set; }
		public int NumTSC { get; set; }
	}
}
