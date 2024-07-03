using ReceptionProject.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReceptionProject.Data.Join_Entity_s
{
    public class RoomInventory
    {
        [Required]
        public int RoomId { get; set; }
        [Required]
        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; }
        [Required]
        public int InventoryItemId { get; set; }
        [Required]
        [ForeignKey(nameof(InventoryItemId))]
        public InventoryItem InventoryItem { get; set; }

        public int Quantity { get; set; } // Quantity of the item in this room
    }
}
