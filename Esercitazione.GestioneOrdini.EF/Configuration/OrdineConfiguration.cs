using Esercitazione.GestioneOrdini.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.GestioneOrdini.EF.Configuration
{
    public class OrdineConfiguration : IEntityTypeConfiguration<Ordine>
    {
        public void Configure(EntityTypeBuilder<Ordine> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(x => x.Importo).IsRequired();
            builder.Property(x => x.DataOrdine);
            builder.Property(x => x.CodiceProdotto).IsRequired();

            builder.HasOne(x => x.Cliente).WithMany(x => x.Ordini);

        }
    }
}
