using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Maria.EsercitazioneFinale.Entities;

namespace Week2.Maria.EsercitazioneFinale
{
    public class Manager: Employee
    {
        public int OrediStraordinario { get; set; }
        public int Salario { get; set; }
        public Manager(string firstName, string secondName, string codicefiscale, string area, int oredistraordinario, int salario) : base(firstName, secondName, codicefiscale, area)
        {
            OrediStraordinario = oredistraordinario;
            Salario = salario;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
