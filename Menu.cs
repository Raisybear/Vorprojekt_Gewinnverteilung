namespace Vorporojekt_Gewinnverteilung
{
    public class Menu
    {
        public void StartInputs()
        {
            Inputs inputs = new Inputs(this); // Übergibt das aktuelle Menu-Objekt
            inputs.GetInputs();
        }

        public void StartCalculations()
        {
            Calculations calculations = new Calculations();
            calculations.Calculate();
        }
    }
}