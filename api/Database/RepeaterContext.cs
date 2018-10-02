using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UtahRepeaters.Api.Database.Models;

namespace UtahRepeaters.Api.Database
{
    public class RepeaterContext : DbContext
    {
        public DbSet<Repeater> Repeaters { get; set; }
        public DbSet<Coordinates> Coordinates {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=repeaters.db");
        }
    }
}