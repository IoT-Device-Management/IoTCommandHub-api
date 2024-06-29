using IotCommandHubEFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IotCommandHubEFLibrary.DataAcess
{
    public class UserDataContext(DbContextOptions<UserDataContext> options, IConfiguration configuration) : DbContext(options)
    {
        public IConfiguration _configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}