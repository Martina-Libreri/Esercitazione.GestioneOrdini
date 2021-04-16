using Esercitazione.GestioneOrdini.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.GestioneOrdini.Repository
{
    public interface IRepositoryOrdine : IRepository<Ordine>
    {
        IEnumerable<Ordine> listaOrdini();
    }
}
