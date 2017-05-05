using System;
using System.Collections.Generic;
using System.Linq;

namespace WpfBankApp.BAL
{  
    public class Bank
    {
        
        public List<Employee> Employees { get; private set; }
        public List<Client> Clients { get; private set; }
        public List<Account> Accounts { get; private set; }
        public Employee CurrentEmployee { get; private set; }
        //public bool IsOpen =>  (CurrenTime.Hour >= 8 && CurrenTime.Hour <= 20);
        public static DateTime CurrenTime { get; set; }        

        public Bank()
        {
            Employees = new List<Employee>();
            Clients = new List<Client>();
            Accounts = new List<Account>();
            InitialBank();
        }

        public Client AddNewClient(string name)
        {
            var newClient = new Client(Clients.Count, name);
            Clients.Add(newClient);
            return newClient;
        }

        public bool LoginEmployee(string name, string password)
        {
            var targetEmployee = Employees?.FirstOrDefault(
                (employee) => employee.Name == name && employee.Password == password);           
            CurrentEmployee = targetEmployee;
            return targetEmployee != null;
        }

        public Employee AddNewEmployee(string name, string passowrd,
            EmployeeFunction function)
        {
            var newEmployee = new Employee(Employees.Count, name, passowrd, function);
            Employees.Add(newEmployee);
            return newEmployee;
        }

        private void InitialBank()
        {
            AddNewEmployee("Getheme", "123456", EmployeeFunction.AccountManager);
            AddNewEmployee("BRIKA", "18031993", EmployeeFunction.Operator);
            AddNewEmployee("DESIRE", "qwerty", EmployeeFunction.AccountManager);
            AddNewEmployee("ALEBA", "ALEBA", EmployeeFunction.Operator);
            Client client1 = AddNewClient("MOUSSA");
            Client client2 = AddNewClient("FEDIA");
            Client client4 = AddNewClient("PHILLIPE");
            Client client3 = AddNewClient("DEBIAN");
            CreateAccount(client1);
            CreateAccount(client2);
            CreateAccount(client4);
            CreateAccount(client3);
            CreateAccount(client1);
            CreateAccount(client4);
        }

        public void ApplyOperation(OperationTypes operation,Account account)
        {           
            switch (operation)
            {               
                case OperationTypes.CloseAccount:
                   new CloseAccount(CurrentEmployee, account).ApplyOperation();
                    break;                          
            }
        }

        public void ApplyOperation(OperationTypes operation, Account account, decimal amount)
        {
            switch (operation)
            {               
                case OperationTypes.Deposit:
                    new DepositOperation(CurrentEmployee,account,amount).ApplyOperation();
                    break;
                case OperationTypes.Withdraw:
                    new WithdrawOperation(CurrentEmployee,account,amount).ApplyOperation();
                    break;
            }
        }

        public Account CreateAccount(Client ownerClient)
        { 
            if (ownerClient == null)
                return null;
            var newAccount = new Account(ownerClient,Accounts.Count);
            Accounts.Add(newAccount);
            return newAccount;
        }
    }
}
