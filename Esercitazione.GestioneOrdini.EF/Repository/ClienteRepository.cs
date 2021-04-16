using Esercitazione.GestioneOrdini.Entities;
using Esercitazione.GestioneOrdini.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.GestioneOrdini.EF.Repository
{
    public class ClienteRepository : IRepositoryCliente
    {
        private readonly GestioneContext ctx;

        public ClienteRepository() : this(new GestioneContext()) { }
        public ClienteRepository(GestioneContext ctx)
        {
            this.ctx = ctx;
        }
        public bool Create(Cliente item)
        {
            try
            {
                if (item == null)
                {
                    return false;
                }

                ctx.Clienti.Add(item);
                ctx.SaveChanges();


                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Cliente item)
        {
            try
            {
                if (item == null)
                {
                    return false;
                }

                var cliente = ctx.Clienti.Find(item.Id);
                if(cliente != null)
                {
                    ctx.Clienti.Remove(cliente);
                    ctx.SaveChanges();

                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public Cliente GetById(int id)
        {

            if (id < 0)
            {
                return null;
            }
            try
            {
                var cliente = ctx.Clienti.Find(id);
                return cliente;
            }
            catch
            {
                return null;
            }
        }

        public bool Update(Cliente item)
        {
            try
            {
                if (item == null)
                {
                    return false;
                }

                var cliente = ctx.Clienti.Find(item.Id);

                if(cliente == null)
                {
                    return false;
                }

                ctx.Clienti.Remove(cliente);
                ctx.Clienti.Add(item);
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
