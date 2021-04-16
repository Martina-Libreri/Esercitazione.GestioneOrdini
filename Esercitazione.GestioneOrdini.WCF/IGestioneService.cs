using Esercitazione.GestioneOrdini.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Esercitazione.GestioneOrdini.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGestioneService
    {
        [OperationContract]
        bool AddCliente(Cliente cliente);

        [OperationContract]
        bool DeleteCliente(Cliente cliente);

        [OperationContract]
        bool UpdateCliente(Cliente cliente);

        [OperationContract]
        Cliente GetCliente(int id);
    }

}
