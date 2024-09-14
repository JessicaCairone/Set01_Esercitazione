using Lez04_Esercizio2.classes;

namespace Lez04_Esercizio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Studente> listaStudenti = new List<Studente>();

            bool insAbi = true;

            while (insAbi)
            {
                Console.WriteLine("Benvenuto nel sistema gestione studenti!\n" +
                    "Quale operazione vuoi effettuare?\n" +
                    "Digita:\n" +
                    "I per inserire un nuovo studente\n" +
                    "V per visualizzare la lista studenti\n" +
                    "M per modificare i dati di uno studente\n" +
                    "F per cercare uno studente in base al voto\n" +
                    "D per eliminare uno studente\n" +
                    "Q per chiudere il programma");

                string? inputUtente = Console.ReadLine();

                switch (inputUtente)
                {
                    case "I":
                        Console.WriteLine("Inserisci il nome dello studente:");
                        string? nome = Console.ReadLine();
                        Console.WriteLine("Inserisci il cognome dello studente:");
                        string? cognome = Console.ReadLine();
                        Console.WriteLine("Inserisci il voto dello studente:");
                        string? inputVoto = Console.ReadLine();
                        double voto = Convert.ToDouble(inputVoto);
                        if (voto >= 0 && voto <= 10)
                        {
                            Studente s1 = new Studente()
                            {
                                Nome = nome,
                                Cognome = cognome,
                                Voto = voto
                            };

                            listaStudenti.Add(s1);
                            Console.WriteLine("Studente aggiunto con successo!");
                        }
                        else
                            Console.WriteLine("ERRORE: voto fuori range");
                        break;
                    case "V":
                        foreach(Studente studente in listaStudenti)
                        {
                            Console.WriteLine(studente);
                        }
                      
                        break;
                    case "M":
                        Console.WriteLine("Di quale studente vuoi modificare i dati?");
                        string? inputStudente = Console.ReadLine();
                        foreach(Studente s in listaStudenti)
                        {
                            if (inputStudente.Equals(s.Nome) || inputStudente.Equals(s.Cognome))
                            {
                                Console.WriteLine("Scegli:\n" +
                                    "N per modificare il nome \n" +
                                    "C per modificare il cognome\n" +
                                    "X per modificare la votazione");
                                string? comando = Console.ReadLine();
                                switch (comando)
                                {
                                    case "N":
                                        Console.WriteLine("Digita il nuovo nome");
                                        string? nuovoNome = Console.ReadLine();
                                        s.Nome = nuovoNome;
                                        break;
                                    case "C":
                                        Console.WriteLine("Digita il nuovo cognome");
                                        string? nuovoCognome = Console.ReadLine();
                                        s.Nome = nuovoCognome;
                                        break;
                                    case "X":
                                        Console.WriteLine("Digita il nuovo voto");
                                        string? nuovoVoto = Console.ReadLine();
                                        s.Nome = nuovoVoto;
                                        break;
                                }
                                Console.WriteLine("Studente modificato con successo!");
                            }
                            else
                                Console.WriteLine("Studente non trovato");
                        }
                        
                        break;
                    case "F":
                        Console.WriteLine("Inserire il voto massimo:");
                        string? InputVotoMax = Console.ReadLine();
                        double votoMax = Convert.ToDouble(InputVotoMax);
                        Console.WriteLine("Inserire il voto minimo:");
                        string? InputVotoMin = Console.ReadLine();
                        double votoMin = Convert.ToDouble(InputVotoMin);
                        foreach(Studente stud in listaStudenti)
                        {
                            if (stud.Voto <= votoMax && stud.Voto >= votoMin)
                            {
                                Console.WriteLine($"Studente trovato: {stud.Nome} , {stud.Cognome} , {stud.Voto} ");
                            }else
                            Console.WriteLine("Studente con il voto specificato non trovato");
                        }    
                        break;
                    case "D":
                        Console.WriteLine("Quale studente vuoi eliminare?");
                       string? inputStud = Console.ReadLine();
                        foreach(Studente stud in listaStudenti)
                        {
                            if (inputStud.Equals(stud.Nome))
                            {
                                listaStudenti.Remove(stud);
                                Console.WriteLine("Studente eliminato con successo!");
                            }
                            else { 
                                Console.WriteLine("Studente con il nome specificato non trovato"); 
                            
                        }
                             
                        }
                       
                        break;
                    case "Q":
                        Console.WriteLine("Programma terminato");
                        insAbi = false;
                        break;
                    default:
                        Console.WriteLine("Comando non riconosciuto");
                        break;

                }
            }
        }
    }
}
