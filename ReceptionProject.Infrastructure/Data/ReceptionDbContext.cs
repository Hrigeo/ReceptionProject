using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReceptionProject.Data.Join_Entity_s;
using ReceptionProject.Data.Models;

namespace ReceptionProject.Data
{
    public class ReceptionDbContext : IdentityDbContext
    {
        public ReceptionDbContext(DbContextOptions<ReceptionDbContext> options)
            : base(options)
        {
        }
        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<Guest> Guests { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<InventoryItem> Items { get; set; } = null!;
        public DbSet<GuestReservation> GuestReservations { get; set; } = null!;
        public DbSet<RoomInventory> RoomInventories { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new HotelRoomConfiguration());

            modelBuilder.Entity<GuestReservation>()
                .HasKey(gr => new { gr.GuestId, gr.ReservationId });

            modelBuilder.Entity<GuestReservation>()
                .HasOne(gr => gr.Guest)
                .WithMany(g => g.GuestReservations)
                .HasForeignKey(gr => gr.GuestId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GuestReservation>()
                .HasOne(gr => gr.Reservation)
                .WithMany(r => r.GuestReservations)
                .HasForeignKey(gr => gr.ReservationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Room)
                .WithMany(hr => hr.Reservations)
                .HasForeignKey(r => r.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RoomInventory>()
                .HasKey(ri => new { ri.RoomId, ri.InventoryItemId });

            modelBuilder.Entity<RoomInventory>()
                .HasOne(ri => ri.Room)
                .WithMany(hr => hr.RoomInventories)
                .HasForeignKey(ri => ri.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RoomInventory>()
                .HasOne(ri => ri.InventoryItem)
                .WithMany(ii => ii.RoomInventories)
                .HasForeignKey(ri => ri.InventoryItemId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
