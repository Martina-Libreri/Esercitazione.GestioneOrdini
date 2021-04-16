using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Esercitazione.GestioneOrdini.Entities
{
    [DataContract]
    public class Ordine
    {
        public int Id { get; set; }
        [DataMember]
        public DateTime DataOrdine { get; set; } = DateTime.Now;
        [DataMember]
        public string CodiceProdotto { get; set; }
        [DataMember]
        public decimal Importo { get; set; }

        public Cliente Cliente { get; set; }
    }
}
