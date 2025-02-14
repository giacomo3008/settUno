
using settUno.models;

Contribuente persona1 = new Contribuente();

try
{
    
    Console.WriteLine("Inserisci nome:");
    persona1.Nome = Console.ReadLine();

    Console.WriteLine("Inserisci cognome:");
    persona1.Cognome = Console.ReadLine();

    Console.WriteLine("Inserisci data di nascita (gg/mm/aaaa):");
    persona1.DataNascita = Console.ReadLine();

    Console.WriteLine("Inserisci codice fiscale:");
    persona1.CodiceFiscale = Console.ReadLine();

    Console.WriteLine("Inserisci sesso (M/F):");
    persona1.Sesso = Console.ReadLine();

    Console.WriteLine("Inserisci comune di residenza:");
    persona1.ComuneResidenza = Console.ReadLine();

    double reddito;
    while (true)
    {
        Console.WriteLine("Inserisci reddito annuale:");
        string redditoInput = Console.ReadLine();

        if (double.TryParse(redditoInput, out reddito) && reddito >= 0)
        {
            persona1.RedditoAnnuale = reddito;
            break;
        }
        else
        {
            Console.WriteLine("Errore: inserisci un numero valido per il reddito annuale.");
        }
    }

    Console.WriteLine("\n==================================================");
    Console.WriteLine("\nCALCOLO DELL'IMPOSTA DA VERSARE:");
    Console.WriteLine(persona1.Riepilogo());
    Console.WriteLine("\n==================================================");
}
catch (Exception ex)
{
    Console.WriteLine($"Errore: {ex.Message}");
}
