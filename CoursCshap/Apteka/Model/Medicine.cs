using System.Collections.Generic;

namespace Apteka.Model
{
    public class Medicine
    {
        public string Name { get; private set; }
        public string TradeMark { get; private set; }
        public float Weight { get; private set; }
        public decimal Price { get; private set; }
        public List<Substance> Substances { get; private set; }
        public List<Disease> ForDiseases { get; private set; }

        public Medicine(string name, string tradeMark, float weight, decimal price)
        {
            Name = name;
            TradeMark = tradeMark;
            Weight = weight;
            Price = price;
            Substances = new List<Substance>();
            ForDiseases = new List<Disease>();
        }

        public void AddSubstance(string substancesName, double percentage)
        {
            Substances.Add(new Substance(substancesName, percentage));
        }

        public void AddMedecineForDiseases(string diseasesName, string indicationTreatment)
        {
            ForDiseases.Add(new Disease(diseasesName, indicationTreatment));
        }
        
    }
}
