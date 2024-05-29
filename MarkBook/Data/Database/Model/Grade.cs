using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("grade")]
	public partial class Grade
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Grade()
		{
			TeacherSubjectGrades = new HashSet<TeacherSubjectGrade>();
			Students = new HashSet<Student>();
			EducationalWorks = new HashSet<EducationalWork>();
		}

		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Column("name")]
		public int Name { get; set; }

		[Column("subname")]
		[StringLength(1)]
		public string Subname { get; set; }

		[Column("teacher_id")]
		public int TeacherId { get; set; }

		public virtual Teacher Teacher { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Student> Students { get; set; }
		public virtual ICollection<TeacherSubjectGrade> TeacherSubjectGrades { get; set;}
		public virtual ICollection<EducationalWork> EducationalWorks { get; set; }
	}
}
