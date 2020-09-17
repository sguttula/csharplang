using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Homework_2
{
    class AppDbContext : DbContext
    {
        private static readonly string connectionString;

        public DbSet<Forum> Forums { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Topic> Topics { get; set; }

        static AppDbContext()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            connectionString = config.GetConnectionString("Default");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
        }
    }
}
