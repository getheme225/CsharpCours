using System.Collections.Generic;
using System.Linq;

namespace Apteka.Model
{
    public class Pharmacy
    {
        public List<Medicine> MedicinesList { get; private set; }

        public Pharmacy()
        {
            MedicinesList = new List<Medicine>();
            InitialisazionMedicine();
        }
       
        public List<Medicine> SearchMedicinesByName(string name)
        {
            return MedicinesList.Where(med => med.Name.Equals(name)).ToList();
        }

        public List<Medicine> SearchMedicinesByDisease(string disease)
        {

            return MedicinesList.Where(x => x.ForDiseases.Exists(y => y.Name == disease)).ToList();
        }

        public List<Medicine> SearchAnalogMedicines(Medicine medicine)
        {
            return MedicinesList.Where(x => x.Substances.Exists(y => medicine.Substances.Exists(a => a.Name.Equals(y.Name) && a.Percentage / y.Percentage > 0.5))).ToList();
        }

        #region Initialisazion Medicine
        private void AddMedcineToPharmacy(Medicine medicine)
        {

            MedicinesList.Add(medicine);
        }

        private void InitialisazionMedicine()
        {
            //Create Tabeks Medicine
            Medicine tabeks = new Medicine("Табекс", "Sopharma", 1.5F, 980);
            tabeks.AddSubstance("Cytisine", 100);
            tabeks.AddMedecineForDiseases("Курение", "2 раза в день");
            AddMedcineToPharmacy(tabeks);

            Medicine paracetamol = new Medicine("Парацетамол", "VIDAL", 300, 17);
            paracetamol.AddSubstance("Paracetamol", 100);
            paracetamol.AddMedecineForDiseases("Боль в желудке", "4 раза в день");
            paracetamol.AddMedecineForDiseases("Зубная боль", "10 раз в день");
            paracetamol.AddMedecineForDiseases("Головная боль", "3 раз в день");
            paracetamol.AddMedecineForDiseases("простуда", "3 раз в день");
            AddMedcineToPharmacy(paracetamol);

            Medicine no_spa = new Medicine("Но-шпа", "VIDAL", 200, 64);
            no_spa.AddSubstance("дротаверина гидрохлорид", 100);
            no_spa.AddMedecineForDiseases("Боль в желудке", "4 раза в день");
            no_spa.AddMedecineForDiseases("Зубная боль", "10 раз в день");
            no_spa.AddMedecineForDiseases("Головная боль", "3 раз в день");
            AddMedcineToPharmacy(no_spa);

            Medicine theraflu = new Medicine("ТЕРАФЛЮ", "VIDAL", 355, 198);
            theraflu.AddSubstance("Paracetamol", 91.5);
            theraflu.AddSubstance("Pheniramine maleat", 8);
            theraflu.AddSubstance("Phenylephrine hydrochloride", 0.5);
            theraflu.AddMedecineForDiseases("простуда", "3 раз в день");
            AddMedcineToPharmacy(theraflu);
        }
        #endregion
    }
}
