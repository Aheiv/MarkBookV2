using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MarkBook.Data.Database.Model;

namespace MarkBook.Data.FormModel
{
	public class StudentFormModel
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Patronymic { get; set; }
		public string Gender { get; set; }
		public DateOnly DateOfBirth { get; set; } = DateOnly.FromDateTime(DateTime.Now);
		public string Region { get; set; }
		public string District { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public string House { get; set; }
		public string? Apartment { get; set; }
		public string? PhoneNumber { get; set; }
		public Grade Grade { get; set; } = new Grade();

		public string? Status { get; set; }
		public int GradeId { get; set; }
	}
}
