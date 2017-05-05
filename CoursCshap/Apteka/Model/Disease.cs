namespace Apteka.Model
{
    public class Disease
    {
        public string Name { get; private set; }
        public string IndicationTreatment { get; private set; }

        public Disease(string name, string indicationTreatment)
        {
            Name = name;
            IndicationTreatment = indicationTreatment;
        }
    }
}
