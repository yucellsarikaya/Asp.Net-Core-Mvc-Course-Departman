using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeCore.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullamiciSifre { get; set; }
    }
}
