namespace Vorporojekt_Gewinnverteilung;

public class Menu
{
    public void Inputs()
    {
        Console.WriteLine("Willkommen bei unserem Gewinnverteilungsprogramm! Bitte geben Sie den Jahresgewinn ein: ");
        int jahresGewinn = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        
        Console.WriteLine("Bitte geben Sie die Anzahl Aktien ein: ");
        int aktien = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        
        Console.WriteLine("Bitte geben Sie das Partizipationskapital ein: ");
        int partizipationskapital = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        
        Console.WriteLine("Bitte geben Sie die gesetzlichen Reserven ein: ");
        int gesetzlicheReserven = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        
        Console.WriteLine("Hatten Sie letzen Jahr einen Gewinnvortrag oder einen Verlustvortrag? ");
        string antwort = Console.ReadLine();
        Console.Clear();
        
        if(antwort == "Gewinnvortrag")
        {        
            Console.WriteLine("Bitte geben Sie den Gewinnvortrag ein: ");
            int gewinnvortrag = Convert.ToInt32(Console.ReadLine());
        }
        else if(antwort == "Verlustvortrag")
        {
            Console.WriteLine("Bitte geben Sie den Verlustvortrag ein: ");
            int verlustvortrag = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("Bitte geben Sie die gewünschte Dividende ein: ");
        int dividende = Convert.ToInt32(Console.ReadLine());
    }
}