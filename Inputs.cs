namespace Vorporojekt_Gewinnverteilung
{
    public class Inputs
    {
        private Menu menu;
        private int SelectedOption = 1; // 1 für Gewinnvortrag, 2 für Verlustvortrag
        private bool[] selected = new bool[2]; // Array zur Auswahl des Gewinn- oder Verlustvortrags

        // Konstruktor, um das Menu-Objekt zu erhalten
        public Inputs(Menu menu)
        {
            this.menu = menu;
        }

        public void GetInputs()
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

            // Auswahl zwischen Gewinnvortrag und Verlustvortrag
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hatten Sie letztes Jahr einen Gewinnvortrag oder einen Verlustvortrag? Verwenden Sie die Pfeiltasten oder W/S, um Ihre Auswahl zu treffen:");
                Console.WriteLine(SelectedOption == 1 ? "> Gewinnvortrag" : "  Gewinnvortrag");
                Console.WriteLine(SelectedOption == 2 ? "> Verlustvortrag" : "  Verlustvortrag");

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                {
                    SelectedOption = SelectedOption == 1 ? 2 : SelectedOption - 1;
                }
                else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                {
                    SelectedOption = SelectedOption == 2 ? 1 : SelectedOption + 1;
                }
                else if (key == ConsoleKey.Enter)
                {
                    break;
                }
            }

            Console.Clear();
            if (SelectedOption == 1)
            {        
                Console.WriteLine("Bitte geben Sie den Gewinnvortrag ein: ");
                int gewinnvortrag = Convert.ToInt32(Console.ReadLine());
            }
            else if (SelectedOption == 2)
            {
                Console.WriteLine("Bitte geben Sie den Verlustvortrag ein: ");
                int verlustvortrag = Convert.ToInt32(Console.ReadLine());
            }
        
            Console.Clear();
            Console.WriteLine("Bitte geben Sie die gewünschte Dividende ein: ");
            int dividende = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            menu.StartCalculations();
        }
    }
}