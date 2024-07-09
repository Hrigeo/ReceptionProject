using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReceptionProject.Data.Enumerators;
using ReceptionProject.Data.Join_Entity_s;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ReceptionProject.Data.Constants.DataConstants;

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
        [Column(TypeName = "decimal(7,2)")]
        [Range(typeof(decimal), RoomPriceMinimum, RoomPriceMaximum, ConvertValueInInvariantCulture = true)]
        public double Price { get; set; }
        [Required]
        public RoomType RoomType { get; set; }
        public List<Amenities> Amenities { get; set; }=new List<Amenities>();
        public List<RoomInventory> RoomInventories { get; set; }= new List<RoomInventory>();
        [Required]
        public bool IsClean { get; set; }

        public List<Reservation> Reservations { get; set; }=new List<Reservation>();

    }
    public class HotelRoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(hr => hr.Amenities)
                .HasConversion(
                    v => string.Join(',', v), // Convert List<Amenities> to string
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(e => Enum.Parse<Amenities>(e)).ToList() // Convert string to List<Amenities>
                );
        }
    }
}
