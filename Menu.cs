namespace Vorporojekt_Gewinnverteilung;

public class Menu
{
    public void Inputs()
    {
        Console.WriteLine("Willkommen bei unserem Gewinnverteilungsprogramm! Bitte geben Sie den Jahresgewinn ein: ");
        int jahresGewinn = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Bitte geben Sie die Anzahl Aktien ein: ");
        int aktien = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Bitte geben Sie das Partizipationskapital ein: ");
        int partizipationskapital = Convert.ToInt32(Console.ReadLine());
    }
}