using Microsoft.EntityFrameworkCore;
using UserAPI.Models.Users;

namespace UserAPI.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Vardenis",
                    LastName = "Pavardenis",
                    Email = "Vardenis@Pavardenis.com",
                    Phone = "86******1"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Jonas",
                    LastName = "Jonaitis",
                    Email = "Jonas@Jonaitis.com",
                    Phone = "86******2"
                },
                new User
                {
                    Id = 3,
                    FirstName = "Petras",
                    LastName = "Petraitis",
                    Email = "Petras@Petraitis.com",
                    Phone = "86******3"
                }
            );
        }
    }
}
