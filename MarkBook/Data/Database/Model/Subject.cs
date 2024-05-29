using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{

    [Table("subject")]
    public partial class Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
			TeacherSubjectGrades = new HashSet<TeacherSubjectGrade>();

		}

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Column("name")]
        public string Name { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<TeacherSubjectGrade> TeacherSubjectGrades { get; set; }

	}
}
