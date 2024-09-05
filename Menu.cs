public class Menu
{
    public void StartInputs()
    {
        Inputs inputs = new Inputs(this);
        inputs.GetInputs();
    }

    public void GesetzlicheReservenCalculations(int jahresGewinn, int aktien, int partizipationskapital, int gesetzlicheReserven, int gewinnvortrag, int verlustvortrag, int dividende)
    {
        Calculations calculations = new Calculations(jahresGewinn, aktien, partizipationskapital, gesetzlicheReserven, gewinnvortrag, verlustvortrag, dividende);
        calculations.CalculategesetzlicheReserve();
    }
    
    public void DividendenCalculations(int jahresGewinn, int aktien, int partizipationskapital, int gesetzlicheReserven, int gewinnvortrag, int verlustvortrag, int dividende)
    {
        Calculations calculations = new Calculations(jahresGewinn, aktien, partizipationskapital, gesetzlicheReserven, gewinnvortrag, verlustvortrag, dividende);
        calculations.CalculateDividende();
    }
}