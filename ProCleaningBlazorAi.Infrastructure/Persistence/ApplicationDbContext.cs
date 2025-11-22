using Microsoft.EntityFrameworkCore;
using ProCleaningBlazorAi.Domain.Entities;

namespace ProCleaningBlazorAi.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Trailer> Trailers { get; set; }
    public DbSet<Platform> Platforms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Konfigurácia Car
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Model).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Plate).IsRequired().HasMaxLength(20);
            entity.Property(e => e.Vin).HasMaxLength(50);
        });

        // Konfigurácia Trailer
        modelBuilder.Entity<Trailer>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Model).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Plate).IsRequired().HasMaxLength(20);
        });

        // Konfigurácia Platform
        modelBuilder.Entity<Platform>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Model).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Plate).IsRequired().HasMaxLength(20);
        });

        // Konfigurácia Role
        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
            entity.Property(e => e.DisplayName).HasMaxLength(100);
        });

        // Konfigurácia User
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
            entity.Property(e => e.LastName).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(200);
            entity.HasIndex(e => e.Email).IsUnique();
            
            // Vzťah User -> Role
            entity.HasOne(d => d.Role)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // SEEDING DAT (Pre EF Core in-memory alebo referenciu)
        SeedData(modelBuilder);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        var adminRoleId = 1;
        var managerRoleId = 2;
        var workerRoleId = 3;
        var adminUserId = Guid.Parse("99999999-9999-9999-9999-999999999999");

        // 1. Role
        modelBuilder.Entity<Role>().HasData(
            new Role { Id = adminRoleId, Name = "Admin", DisplayName = "Administrator" },
            new Role { Id = managerRoleId, Name = "Manager", DisplayName = "Manager" },
            new Role { Id = workerRoleId, Name = "Worker", DisplayName = "Pracovnik" }
        );

        // 2. Admin User
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = adminUserId,
                RoleId = adminRoleId,
                FirstName = "System",
                LastName = "Admin",
                Email = "admin@procleaning.sk",
                PasswordHash = "AQAAAAIAAYagAAAAEK7OPyQtTX9i7/BiIPRlAEzeGTxK5XjBVElUQicMxVM3dt6uvGwoXqP9v1FPqbk3Kg==", // Heslo: "a"
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ValidTo = null
            }
        );
    }
}
