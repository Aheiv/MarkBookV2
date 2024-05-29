using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("quarter_date")]
	public partial class QuarterDate
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Required]
		[Column("number")]
		public int Number {  get; set; }

		[Column("date_of_start", TypeName = "date")]
		public DateOnly DateOfStart { get; set; }

		[Column("date_of_end", TypeName = "date")]
		public DateOnly DateOfEnd { get; set; }

		[Column("study_year_id")]
		public int StudyYearId {  get; set; }
		public virtual StudyYear StudyYear { get; set; }
	}
}
