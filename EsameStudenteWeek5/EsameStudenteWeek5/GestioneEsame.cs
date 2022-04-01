using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsameStudenteWeek5
{
    internal class GestioneEsame
    {
        public ListaCorsi EsameDaSostenere { get; set; }
        bool esamePassato = true;

        public GestioneEsame()
        {

        }
        public static List<Studente> studenti = new List<Studente>()
        {
            new Studente(){Nome="Sandro", Cognome="Rossi", AnnoNascita=1981},
            new Studente(){Nome="Mario", Cognome="Demontis", AnnoNascita=1990},
            new Studente(){Nome="Claudio", Cognome="Tali", AnnoNascita=1995}
        };

        public static List<ListaCorsi> listaCorsi = new List<ListaCorsi>()
        {
            new ListaCorsi(){Nome="Analisi1", CFU=15},
            new ListaCorsi(){Nome="Fisica1", CFU=5},
            new ListaCorsi(){Nome="Informatica1", CFU=5},
            new ListaCorsi(){Nome="Informatica2", CFU=5},
            new ListaCorsi(){Nome="Informatica3", CFU=5},
        };


        public static List<CorsoLaurea> listaCorsiLaurea = new List<CorsoLaurea>()
        {
            new CorsoLaurea(){Nome="Ingegneria", AnniDiCorso=5, CfuTotali=20},
            new CorsoLaurea(){Nome="Matematica", AnniDiCorso=5, CfuTotali=15},
            new CorsoLaurea(){Nome="Fisica", AnniDiCorso=5, CfuTotali=20},
            new CorsoLaurea(){Nome="Informatica", AnniDiCorso=5, CfuTotali=20},
            new CorsoLaurea(){Nome="Lettere", AnniDiCorso=5, CfuTotali=20},
        };



    }
}
