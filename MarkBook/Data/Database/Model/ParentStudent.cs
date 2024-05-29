using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarkBook.Data.Database.Model
{
	[Table("parent_student")]
	public partial class ParentStudent
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }
		[Column("student_id")]
		public int StudentId { get; set; }
		public virtual Student? Student { get; set; }
		[Column("parent_id")]
		public int ParentId { get; set; }
		public virtual Parent? Parent { get; set; }
	}
}
