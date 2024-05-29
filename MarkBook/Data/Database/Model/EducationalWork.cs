using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarkBook.Data.Database.Model
{
	[Table("educational_work")]
	public partial class EducationalWork
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Required]
		[StringLength(225)]
		[Column("theme")]
		public string Theme { get; set; }

		[Required]
		[Column("event_date")]
		public DateOnly EventDate { get; set; }

		[Required]
		[StringLength(255)]
		[Column("event")]
		public string Event { get; set; }

		[Column("grade_id")]
		public int GradeId { get; set; }
		public virtual Grade Grade { get; set; }
	}
}
