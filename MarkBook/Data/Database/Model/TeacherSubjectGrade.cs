using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{

    [Table("teacher_subject_grade")]
    public partial class TeacherSubjectGrade
    {
		public TeacherSubjectGrade()
		{
			StudentLessons = new HashSet<StudentLesson>();
			Schedules = new HashSet<Schedule>();
			Calendars = new HashSet<Calendar>();
		}
		[Key]
        [Column("id")]
        public int Id { get; set; }

		[Column("subject_id")]
		public int SubjectId { get; set; }
		public virtual Subject Subject { get; set; }

		[Column("teacher_id")]
		public int TeacherId { get; set; }
		public virtual Teacher Teacher { get; set; }

		[Column("grade_id")]
		public int GradeId { get; set; }
		public virtual Grade Grade { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Calendar> Calendars { get; set; }

		public virtual ICollection<Schedule> Schedules { get; set; }

		public virtual ICollection<StudentLesson> StudentLessons { get; set; }
	}
}
