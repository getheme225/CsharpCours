using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Apteka.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;

namespace Apteka.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    [ImplementPropertyChanged]
    public class MainViewModel : ViewModelBase
    {
        private Pharmacy ourPharmacy = new Pharmacy();
        #region Public Proprety
        public string MedicineName { get; set; }
        public bool HasMedicineName => !string.IsNullOrEmpty(MedicineName);
        public string DiseaseName { get; set; }
        public bool HasDiseaseName => !string.IsNullOrEmpty(DiseaseName);
        public List<Medicine>FindedMedicines { get; set; }
        public List<Medicine> AnalogMedicinesList => ourPharmacy.SearchAnalogMedicines(FindedMedicines?.Last());
        public RelayCommand SearchMedicineCommand { get; set; }       
        #endregion

        public MainViewModel()
        {
          
                SearchMedicineCommand = new RelayCommand(()=> FindMedicineByName());
        }

        private void FindMedicineByName()
        {
            {               
                if (HasMedicineName )
                    FindedMedicines = ourPharmacy.SearchMedicinesByName(MedicineName);
                if (HasDiseaseName)
                    FindedMedicines = ourPharmacy.SearchMedicinesByDisease(DiseaseName);                
            }
          
        } 
    }
}