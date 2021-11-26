using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Maria.EsercitazioneFinale.Entities;

namespace Week2.Maria.EsercitazioneFinale
{
    public class Stagista : Employee
    {
        public int Month { get; set; } //durata dello stage
        public int Salary { get; set; } //salario di 600 euro
        public Stagista(string firstName, string secondName, string codicefiscale, string area, int month, int salary) : base(firstName, secondName, codicefiscale, area)
        {
            Month = month;
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString()+$"Mesi di tirocinio: {Month}, Salario:{Salary}";
        }

    }

        
    }
