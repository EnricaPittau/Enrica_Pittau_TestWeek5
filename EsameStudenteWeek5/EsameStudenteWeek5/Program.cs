// See https://aka.ms/new-console-template for more information

//Risposte test:
//1 = b
//2 = heap, reference
//3 = a, b

using EsameStudenteWeek5;
//Studente = new Studente(nome, cognome, dataNascita);
Console.WriteLine("Iscrizione agli esami.");
bool continua = true;
while (continua)
{
    Menu();
    int scelta = Scegli();
    switch (scelta)
    {
        case 1:
            //PrenotaEsame();
            //break;
        case 2:
            VerbalizzaEsame();
            break;
        case 0:
            Console.WriteLine("Ciao, al prossimo esame");
            continua = false;
            break;
    }
}
int Scegli()
{
    int scelta;
    do
    {
        Console.Write("Fai la tua scelta tra le possibili voci del menu: ");
    } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 3));
    return scelta;
}

void Menu()
{
    Console.WriteLine("1. Prenota un esame");
    Console.WriteLine("2. Aggiorna i tuoi CFU");
    Console.WriteLine("0. Exit");
}
//void PrenotaEsame(ref ListaCorsi.CFU, ref CorsoLaurea.CfuTotali)
//{
//    if (ListaCorsi.CFU < CorsoLaurea.CfuTotali)
//    {

//    }
//}
void VerbalizzaEsame()
{ 

}

