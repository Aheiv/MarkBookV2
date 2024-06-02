using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("section_theme")]
	public partial class SectionTheme
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Required]
		[Column("name")]
		public string Name { get; set; }

		[Required]
		[Column("hours")]
		public int Hours { get; set; }

		[Required]
		[Column("description")]
		public string Description { get; set; }

		[Required]
		[Column("id_program_section")]
		public int ProgramSectionId { get; set; }

		public virtual ProgramSection ProgramSection { get; set; }
	}
}
