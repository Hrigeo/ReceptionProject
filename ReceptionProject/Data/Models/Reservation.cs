using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReceptionProject.Data.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
        public List<Guest> RoomGuests { get; set; }
        [ForeignKey(nameof(Room))]
        public int RoomID { get; set; }
        public double TotalPrice { get; set; }
        public bool IsPaid { get; set; }

    }
}
