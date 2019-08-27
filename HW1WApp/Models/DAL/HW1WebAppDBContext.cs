using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HW1WApp.Models
{
    public partial class HW1WebAppDBContext : DbContext
    {
        public HW1WebAppDBContext()
        {
        }

        public HW1WebAppDBContext(DbContextOptions<HW1WebAppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Master> master { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HW1WebAppDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Master>(entity =>
            {
                entity.ToTable("master");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Value1).HasMaxLength(50);

                entity.Property(e => e.Value2).HasMaxLength(50);
            });
        }
    }
}
