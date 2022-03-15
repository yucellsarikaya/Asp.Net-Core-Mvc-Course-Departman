using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Models
{
    public class Context : DbContext
    {
        public DbSet<Departman> Departman { get; set; }
        public DbSet<Personel> Personel { get; set; }
    }
}
