using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;

namespace GolfAPI.Data
{
    public class GolfAPIContext : DbContext
    {
        public GolfAPIContext (DbContextOptions<GolfAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ClassLibrary.Models.Player> Player { get; set; } = default!;

        public DbSet<ClassLibrary.Models.Result>? Result { get; set; }
    }
}
