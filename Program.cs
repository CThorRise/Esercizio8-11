using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace Esercizio8_11
{
    internal class Program
    {
        static private int[] ArrayPunteggiG1 = new int[10];
        static private int[] ArrayPunteggiG2 = new int[10];
        static private int[] ArrayPunteggiG3 = new int[10];
        static private int[] ArrayPunteggiG4 = new int[10];



        static void Main(string[] args)
        {
            MenuPrincipale();

        }

        /*int[] menu = { 1, 2, 3, 4, 5 };

            /*switch (menu)
            {
                case 1: InserimentoPunteggi(opzione); break;
                case 2: CalcoloRisultati(opzione); break;
                case 3: ClassificaEStatistiche(opzione); break;
                case 4: VisualizzazioneRisultati(opzione); break;
                case 5: Uscita(opzione); break;
                default: Console.WriteLine("Opzione non valida"); break;
            }*/

        static void MenuPrincipale()
        {
            while (true)
            {
                Console.WriteLine("--- Gestione Torneo Giocatori ---");
                Console.WriteLine("1. Inserimento Punteggi");
                Console.WriteLine("2. Calcolo dei Risultati");
                Console.WriteLine("3. Classifica e Statistiche");
                Console.WriteLine("4. Visualizzazione dei Risultati");
                Console.WriteLine("5. Esci");
                Console.WriteLine("Seleziona un'opzione:");
                short opzione = short.Parse(Console.ReadLine());

                if (opzione == 5)
                {
                    while (true)
                    {
                        Console.WriteLine("Sei sicuro di voler uscire? (s/n)");
                        char reply = char.Parse(Console.ReadLine());


                        if (reply == 's')
                        {
                            return;

                        }
                        else if (reply == 'n')
                        {
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Scelta non valida!");


                        }
                    }
                }
                else if (opzione == 1)
                {
                    InserimentoPunteggi();
                }
                else if (opzione == 2)
                {
                    CalcoloDeiRisultati();
                }
                else if (opzione == 3)
                {
                    ClassificaEStatistiche();
                }
                else if (opzione == 4) 
                {
                    VisualizzazioneRisultati();
                }


            }

        }

        static void InserimentoPunteggi()
        {
            Console.WriteLine("--- Inserimento Punteggi ---");
            Console.WriteLine("1. Inserisci i punteggi per il giocatore 1");
            Console.WriteLine("2. Inserisci i punteggi per il giocatore 2");
            Console.WriteLine("3. Inserisci i punteggi per il giocatore 3");
            Console.WriteLine("4. Inserisci i punteggi per il giocatore 4");
            Console.WriteLine("5. Conferma e visualizza tutti i punteggi inseriti");
            Console.WriteLine("6. Torna al menu principale");
            Console.WriteLine("Seleziona un'opzione:");
            short opzione = short.Parse(Console.ReadLine());

            if (opzione == 6)
            {
                MenuPrincipale();
            }
            else if (opzione == 1 || opzione == 2 || opzione == 3 || opzione == 4)
            {

            }
            else if (opzione == 5)
            {
            }

        }
        static void CalcoloDeiRisultati()
        {
            Console.WriteLine("--- Calcolo dei Risultati ---");
            Console.WriteLine("1. Calcola il punteggio totale per ciascun giocatore");
            Console.WriteLine("2. Calcola il punteggio medio per ciascun giocatore");
            Console.WriteLine("3. Determina il punteggio massimo e minimo per ciascun giocatore");
            Console.WriteLine("4.Torna al menu principale");
            Console.WriteLine("Seleziona un'opzione");
            short opzione = short.Parse(Console.ReadLine());

            if (opzione ==4)
            {
                MenuPrincipale();
            }
        }
        static void ClassificaEStatistiche()
        {
            Console.WriteLine("--- Classifica e Statistiche ---");
            Console.WriteLine("1. Mostra il giocatore con il punteggio totale più alto");
            Console.WriteLine("2. Mostra il giocatore con il punteggio totale più basso");
            Console.WriteLine("3. Visualizza la classifica completa dei giocatori in base ai punteggi totali");
            Console.WriteLine("4. Torna al menu principale");
            Console.WriteLine("Seleziona un'opzione:");
            short opzione = short.Parse(Console.ReadLine());
            
            if (opzione==4)
            {
                MenuPrincipale();
            }
            

        }
        static void VisualizzazioneRisultati()
        {
            Console.WriteLine("1. Visualizza il riepilogo completo dei risultati");
            Console.WriteLine("2. Visualizza solo il riepilogo dei punteggi totali e medi");
            Console.WriteLine("3. Torna al menu principale");
            Console.WriteLine("Seleziona un'opzione:");
            short opzione = short.Parse(Console.ReadLine());

            if (opzione == 4)
            {
                MenuPrincipale();
            }

        }

        static void InserisciPunteggioPerGiocatoreX(int NGiocatore)
        {
            Console.WriteLine("--- Inserisci i Punteggi per il Giocatore " + NGiocatore);
            Console.WriteLine("Quante partite ha giocato il Giocatore " + NGiocatore + "? (max: 10");
            short NPartite=short.Parse(Console.ReadLine());

            if (NGiocatore == 1)
            {
                int[]ArrayPunteggiG1;
                for (int i = 1; i <= 10; i++) ;
                {
                    
                }

            }
            else if (NGiocatore == 2)
            { 
            }
            else if (NGiocatore == 3)
            {
            }
            else if (NGiocatore == 4)
            { 
            }
    }


}
