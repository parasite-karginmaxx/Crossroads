using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Crossroads.Infrastructure
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<BookingEntity> Booking { get; set; }
        public virtual DbSet<ClientEntity> Client { get; set; }
        public virtual DbSet<EmployeeEntity> Employee { get; set; }
        public virtual DbSet<HotelComplexEntity> HotelComplex { get; set; }
        public virtual DbSet<PositionEntity> Position { get; set; }
        public virtual DbSet<RoomEntity> Room { get; set; }
        public virtual DbSet<RoomTypeEntity> RoomType { get; set; }
        public virtual DbSet<UserEntity> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingEntity>()
                .HasMany(e => e.Client)
                .WithRequired(e => e.Booking1)
                .HasForeignKey(e => e.Booking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BookingEntity>()
                .HasMany(e => e.Room)
                .WithRequired(e => e.Booking1)
                .HasForeignKey(e => e.Booking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeEntity>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Employee1)
                .HasForeignKey(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PositionEntity>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Position1)
                .HasForeignKey(e => e.Position)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomTypeEntity>()
                .HasMany(e => e.Room)
                .WithRequired(e => e.RoomType1)
                .HasForeignKey(e => e.RoomType)
                .WillCascadeOnDelete(false);
        }
    }
}
