using backend.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.DataModel
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=192.168.1.6;Database=bpkb;User id=sa;Password=Sprint1234!;Connect Timeout=30;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<Bpkb> tr_bpkb { get; set; }
        public DbSet<Location> ms_storage_location { get; set; }

    }
}
