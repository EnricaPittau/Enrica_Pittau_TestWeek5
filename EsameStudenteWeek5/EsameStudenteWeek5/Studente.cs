using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsameStudenteWeek5
{
    internal class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoNascita { get; set; }
        public Immatricolazione Immatricolazione { get; set; } = new Immatricolazione();
        public List<GestioneEsame> EsamiDaSostenere { get; set; } = new List<GestioneEsame>();  //prenotati o passati?  
        public bool RichiestaLaurea { get; set; }

        public Studente()
        {

        }
        public Studente(string nome, string cognome, int annoNascita)
        {

        }
        public void StampaStudente()
        {
            Console.WriteLine($"Studente: Nome: {Nome}, Cognome: {Cognome}, Anno di nascita: {AnnoNascita}, Immatricolazione: {Immatricolazione} ");
        }
    }

}
