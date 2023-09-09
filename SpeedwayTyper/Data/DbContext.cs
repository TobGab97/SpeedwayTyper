using Microsoft.EntityFrameworkCore;
using SpeedwayTyper.Data.Models;

namespace SpeedwayTyper.Data
{
    public class TyperDbContext : DbContext
    {
        public TyperDbContext(DbContextOptions<TyperDbContext> options)
           : base(options)
        {
        }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });
        }
    }
}
