using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using WpfBankApp.BAL;
using WpfBankApp.Helper;

namespace WpfBankApp.ViewModel
{
    /// <summary>
    /// We use Fody PropretyChanges for changing automatiquely all public on the view 
    /// </summary>
    [ImplementPropertyChanged]
    public class LoginWindowsViewModel : ViewModelBase
    {       
        #region Public Proprety
        public string EmployeeUsername { get; set; }
        public string EmployeePassword { get; set; }
        public string Error => string.Empty;
        public Bank Bank { get; private set; }
        public RelayCommand<IClosable> LoginAndCloseWindowsCommand { get; private set; }
        #endregion

        #region Constructor
        public LoginWindowsViewModel()
        {
            Bank = new Bank();
            LoginAndCloseWindowsCommand = new RelayCommand<IClosable>(LoginAndClosePage);
        }
        #endregion

        #region Methode for LoginWindows
        private void OpenMainWindow()
        {
            MainViewModel vm = new MainViewModel { bank = Bank };
            ChildWindowManager.Instance.ShowChildWindow(new MainWindow() { DataContext = vm });
        }

        private void LoginAndClosePage(IClosable window)
        {
            if (!Bank.LoginEmployee(EmployeeUsername, EmployeePassword))
            {
                MessageBox.Show("Не правилный логин или парол", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            OpenMainWindow();
            window?.Close();
        }
        #endregion
    }
}
