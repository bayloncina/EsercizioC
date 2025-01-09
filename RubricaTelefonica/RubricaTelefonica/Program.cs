
using RubricaTelefonica;

class Program
{
    static void Main()
    {

        List<Contatto> rubrica = new List<Contatto>();

        while (true)
        {
            Console.WriteLine("Digita 1 per aggiungere un contatto");
            Console.WriteLine("Digita 2 per eliminare un contatto");
            Console.WriteLine("Digita 3 per visualizzare tutti i contatti");
            Console.WriteLine("Digita 4 per ricercare un contatto");
            Console.WriteLine("Digita 0 per uscire");
            int scelta = int.Parse(Console.ReadLine());


            switch (scelta)
            {
                //aggiungi contatto
                case 1:
                    Console.WriteLine("Inserisci il nome del contatto");
                    String nome = Console.ReadLine();
                    Console.WriteLine("Inserisci il cognome del contatto");
                    String cognome = Console.ReadLine();
                    Console.WriteLine("Inserisci il numero del contatto");
                    String numero = Console.ReadLine();
                    rubrica.Add(new Contatto{Nome = nome, Cognome = cognome, Telefono = numero});
                    break;
                
                //elimina contatto
                case 2:
                    Console.WriteLine("Inserisci il nome del contatto da eliminare");
                    String nomeDaEliminare = Console.ReadLine();
                    Console.WriteLine("Inserisci il cognome del contatto da eliminare");
                    String cognomeDaEliminare = Console.ReadLine();
                    Console.WriteLine("Contatto inserito con successo");

                    var contattoDaEliminare =
                        rubrica.FirstOrDefault(c => c.Nome == nomeDaEliminare & c.Cognome == cognomeDaEliminare);
                    if (contattoDaEliminare != null)
                    {
                        rubrica.Remove(contattoDaEliminare);
                        Console.WriteLine("Il contato è stat eliminato con successo");
                    }
                    else
                    {
                        Console.WriteLine("Contatto non trovato");
                    }
                    
                    break;
                
                //visualizza contatti
                case 3:
                    Console.WriteLine("Rubrica: ");
                    rubrica.ForEach(c => Console.WriteLine($"{c.Nome} - {c.Cognome}: {c.Telefono}"));
                    break;
                
                //Ricerca contatto
                case 4:
                    Console.WriteLine("Inserisci il nome del contatto da ricercare");
                    String ricerca = Console.ReadLine();
                    var risultati = rubrica.Where(c => c.Nome.Contains(ricerca, StringComparison.OrdinalIgnoreCase));
                    Console.WriteLine("Risultati della ricerca");
                    foreach (var contatto in risultati)
                    {
                        Console.WriteLine($"{contatto.Nome} - {contatto.Cognome} - {contatto.Telefono}");
                    }
                    break;
                case 0:
                    return;
                
                default:
                    Console.WriteLine("Opzione non valida.");
                    break;
                    
                
            }
        }




    }
}