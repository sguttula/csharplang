using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Lab4
{
    class AppDbContext : DbContext
    {
        private static readonly string ConnectionString = @"Server=ecst-csproj2.calstatela.edu,6301;Database=cs4540stu08;User ID=cs4540stu08;Password=2.KCVRFQ";

        static AppDbContext()
        {
            var config = new ConfigurationBuilder().Build();
            ConnectionString = config.GetConnectionString(@"Server=ecst-csproj2.calstatela.edu,6301;Database=cs4540stu08;User ID=cs4540stu08;Password=2.KCVRFQ");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ecst-csproj2.calstatela.edu,6301;Database=cs4540stu08;User ID=cs4540stu08;Password=2.KCVRFQ");
        }
        public DbSet<Person> Persons { get; set; }
    }
}