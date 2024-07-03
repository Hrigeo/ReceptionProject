using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReceptionProject.Data.Join_Entity_s;
using ReceptionProject.Data.Models;

namespace ReceptionProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<InventoryItem> Items { get; set; }
        public DbSet<GuestReservation> GuestReservations { get; set; }
        public DbSet<RoomInventory> RoomInventories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new HotelRoomConfiguration());

            modelBuilder.Entity<GuestReservation>()
                .HasKey(gr => new { gr.GuestId, gr.ReservationId });

            modelBuilder.Entity<GuestReservation>()
                .HasOne(gr => gr.Guest)
                .WithMany(g => g.GuestReservations)
                .HasForeignKey(gr => gr.GuestId);

            modelBuilder.Entity<GuestReservation>()
                .HasOne(gr => gr.Reservation)
                .WithMany(r => r.GuestReservations)
                .HasForeignKey(gr => gr.ReservationId);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Room)
                .WithMany(hr => hr.Reservations)
                .HasForeignKey(r => r.RoomId);

            modelBuilder.Entity<RoomInventory>()
                .HasKey(ri => new { ri.RoomId, ri.InventoryItemId });

            modelBuilder.Entity<RoomInventory>()
                .HasOne(ri => ri.Room)
                .WithMany(hr => hr.RoomInventories)
                .HasForeignKey(ri => ri.RoomId);

            modelBuilder.Entity<RoomInventory>()
                .HasOne(ri => ri.InventoryItem)
                .WithMany(ii => ii.RoomInventories)
                .HasForeignKey(ri => ri.InventoryItemId);
        }
    }
}
