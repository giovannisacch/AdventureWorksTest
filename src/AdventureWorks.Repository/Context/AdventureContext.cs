using AdventureWorks.Repository.Model;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Context
{
    public class AdventureContext : DbContext
    {
    //    public AdventureContext()
    //    {
    //    }
        public AdventureContext(DbContextOptions dbOptions)
            :base(dbOptions)
        {
                
        }
        public DbSet<Model.Competidor> Competidor { get; set; }
        public DbSet<PistaCorrida> PistaCorrida { get; set; }
        public DbSet<HistoricoCorrida> HistoricoCorrida { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ForSqlServerUseIdentityColumns();
            modelbuilder.HasDefaultSchema("AdventureWorks");

            modelbuilder.Entity<PistaCorrida>(x =>
           { 
               x.HasMany(p => p.Corridas)
                .WithOne(c => c.PistaCorrida)
                .OnDelete(DeleteBehavior.Cascade);
           });

            modelbuilder.Entity<PistaCorrida>()
                .Property(p => p.Descricao).HasMaxLength(50).IsRequired();


            modelbuilder.Entity<Model.Competidor>(x =>
            {
                x.HasMany(c => c.Corridas)
                .WithOne(c => c.Competidor)
                .OnDelete(DeleteBehavior.Cascade);

                x.Property(c => c.Nome).HasMaxLength(150).IsRequired();
                x.Property(c => c.Sexo).IsRequired();
                x.Property(c => c.TemperaturaMediaCorpo).IsRequired();
                x.Property(c => c.Peso).IsRequired();
                x.Property(c => c.Altura).IsRequired();
            });

            modelbuilder.Entity<HistoricoCorrida>(x =>
            {
                x.HasOne(h => h.Competidor)
                .WithMany(c => c.Corridas)
                .HasForeignKey(h => h.CompetidorId);

                x.HasOne(h => h.PistaCorrida)
                .WithMany(c => c.Corridas)
                .HasForeignKey(h => h.PistaCorridaId);

                x.Property(h => h.DataCorrida).IsRequired();
                x.Property(h => h.TempoGasto).IsRequired();
            });
        }
    }
}
