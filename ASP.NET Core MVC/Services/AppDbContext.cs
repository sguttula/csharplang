using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using HW3.Models;

namespace HW3
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        private static readonly string ConnectionString;

        public DbSet<Forums> HW3Forums { get; set; }
        public DbSet<Topics> HW3Topics { get; set; }
        public DbSet<Replies> HW3Replies { get; set; }
    }
}
