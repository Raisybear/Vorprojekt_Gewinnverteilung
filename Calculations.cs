    public class Calculations
    {
        private Menu menu;
        
        private int jahresGewinn;
        private int aktien;
        private int partizipationskapital;
        private int gesetzlicheReserven;
        private int gewinnvortrag;
        private int verlustvortrag;
        private int dividende;

        public Calculations(int jahresGewinn, int aktien, int partizipationskapital, int gesetzlicheReserven, int gewinnvortrag, int verlustvortrag, int dividende)
        {
            this.jahresGewinn = jahresGewinn;
            this.aktien = aktien;
            this.partizipationskapital = partizipationskapital;
            this.gesetzlicheReserven = gesetzlicheReserven;
            this.gewinnvortrag = gewinnvortrag;
            this.verlustvortrag = verlustvortrag;
            this.dividende = dividende;
        }
        
        public void CalculategesetzlicheReserve()
        {
            Console.WriteLine("Nun werden deine Eingaben verarbeitet und berechnet.");
            
            int zielReserve = (int)((aktien + partizipationskapital) * 0.2);
            
            int beitragZurGesetzlichenReserve = 0;
            if (gesetzlicheReserven < zielReserve)
            {
                beitragZurGesetzlichenReserve = (int)(jahresGewinn * 0.05);
                
                if (gesetzlicheReserven + beitragZurGesetzlichenReserve > zielReserve)
                {
                    beitragZurGesetzlichenReserve = zielReserve - gesetzlicheReserven;
                }
            }
            
            Console.WriteLine($"Beitrag zur gesetzlichen Reserve: {beitragZurGesetzlichenReserve}");
            Console.WriteLine($"Neue gesetzliche Reserve: {gesetzlicheReserven + beitragZurGesetzlichenReserve}");
            
            menu.DividendenCalculations(jahresGewinn, aktien, partizipationskapital, gesetzlicheReserven, gewinnvortrag, verlustvortrag, dividende);
        }
        
        public void CalculateDividende()
        {
            int verbleibenderGewinn = jahresGewinn - (gesetzlicheReserven - (int)((aktien + partizipationskapital) * 0.2));
     
            if (verbleibenderGewinn >= dividende)
            {
                Console.WriteLine($"Dividende in Höhe von {dividende} kann ausgeschüttet werden.");
                verbleibenderGewinn -= dividende; 
            }
            else
            {
                Console.WriteLine("Nicht genug Gewinn vorhanden, um die gewünschte Dividende auszuschütten.");
                dividende = verbleibenderGewinn; 
                Console.WriteLine($"Es wird eine reduzierte Dividende von {dividende} ausgeschüttet.");
                verbleibenderGewinn = 0;
            }
            
            Console.WriteLine($"Verbleibender Gewinn nach Dividendenzahlung: {verbleibenderGewinn}");
            
            CalculateGewinnOderVerlustVortrag(verbleibenderGewinn);
        }
        
        public void CalculateGewinnOderVerlustVortrag(int verbleibenderGewinn)
        {
            if (verbleibenderGewinn > 0)
            {
                gewinnvortrag += verbleibenderGewinn;
                Console.WriteLine($"Gewinnvortrag für die nächste Periode: {gewinnvortrag}");
            }
            else if (verbleibenderGewinn < 0)
            {
                verlustvortrag += Math.Abs(verbleibenderGewinn);
                Console.WriteLine($"Verlustvortrag für die nächste Periode: {verlustvortrag}");
            }
            else
            {
                Console.WriteLine("Kein Gewinn oder Verlust für die nächste Periode.");
            }
        }
    }