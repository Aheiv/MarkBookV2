using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("program_tool")]
	public partial class ProgramTool
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Required]
		[Column("name")]
		public string Name { get; set; }

		[Required]
		[Column("id_program")]
		public int ProgramId { get; set; }

		public virtual Program Program { get; set; }
	}
}
