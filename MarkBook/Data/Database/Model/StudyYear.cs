using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("study_year")]
	public partial class StudyYear
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }
		[Required]
		[StringLength(9)]
		[Column("years")]
		public string Years { get; set; }

		public virtual ICollection<QuarterDate> QuarterDates { get; set; }
	}
}
