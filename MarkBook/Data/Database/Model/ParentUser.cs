using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("parent_user")]
	public partial class ParentUser
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
		[Required]
		[Column("parent_id")]
		public int ParentId { get; set; }
		public virtual Parent? Parent { get; set; }
	}
}