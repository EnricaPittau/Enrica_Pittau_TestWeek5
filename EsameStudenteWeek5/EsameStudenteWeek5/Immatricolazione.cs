using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsameStudenteWeek5
{
    internal class Immatricolazione
    {
        public int Matricola { get;}//autogenerante
        public DateTime DataInizio { get; set; }
        public CorsoLaurea CorsoLaurea { get; set; } = new CorsoLaurea();   
        public bool FuoriCorso { get; set; }
        public int CfuAcumulati { get; set; }

        public static int matricolaSuccessiva = 100;
        public Immatricolazione()
        {

        }
        public Immatricolazione(DateTime dataInizio, bool fuoriCorso, int cfuAcumulati)
        {
            //Matricola = matricola;
            matricolaSuccessiva++;
            DataInizio = dataInizio;
            CorsoLaurea = CorsoLaurea;
            FuoriCorso = fuoriCorso;
            CfuAcumulati = cfuAcumulati;
        }
        public void StampaDatiImmatricolazione()
        {
            Console.WriteLine($"Matricola: {Immatricolazione.matricolaSuccessiva}\t Data: {DataInizio}\t Corso di laurea: {CorsoLaurea}\t CFU: {CfuAcumulati} ");//calcolo cfu
        }
    }
}
