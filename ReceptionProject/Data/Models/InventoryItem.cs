using ReceptionProject.Data.Join_Entity_s;
using System.ComponentModel.DataAnnotations;

namespace ReceptionProject.Data.Models
{
    public class InventoryItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        //Price
        public List<RoomInventory> RoomInventories { get; set; }=new List<RoomInventory>();
    }
}
