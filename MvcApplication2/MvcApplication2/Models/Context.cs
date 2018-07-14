using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcApplication2.Models
{
    public class Context:DbContext
    {
        public Context():base("DefaultConnection") { }

        public DbSet<pest> pest { get; set; }

        public DbSet<Citrus> Citrus { get; set; }

        public DbSet<ControllingMethod> ControllingMethod { get; set; }

        public DbSet<NaturalEnemy> NaturalEnemy { get; set; }

        public DbSet<NaturalEnemyofPest> NaturalEnemyofPest { get; set; }

        public DbSet<ObservePoint> ObservePoint { get; set; }

        public DbSet<Pesticide> Pesticide { get; set; }

        public DbSet<PesticideManufacturer> PesticideManufacturer { get; set; }

        public DbSet<PesticideToM> PesticideToM { get; set; }

        public DbSet<PesticideToPest> PesticideToPest { get; set; }

        public DbSet<Photos> Photos { get; set; }

        public DbSet<Users> Users { get; set; }
   
    }
}