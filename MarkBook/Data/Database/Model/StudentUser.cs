using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("student_user")]
	public partial class StudentUser
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		[Column("username")]
		public string Username { get; set; }
		[Required]
		[Column("password")]
		public string Password { get; set; }

		[Column("student_id")]
		public int StudentId { get; set; }
		[Required]
		public virtual Student? Student { get; set; }
	}
}
