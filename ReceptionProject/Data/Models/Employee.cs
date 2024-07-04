using ReceptionProject.Data.Enumerators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ReceptionProject.Data.Constants.DataConstants;

namespace ReceptionProject.Data.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(NameLenght)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(NameLenght)]
        public string LastName { get; set; }
        [Required]
        public EmployeeRole Role { get; set; }
        [Required]
        [Column(TypeName = "decimal(7,2)")]
        public decimal Salary { get; set; }
    }
}
