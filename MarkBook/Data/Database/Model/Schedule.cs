using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace MarkBook.Data.Database.Model
{

    [Table("Schedule")]
    public partial class Schedule
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(12)]
        [Column("weekday")]
        public string Weekday { get; set; }
            
        [Column("number")]
        public int Number { get; set; }

        [Column("teacher_subject_grade_id")]
        public int TeacherSubjectGradeId { get; set; }

		public virtual TeacherSubjectGrade TeacherSubjectGrade { get; set; }
    }
}
