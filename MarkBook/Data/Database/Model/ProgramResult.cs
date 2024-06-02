using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("program_result")]
	public partial class ProgramResult
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Required]
		[Column("course")]
		public string Course { get; set; }

		[Required]
		[Column("result")]
		public string Result { get; set; }

		[Required]
		[Column("id_program")]
		public int ProgramId {  get; set; }

		public virtual Program Program { get; set; }
	}
}
