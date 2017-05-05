using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using WpfBankApp.BAL;

namespace WpfBankApp.ViewModel
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
        #region Public Proprety
        public Bank bank { get; set; }
        public RelayCommand AddNewAccountCommand { get; private set; }
        public RelayCommand DepositeCommand { get; private set; }
        public RelayCommand WithdrawCommand { get; private set; }
        public RelayCommand RemoveAccountCommand { get; private set; }
        public Client SelectedClient { get; set; }
        public Account SelectedAccount { get; set; }
        private decimal Amount { get; set; }
        public string ClientName { get; set; }
        public ICollection<Client> ClientsFiltredCollection => (!string.IsNullOrEmpty(ClientName))
               ? bank?.Clients.Where(x => x.Name.IndexOf(ClientName, StringComparison.CurrentCultureIgnoreCase) >= 0).ToList()
               : bank?.Clients.ToList();

        public ICollection<Account> ClientAccounts => bank?.Accounts?.Where(account => account.Client.Equals(SelectedClient)).ToList();

        public bool HasEmployeeMangeAccountAcces
            => (bank != null) ? bank.CurrentEmployee.PermitedOperationType.Contains(OperationTypes.OpenAccount) : false;

        public bool HasEmployeePullorPushMoneyAcces
            => (bank != null) ? bank.CurrentEmployee.PermitedOperationType.Contains(OperationTypes.Deposit) : false;
        #endregion

        #region Constructor
        public MainViewModel()
        {
            DepositeCommand = new RelayCommand(() => MakeDeposite(SelectedAccount));
            WithdrawCommand = new RelayCommand(() => MakeWithdraw(SelectedAccount));
            RemoveAccountCommand = new RelayCommand(() => DeletteAccount(SelectedAccount));
            AddNewAccountCommand = new RelayCommand(() => AddNewAccount(SelectedClient));
        }
        #endregion

        #region Bank OperationCommand Methode
        private void MakeDeposite(Account account)
        {
            try
            {
                bank.ApplyOperation(OperationTypes.Deposit, account, Amount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void MakeWithdraw(Account account)
        {
            try
            {
                bank.ApplyOperation(OperationTypes.Withdraw, account, Amount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddNewAccount(Client client)
        {
            try
            {
                bank.CreateAccount(client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                throw;
            }
        }

        private void DeletteAccount(Account account)
        {
            bank.Accounts.Remove(account);
        }
       #endregion
    }
}