using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarkBook.Data.Database.Model
{

	[Table("student")]
	public partial class Student
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Student()
		{
			StudentLessons = new HashSet<StudentLesson>();
			ParentStudents = new HashSet<ParentStudent>();
		}

		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		[Column("last_name")]
		public string LastName { get; set; }

		[Required]
		[StringLength(255)]
		[Column("first_name")]
		public string FirstName { get; set; }

		[StringLength(255)]
		[Column("patronymic")]
		public string Patronymic { get; set; }

		[Required]
		[StringLength(3)]
		[Column("gender")]
		public string Gender { get; set; }

		[Column("date_of_birth", TypeName = "date")]
		public DateOnly DateOfBirth { get; set; }

		[Required]
		[StringLength(255)]
		[Column("region")]
		public string Region { get; set; }

		[Required]
		[StringLength(255)]
		[Column("district")]
		public string District { get; set; }

		[Required]
		[StringLength(255)]
		[Column("city")]
		public string City { get; set; }

		[Required]
		[StringLength(255)]
		[Column("street")]
		public string Street { get; set; }

		[Required]
		[StringLength(255)]
		[Column("house")]
		public string House { get; set; }

		[StringLength(255)]
		[Column("apartment")]
		public string? Apartment { get; set; }

		[StringLength(12)]
		[Column("phone_number")]
		public string? PhoneNumber { get; set; }

		[StringLength(255)]
		[Column("status")]
		public string? Status { get; set; }

		[Column("grade_id")]
		public int GradeId { get; set; }
		public virtual Grade? Grade { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<StudentLesson> StudentLessons { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ParentStudent> ParentStudents { get; set; }
	}
}
