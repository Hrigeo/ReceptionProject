using ReceptionProject.Data.Join_Entity_s;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ReceptionProject.Data.Constants.DataConstants;

namespace ReceptionProject.Data.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
        public List<GuestReservation> GuestReservations { get; set; }=new List<GuestReservation>();
        [Required]
        public int RoomId { get; set; }

        [Required]
        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; } = null!;
        [Required]
        [Column(TypeName ="decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        public bool IsPaid { get; set; }

    }
}
