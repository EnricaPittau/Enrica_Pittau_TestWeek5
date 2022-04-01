using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsameStudenteWeek5
{
    internal class ListaCorsi//Moduli del corso di Laurea: analisi1, chimica
    {
        public string Nome { get; set; }
        public int CFU { get; set; }
        public TipoLaurea TipoLaurea { get; set; }


        public ListaCorsi()
        {

        }
        public ListaCorsi(string nome, int cfu, TipoLaurea tipoLaurea)
        {
            Nome = nome;    
            CFU = cfu;
            TipoLaurea = tipoLaurea;
        }
        public void StampaListaCorsi()
        {
            Console.WriteLine($"Nome: {Nome} \t CFU: {CFU} \t Appartiene al corso di Laurea di {TipoLaurea}");
        }
    }
    enum TipoLaurea
    {
        Ingegneria = 1,
        Matematica = 2,
        Fisica = 3,
        Informatica = 4,
        Lettere = 5
    }
    
}


