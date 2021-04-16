using Esercitazione.GestioneOrdini.EF.Configuration;
using Esercitazione.GestioneOrdini.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.GestioneOrdini.EF
{
    public class GestioneContext : DbContext
    {
        //Costruttori
        public GestioneContext() : base() { }
        public GestioneContext(DbContextOptions<GestioneContext> options) : base(options) { }

        //DBSET
        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Ordine> Ordini { get; set; }

        //METODI
        //Metodo di connessione con il DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = true;
                        Initial Catalog = GestioneOrdini; Server =.\SQLEXPRESS");
        }

        //Metodo di creazione del modello
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration<Ordine>(new OrdineConfiguration());
        }

    }
}
