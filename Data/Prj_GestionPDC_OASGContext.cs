using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prj_GestionPDC_OASG.Entities;

namespace Prj_GestionPDC_OASG.Data
{
    public class Prj_GestionPDC_OASGContext : DbContext
    {
        public Prj_GestionPDC_OASGContext (DbContextOptions<Prj_GestionPDC_OASGContext> options)
            : base(options)
        {
        }

        public DbSet<Prj_GestionPDC_OASG.Entities.Pais> Pais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Departamento)
                .WithOne(t => t.Pais)
                .HasForeignKey(e => e.Pais_Id);
        }

        public DbSet<Prj_GestionPDC_OASG.Entities.Departamento> Departamento { get; set; }
    }
}
