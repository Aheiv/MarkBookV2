using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("program_education_material")]
	public partial class ProgramEducationMaterial
	{
		[Key]
		[Column("id")]
		public int Id { get; set; }
		
		[Required]
		[Column("type")]
		public string Type { get; set; }

		[Required]
		[Column("description")]
		public string Description { get; set; }

		[Required]
		[Column("id_program")]
		public int ProgramId { get; set; }

		public virtual Program Program { get; set; }

	}
}
