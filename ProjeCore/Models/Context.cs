using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeCore.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0F3TA7A; database=CoreProje; Integrated Security=true");
        }

        public DbSet<Birim> Birim { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Admin> Admin { get; set; }
    }
}
