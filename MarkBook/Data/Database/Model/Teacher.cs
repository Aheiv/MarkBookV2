using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{

	[Table("teacher")]
	public partial class Teacher
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Teacher()
		{
			TeacherSubjectGrades = new HashSet<TeacherSubjectGrade>();
			Grades = new HashSet<Grade>();
		}

		[Key]
		public int id { get; set; }

		[Required]
		[StringLength(255)]
		public string last_name { get; set; }

		[Required]
		[StringLength(255)]
		public string first_name { get; set; }

		[StringLength(255)]
		public string patronymic { get; set; }


		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<TeacherSubjectGrade> TeacherSubjectGrades { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Grade> Grades { get; set; }
	}
}
