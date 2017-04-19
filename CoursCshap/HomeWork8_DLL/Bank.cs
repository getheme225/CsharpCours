using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_DLL
{
    public class Bank
    {
        private List<Employee> employees = new List<Employee> {};
        public IReadOnlyList<Employee> Employees => employees;

        private List<Account> accounts = new List<Account> {};
        public IReadOnlyList<Account> Accounts => accounts;

        public bool IsOpen => DateTime.Now.Hour > 8 && DateTime.Now.Hour< 20;

        public void AddNewEmployees(Employee employee)
        {
            employees.Add(employee);
        }

        public bool CanWorkWithClient(Client client, decimal amount, out string message)
        {
            if (IsOpen)
            {
                var employee = employees.FirstOrDefault(x =>!x.IsBusy && x.EmployeeAccesRules.GetType() == client.ClientRequieredBankOperation.GetType());
                var clientaccount = Accounts.FirstOrDefault(x => x.AccountOwner.ID == client.ID || x.AccountOwner.Name == client.Name);
                message = string.Empty;
                if (employee != null)
                {
                    switch (client.ClientRequieredOperation)
                    {
                        case RequieredOperation.Deposit:
                            ((OperationDeposit) employee.WorkWithClient(client, clientaccount)).CanMakeDeposit(amount,
                                out message);
                            break;
                        case RequieredOperation.WithDraw:
                            ((OperationWithDraw) employee.WorkWithClient(client, clientaccount)).CanMakeWithDraw(
                                amount,
                                out message);
                            break;
                        case RequieredOperation.CreateAccount:
                            accounts.Add(new CreateAccount().CreateNewAccount(client));
                            message =
                                $"Счет № {accounts.Last().AccountNumber} был успечно открыть для {accounts.Last().AccountOwner.Name}";
                            break;
                    }
                    string employeeInfo = $"выпольнил операрцию: {employee.Function} {employee.Name}";
                    message = message + $"\n {employeeInfo}";
                    return true;
                }
                message = $"Все сотрудники ' {employees.Find(x => x.EmployeeAccesRules.GetType() == client.ClientRequieredBankOperation.GetType()).Function} ' заняты";
                return false;
            }
            message = "Банк Закрыт";
            return false;
        }
    }
}
