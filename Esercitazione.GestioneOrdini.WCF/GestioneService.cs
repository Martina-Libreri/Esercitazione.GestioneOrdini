using Esercitazione.GestioneOrdini.EF.Repository;
using Esercitazione.GestioneOrdini.Entities;
using Esercitazione.GestioneOrdini.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Esercitazione.GestioneOrdini.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class GestioneService : IGestioneService
    {
        private IRepositoryCliente repositoryCliente = new ClienteRepository();

        public bool AddCliente(Cliente cliente)
        {
            return repositoryCliente.Create(cliente);
        }

        public bool DeleteCliente(Cliente cliente)
        {
            return repositoryCliente.Delete(cliente);
        }

        public Cliente GetCliente(int id)
        {
            return repositoryCliente.GetById(id);
        }

        public bool UpdateCliente(Cliente cliente)
        {
            return repositoryCliente.Update(cliente);
        }
    }
}
