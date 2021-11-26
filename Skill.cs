namespace Week2.Maria.EsercitazioneFinale
{
    public class Skill
    {
        public Skill()
        {
        }

        public string Codice { get; set; }
        public string Descrizione { get; set; }

        public Skill(string codice, string descrizione)
        {
            Codice = codice;
            Descrizione = descrizione;
        }

        public override string ToString()
        {
            return base.ToString() + $"Skill: {Descrizione}";
        }

    }
}
