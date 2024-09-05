public class Inputs
    {
        private Menu menu;
        private int SelectedOption = 1; // 1 für Gewinnvortrag, 2 für Verlustvortrag
        private bool[] selected = new bool[2]; // Array zur Auswahl des Gewinn- oder Verlustvortrags
        
        private int jahresGewinn;
        private int aktien;
        private int partizipationskapital;
        private int gesetzlicheReserven;
        private int gewinnvortrag;
        private int verlustvortrag;
        private int dividende;
        
        public Inputs(Menu menu)
        {
            this.menu = menu;
        }

        public void GetInputs()
        {
            Console.WriteLine("Willkommen bei unserem Gewinnverteilungsprogramm! Bitte geben Sie den Jahresgewinn ein: ");
            jahresGewinn = ReadIntInput();
            Console.Clear();

            Console.WriteLine("Bitte geben Sie die Anzahl Aktien ein: ");
            aktien = ReadIntInput();
            Console.Clear();

            Console.WriteLine("Bitte geben Sie das Partizipationskapital ein: ");
            partizipationskapital = ReadIntInput();
            Console.Clear();

            Console.WriteLine("Bitte geben Sie die gesetzlichen Reserven ein: ");
            gesetzlicheReserven = ReadIntInput();
            Console.Clear();
            
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
                gewinnvortrag = ReadIntInput();
            }
            else if (SelectedOption == 2)
            {
                Console.WriteLine("Bitte geben Sie den Verlustvortrag ein: ");
                verlustvortrag = ReadIntInput();
            }

            Console.Clear();
            Console.WriteLine("Bitte geben Sie die gewünschte Dividende ein: ");
            dividende = ReadIntInput();

            Console.Clear();
            menu.GesetzlicheReservenCalculations(jahresGewinn, aktien, partizipationskapital, gesetzlicheReserven, gewinnvortrag, verlustvortrag, dividende);
        }
        
        private int ReadIntInput()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine gültige Zahl ein.");
                }
            }
        }
    }