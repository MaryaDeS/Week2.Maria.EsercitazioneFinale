using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Maria.EsercitazioneFinale.Entities;

namespace Week2.Maria.EsercitazioneFinale
{
    public static class EmployeeManager
    {
        //Lista Skills Impiegato
        public static List<Skill> skills = new()
        {
            new Skill()
            {
                Codice = "C1",
                Descrizione = "Time Manager"
            },

            new Skill()
            {
                Codice= "C2",
                Descrizione= "TeamWork"
            },

            new Skill()
            {
                Codice = "C3",
                Descrizione = "Proattività"
            },

            new Skill()
            {
                Codice = "C4",
                Descrizione = "Precisione"
            },

            new Skill()
            {
                Codice = "C5",
                Descrizione = "Organizzazione"
            },

            new Skill()
            {
                Codice = "C5",
                Descrizione = "Organizzazione"
            },
        };

        //lista di impiegati (stagisti, tecnici, manager)

        public static List<Employee> employees = new List<Employee>()
        {
            new technician ()
            {
                FirstName = Mario
                SecondName
            }
        };
    }
        
}
           
