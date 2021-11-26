using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Maria.EsercitazioneFinale
{
    internal class Menu
    {
        internal static void Start()
        {
            char choice;

            do
            {
                Console.WriteLine("Scegli un'opzione" +
                    "\n[1] Visualizza tutti gli impiegati" +
                    "\n[2] Mostra Impiegato" +
                    "\n[3] Inserisci un nuovo impiegato" +
                    "\n[4] Elimina un impiegato" +
                    "\n[5] Aggiungi Impiegato" +
                    "\n[Q] Esci");

                //recupero della scelta dell'utente 
                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case 'Q':
                        Console.WriteLine("Operazione conclusa. Ciao");
                        break;
                    default:
                        Console.WriteLine("scelta non valida");
                        break;


                }

            } while (choice != 'Q');
        }
    }
}
