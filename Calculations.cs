public class Calculations
{
    private Menu menu;

    private int beitragZurGesetzlichenReserve;

    public int JahresGewinn { get; private set; }
    public int Aktien { get; private set; }
    public int Partizipationskapital { get; private set; }
    public int GesetzlicheReserven { get; private set; }
    public int Gewinnvortrag { get; private set; }
    public int Verlustvortrag { get; private set; }
    public int Dividende { get; private set; }

    public Calculations(Menu menu, int jahresGewinn, int aktien, int partizipationskapital, int gesetzlicheReserven, int gewinnvortrag, int verlustvortrag, int dividende)
    {
        this.menu = menu;
        JahresGewinn = jahresGewinn;
        Aktien = aktien;
        Partizipationskapital = partizipationskapital;
        GesetzlicheReserven = gesetzlicheReserven;
        Gewinnvortrag = gewinnvortrag;
        Verlustvortrag = verlustvortrag;
        Dividende = dividende;
    }

    public void CalculateGesetzlicheReserve()
    {
        int zielReserve = (int)((Aktien + Partizipationskapital) * 0.2);
        beitragZurGesetzlichenReserve = 0;

        if (GesetzlicheReserven < zielReserve)
        {
            beitragZurGesetzlichenReserve = (int)(JahresGewinn * 0.05);

            if (GesetzlicheReserven + beitragZurGesetzlichenReserve > zielReserve)
            {
                beitragZurGesetzlichenReserve = zielReserve - GesetzlicheReserven;
            }
        }

        CalculateDividende();
    }

    public void CalculateDividende()
    {
        int verbleibenderGewinn = JahresGewinn - beitragZurGesetzlichenReserve;

        if (verbleibenderGewinn >= Dividende)
        {
            verbleibenderGewinn -= Dividende;
        }
        else
        {
            Dividende = verbleibenderGewinn;
            verbleibenderGewinn = 0;
        }

        CalculateGewinnOderVerlustVortrag(verbleibenderGewinn);
    }

    public void CalculateGewinnOderVerlustVortrag(int verbleibenderGewinn)
    {
        if (verbleibenderGewinn > 0)
        {
            Gewinnvortrag += verbleibenderGewinn;
        }
        else if (verbleibenderGewinn < 0)
        {
            Verlustvortrag += Math.Abs(verbleibenderGewinn);
        }

        PrintFinalSummary();
    }

    public void PrintFinalSummary()
{
    Console.WriteLine("\n-----------------------------------");
    Console.WriteLine("       Endergebnis der Berechnungen");
    Console.WriteLine("-----------------------------------\n");

    Console.WriteLine($"Beitrag zur gesetzlichen Reserve: {beitragZurGesetzlichenReserve} CHF");
    Console.WriteLine("(Die gesetzlichen Reserven müssen erst aufgefüllt werden, wenn sie unter 20 % des Aktienkapitals liegen. Da dies bereits erfüllt ist, wird kein weiterer Beitrag geleistet.)\n");
    Console.WriteLine($"Neue gesetzliche Reserve: {GesetzlicheReserven + beitragZurGesetzlichenReserve} CHF");
    Console.WriteLine("(Dies ist der Gesamtbetrag, den das Unternehmen als gesetzliche Reserve hält, nachdem alle Berechnungen abgeschlossen sind.)\n");

    if (Dividende > 0)
    {
        Console.WriteLine($"Die Dividende in Höhe von {Dividende} CHF wurde ausgeschüttet.");
    }
    else
    {
        Console.WriteLine("Es war nicht genug Gewinn vorhanden, um eine Dividende auszuschütten.");
    }

    Console.WriteLine($"Verbleibender Gewinn nach Dividendenzahlung: {JahresGewinn - beitragZurGesetzlichenReserve - Dividende} CHF");
    Console.WriteLine("(Dies ist der Betrag, der nach der Auszahlung der Dividende übrig geblieben ist.)\n");

    if (Gewinnvortrag > 0)
    {
        Console.WriteLine($"Gewinnvortrag für die nächste Periode: {Gewinnvortrag} CHF");
        Console.WriteLine("(Dieser Betrag wird in das nächste Geschäftsjahr übertragen und kann in der Zukunft verwendet werden.)\n");
    }
    else if (Verlustvortrag > 0)
    {
        Console.WriteLine($"Verlustvortrag für die nächste Periode: {Verlustvortrag} CHF");
        Console.WriteLine("(Dieser Verlust wird in das nächste Geschäftsjahr übertragen und muss in der Zukunft ausgeglichen werden.)\n");
    }
    else
    {
        Console.WriteLine("Kein Gewinn oder Verlust für die nächste Periode.");
    }

    Console.WriteLine("\n-----------------------------------");
    Console.WriteLine("        Berechnungen abgeschlossen");
    Console.WriteLine("-----------------------------------");

    // Aufforderung zum Beenden der Anwendung
    Console.WriteLine("\nBitte geben Sie 'exit' ein, um das Programm zu beenden.");
    
    string input = "";
    while (input.ToLower() != "exit")
    {
        input = Console.ReadLine();
    }
}

}
