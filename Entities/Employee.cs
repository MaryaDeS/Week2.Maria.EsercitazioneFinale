using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Maria.EsercitazioneFinale.Entities
{
    public class Employee : Person
    {
        public Employee()
        {

        }
        //impiegato è una classe figlia di person ed ha anche Settore Calcolo stipendio e Lista di skills

        public string Area { get; set; }

        //public decimal GetAmountSalary();

        public Employee(string firstName, string secondName, string codicefiscale, string area)
            : base(firstName, secondName, codicefiscale)
        {
            Area = area;
            
        }


        public override string ToString()
        {
            return base.ToString() + $"Area: {Area}";
        }
    }
}
