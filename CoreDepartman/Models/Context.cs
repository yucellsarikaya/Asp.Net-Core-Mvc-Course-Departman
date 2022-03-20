using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0F3TA7A; database=corePersonel; Integrated Security=true");
        }

        public DbSet<Departman> Departman { get; set; }
        public DbSet<Personel> Personel { get; set; }
    }
}
