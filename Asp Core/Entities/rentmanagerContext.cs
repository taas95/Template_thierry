using System;
using System.Collections.Generic;
using Gestion_Location.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Gestion_Location.Entities
{
    public partial class rentmanagerContext : DbContext
    {
   
       // public IConfiguration Configuration { get; }

        public rentmanagerContext(DbContextOptions<rentmanagerContext> options)
            : base(options)
        {
           
        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseMySql(Configuration.GetConnectionString("MySql"));
//                //optionsBuilder.UseMySql("Server=localhost;Database=rentmanager;User=taas;Password=3110;");
//            }
//        }
        public DbSet<Proprietaire> Proprietaires { get; set; }
        public DbSet<Appartement> Appartements { get; set; }
        public DbSet<ContratLocation> ContratLocations { get; set; }
        public DbSet<Immeuble> Immeubles { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Payement> Payements { get; set; }
        public DbSet<Retrait> Retraits { get; set; }
        public DbSet<Contrat> Contrats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
