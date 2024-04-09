using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class GolfContext : DbContext
    {
        public GolfContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GolfAPI.Data;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<ClassLibrary.Models.Player> Player { get; set; } = default!;

        public DbSet<ClassLibrary.Models.Result>? Result { get; set; }
    }
}
