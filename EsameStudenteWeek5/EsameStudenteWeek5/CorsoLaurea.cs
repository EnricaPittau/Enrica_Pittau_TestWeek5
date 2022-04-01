using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsameStudenteWeek5
{
    internal class CorsoLaurea //Matematica, informatica
    {
        public string Nome { get; set; }
        public int AnniDiCorso { get; set; }
        public int CfuTotali { get; set; }
        public List<ListaCorsi> ListaCorsi { get; set; } = new List<ListaCorsi>();//esami da sostenere a cui si è prenotato
       
        public CorsoLaurea()
        {

        }
        public CorsoLaurea(string nome, int anniDiCorso, int cfutotali)
        {
            Nome = nome;
            AnniDiCorso = anniDiCorso;
            CfuTotali = cfutotali;
            //ListaCorsi = listaCorsi;    
        }
        public void StampaDatiCorsoLaurea()
        {
            Console.WriteLine($"Denominazione: {Nome}\t Durata: {AnniDiCorso}\t CFU totali: {CfuTotali}");
        }
    }
    
}
   

