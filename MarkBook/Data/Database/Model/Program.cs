using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("program")]
	public partial class Program
	{

		public Program() { 
			ProgramTools = new HashSet<ProgramTool>();
			ProgramResults = new HashSet<ProgramResult>();
			ProgramEducationMaterials = new HashSet<ProgramEducationMaterial>();
			ProgramSections = new HashSet<ProgramSection>();
		}

		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Required]
		[Column("name")]
		public string Name { get; set; }

		[Required]
		[Column("id_teacher_subject_grade")]
		public int TeacherSubjectGradeId { get; set; }
		public virtual TeacherSubjectGrade TeacherSubjectGrade { get; set; }

		public virtual ICollection<ProgramTool> ProgramTools { get; set; }
		public virtual ICollection<ProgramResult> ProgramResults { get; set; }
		public virtual ICollection<ProgramEducationMaterial> ProgramEducationMaterials { get;}
		public virtual ICollection<ProgramSection> ProgramSections { get; set; }

	}
}
