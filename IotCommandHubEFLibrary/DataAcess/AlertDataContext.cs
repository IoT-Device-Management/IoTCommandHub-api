using IotCommandHubEFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IotCommandHubEFLibrary.DataAcess
{
    public class AlertDataContext(DbContextOptions<AlertDataContext> options, IConfiguration configuration) : DbContext(options)
    {
        public IConfiguration _configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        public DbSet<Alert> Alerts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
