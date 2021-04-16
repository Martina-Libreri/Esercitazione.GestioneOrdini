using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Esercitazione.GestioneOrdini.Entities
{
    [DataContract]
    public class Cliente
    {
        //insersco l'id nel datamember per andare a effettuare il metodo update per WCF
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string CodiceCliente { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Cognome { get; set; }

        public List<Ordine> Ordini { get; set; } = new List<Ordine>();
    }
}
