using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarkBook.Data.Database.Model
{

	[Table("parent")]
	public partial class Parent
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Parent()
		{
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

		[Column("workplace")]
		public string? Workplace { get; set; }

		[Column("profession")]
		public string Profession { get; set; }


		[Required]
		[StringLength(12, ErrorMessage = "Номер телефона не может быть более 12 символов")]
		[Column("phone_number")]
		public string? PhoneNumber { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ParentStudent> ParentStudents { get; set; }

	}
}
