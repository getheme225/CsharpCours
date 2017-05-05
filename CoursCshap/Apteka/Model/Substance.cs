namespace Apteka.Model
{
    public class Substance
    {
        public string Name { get; private set; }
        public double Percentage { get; private set; }

        public Substance(string name, double percentage)
        {
            Name = name;
            Percentage = percentage;
        }
    }
}
