using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("student_lesson")]
	public partial class StudentLesson
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Column("mark")]
		public int? Mark { get; set; }

		[StringLength(30)]
		[Column("appointment")]
		public string? Appointment { get; set; }

		[Column("student_id")]
		public int StudentId {  get; set; }

		[Column("date_of_lesson")]
		public DateOnly Date_Of_Lesson { get; set; }

		public virtual Student? Student { get; set; }

		[Column("teachersubjectgrade_id")]
		public int TeacherSubjectGradeId { get; set; }
		
		public virtual TeacherSubjectGrade? TeacherSubjectGrade { get; set; }

	}
}