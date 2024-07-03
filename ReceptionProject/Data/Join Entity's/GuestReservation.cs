using ReceptionProject.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReceptionProject.Data.Join_Entity_s
{
    public class GuestReservation
    {
        [Required]
        public int GuestId { get; set; }
        [Required]
        [ForeignKey(nameof(GuestId))]
        public Guest Guest { get; set; }
        [Required]
        public int ReservationId { get; set; }
        [Required]
        [ForeignKey(nameof(ReservationId))]
        public Reservation Reservation { get; set; }
    }
}
