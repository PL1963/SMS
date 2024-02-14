using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models.StdentModel
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }    

        public string CourseName { get; set; }

        public decimal Percentage { get; set; }

        public int YearOfPassing { get; set; }

        public string UniversityName { get; set; }       


        // public List<Qualification> Qualifications { get; set; }
    }
}
