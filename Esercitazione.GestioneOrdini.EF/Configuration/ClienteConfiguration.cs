using Esercitazione.GestioneOrdini.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.GestioneOrdini.EF.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(x => x.Nome).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Cognome).HasMaxLength(20).IsRequired();
            builder.Property(x => x.CodiceCliente).IsRequired();

            builder.HasMany(x => x.Ordini).WithOne(x => x.Cliente);
        }
    }
}
