using Microsoft.EntityFrameworkCore;
using Mvn.Domain.Entities.v1;

namespace Mvn.Infra.SqlServer.Contexts.v1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContext) : base(dbContext)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
                entity.Property(e => e.FullName).HasMaxLength(255);
                entity.Property(e => e.Document).HasMaxLength(255);
                entity.Property(e => e.Email).HasMaxLength(255);
                entity.Property(e => e.BirthDate).HasColumnType("datetime");
                entity.Property(e => e.Login).HasMaxLength(255);
                entity.Property(e => e.Password).HasMaxLength(255);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
