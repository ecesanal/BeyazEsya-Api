using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BeyazEsyaProject.Models
{
    public class BeyazContext :DbContext
    {
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<CamasirMakinesi> CamasirMakinesi { get; set; }
        public virtual DbSet<Sogutucu> Sogutucu { get; set; }
    }
}