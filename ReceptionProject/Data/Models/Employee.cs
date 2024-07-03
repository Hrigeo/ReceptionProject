using ReceptionProject.Data.Enumerators;
using System.ComponentModel.DataAnnotations;

namespace ReceptionProject.Data.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public EmployeeRole Role { get; set; }
        [Required]
        public double Salary { get; set; }
    }
}
