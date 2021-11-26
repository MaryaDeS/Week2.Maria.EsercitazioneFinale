using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Maria.EsercitazioneFinale
{
    public class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string CodiceFiscale { get; set; }

        public Person()
        {

        }
        //costruttore con parametri
        public Person(string firstName, string secondName, string codicefiscale)
        {
            FirstName = firstName;
            SecondName = secondName;
            CodiceFiscale = codicefiscale;
        }

        public override string ToString()
        {
            return $"[{CodiceFiscale}] - {FirstName} {SecondName}";
        }
    }
 }
