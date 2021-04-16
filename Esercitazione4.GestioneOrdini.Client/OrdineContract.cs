using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione4.GestioneOrdini.Client
{
    public class OrdineContract
    {
        public int Id { get; set; }
        public DateTime DataOrdine { get; set; }
        public string CodiceProdotto { get; set; }
        public decimal Importo { get; set; }

    }
}
