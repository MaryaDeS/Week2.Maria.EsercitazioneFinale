using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Maria.EsercitazioneFinale.Entities
{
    public class technician : Employee
    {
        public technician()
        {

        }
        public int PagaOraria { get; set; }
        public int OrediLavoro { get; set; }
        
        public technician(string firstName, string secondName, string codicefiscale, string area, int pagaoraria, int oredilavoro) : base(firstName, secondName, codicefiscale, area)
        {
            PagaOraria = pagaoraria;
            OrediLavoro = oredilavoro;
        }

        public override string ToString()
        {
            return base.ToString()+$"Paga Oraria: {PagaOraria}, Ore di Lavoro: {OrediLavoro}";
        }
    }
}
