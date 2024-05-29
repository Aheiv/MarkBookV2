using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarkBook.Data.Database.Model
{
	[Table("calendar")]
	public partial class Calendar
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Required]
		[Column("number")]
		public int Number { get; set; }

		[Required]
		[StringLength(225)]
		[Column ("theme")]
		public string Theme { get; set; }

		[Required]
		[StringLength(255)]
		[Column("about")]
		public string About { get; set; }

		[Required]
		[StringLength(255)]
		[Column("homework")]
		public string Homework { get; set; }

		[Required]
		[Column("completion")]
		public bool Completion { get;set; }

		[Column("teachersubjectgrade_id")]
		public int TeacherSubjectGradeId { get; set; }
		public virtual TeacherSubjectGrade TeacherSubjectGrade { get; set; }
	}
}
