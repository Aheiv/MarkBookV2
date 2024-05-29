using MarkBook.Data.Database.Model;
using Microsoft.EntityFrameworkCore;

namespace MarkBook.Data.Database
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
           : base(options)
        {
        }

        public virtual DbSet<Grade> Grades { get; set; }
		public virtual DbSet<EducationalWork> EducationalWorks { get; set; }
		public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<TeacherSubjectGrade> TeacherSubjectGrades { get; set; }
        public virtual DbSet<Student> Students { get; set; }
		public virtual DbSet<ParentStudent> ParentStudents { get; set; }
		public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
		public virtual DbSet<TeacherUser> TeacherUsers { get; set; }
		public virtual DbSet<StudentUser> StudentUsers { get; set; }
		public virtual DbSet<ParentUser> ParentUsers { get; set; }
		public virtual DbSet<QuarterDate> QuarterDates { get; set; }
        public virtual DbSet<StudentLesson> StudentLessons {  get; set; }
		public virtual DbSet<StudyYear> StudyYears { get; set; }
		public virtual DbSet<Calendar> Calendars { get; set; }
	}
}

