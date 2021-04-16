using Esercitazione.GestioneOrdini.Entities;
using Esercitazione.GestioneOrdini.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercitazione.GestioneOrdini.EF.Repository
{
    public class OrdineRepository : IRepositoryOrdine
    {
        private readonly GestioneContext ctx;

        public OrdineRepository() : this(new GestioneContext()) { }
        public OrdineRepository(GestioneContext ctx)
        {
            this.ctx = ctx;
        }

        public bool Create(Ordine item)
        {
            try 
            { 
                if (item == null)
                {
                    return false;
                }

                var cliente = ctx.Clienti.Find(item.Cliente.Id);
                cliente.Ordini.Add(item);

                item.Cliente = cliente;

                ctx.Ordini.Add(item);
                ctx.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Ordine item)
        {
            try
            {            
                if (item == null)
                {
                    return false;
                }
                ctx.Ordini.Remove(item);
                ctx.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Ordine GetById(int id)
        {
            try 
            { 
                if (id < 0)
                {
                    return null;
                }
                var ordine = ctx.Ordini.Find(id);

                return ordine;
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<Ordine> listaOrdini()
        {
            try
            {
                return ctx.Ordini.ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool Update(Ordine item)
        {
            if (item == null)
            {
                return false;
            }
            try 
            { 
                var ordine = ctx.Ordini.Find(item.Id);
                if (ordine == null)
                {
                    return false;
                }
                var cliente = ctx.Clienti.Find(item.Cliente.Id);
                ctx.Ordini.Remove(ordine);

                item.Cliente = cliente;
                ctx.Ordini.Add(item);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
