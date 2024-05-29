using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("teacher_user")]
	public partial class TeacherUser
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		[Column("username")]
		public string Username {  get; set; }
		[Required]
		[Column("password")]
		public string Password { get; set; }

		[Column("teacher_id")]
		public int TeacherId { get; set; }
		public virtual Teacher? Teacher { get; set; }
	}
}
