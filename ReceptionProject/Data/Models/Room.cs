using Microsoft.EntityFrameworkCore;
using ReceptionProject.Data.Enumerators;
using System.ComponentModel.DataAnnotations;

namespace ReceptionProject.Data.Models
{
    [Comment("The room of the hotel")]
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsVacant { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public RoomType RoomType { get; set; }
        public List<string> Amenities { get; set; }
        [Required]
        public bool IsClean { get; set; }

    }
}
