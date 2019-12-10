using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppliAsp.NET.Models
{
    public class ProjetDb:DbContext
    {
        public DbSet<Projet> Projets { get; set; }
        public DbSet<Employe> Employes { get; set;}
        public DbSet<Commentaire> Commentaies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commentaire>().HasOptional(x => x.Projet).WithMany(x => x.Commentaires);
            modelBuilder.Entity<Employe>().HasMany(x => x.Projets).WithMany(x => x.Employes);

            base.OnModelCreating(modelBuilder);
        }
    }
}