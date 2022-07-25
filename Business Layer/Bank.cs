using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class Bank
    {
        DBConnection db;
        System.Diagnostics.Stopwatch watch;
        public Bank()
        {
            db = new DBConnection();
            watch = new System.Diagnostics.Stopwatch();
        }
        public Bank(DBConnection DB)
        {
            db = DB;
            watch = new System.Diagnostics.Stopwatch();
        }
        public void CreateCustomer(string name, string contact, string address, DateTime birthdate, string pass)
        {
            //watch.Start();
            Customer customer = new Customer(name, contact, birthdate, address, pass);
            db.InsertCustomer(customer);
            //watch.Stop();
        }
        public void ModifyCustomer(int customerid, string contact, string address)
        {
            //watch.Start();
            db.UpdateCustomer(customerid, contact, address);
            //watch.Stop();
        }
        public void RemoveCustomer(int customerid)
        {
            //watch.Start();
            db.DeleteCustomer(customerid,false);
            //watch.Stop();
            //StreamWriter sw = new StreamWriter("time.txt", true);
            //sw.WriteLine("Total time taken : " + watch.ElapsedMilliseconds);
            //sw.Close();
        }
        public Account CreateAccount(int Customerid, string type)
        {
            if (type.Equals("Chequing"))
            {
                ChequingAccount account = new ChequingAccount();
                db.InsertAccount(Customerid, account);
                return account;
            }
            else if (type.Equals("Liability"))
            {
                LiabilityAccount account = new LiabilityAccount();
                db.InsertAccount(Customerid, account);
                return account;
            }
            else
            {
                TaxfreeAccount account = new TaxfreeAccount();
                db.InsertAccount(Customerid, account);
                return account;
            }
        }
        public void DeleteAccount(int customerid, int accountno)
        {
            db.DeleteAccount(customerid, accountno,false);
        }
        public void ReopenAccount(int customerid, int accountno)
        {
            db.DeleteAccount(customerid, accountno, true);
        }

        public bool Deposit(int customerid, int accountno, double amount)
        {
            string account = db.GetAccountType(accountno);
            Double balance = db.GetAccountBalance(accountno);
            Double Bankbalance = db.BankBalance();
            if (account.Equals("Chequing"))
            {
                balance += amount;
                db.UpdateAccount(customerid, accountno, balance);
                db.UpdateBankBalance(Bankbalance + amount);
                db.InsertAccountActivity(customerid, accountno, "Chequing", "Deposit", amount);
                return true;
            }
            else
            {
                if (balance + amount <= 5000)
                {
                    balance += amount;
                    db.UpdateAccount(customerid, accountno, balance);
                    db.UpdateBankBalance(Bankbalance + amount);
                    db.InsertAccountActivity(customerid, accountno, "Taxfree", "Deposit", amount);
                    return true;
                }
                else { return false; }
            }
        }
        public bool Withdraw(int customerid, int accountno, double amount)
        {
            Double balance = db.GetAccountBalance(accountno);
            Double Bankbalance = db.BankBalance();
            if (balance >= amount)
            {
                balance -= amount;
                db.UpdateAccount(customerid, accountno, balance);
                db.UpdateBankBalance(Bankbalance - amount);
                db.InsertAccountActivity(customerid, accountno, db.GetAccountType(accountno), "Withdraw", amount);
                return true;
            }
            else { return false; }
        }
        public object GetAllCustomer()
        {
            return db.GetCustomers();
        }
        public object GetAllAccount(int CustomerId)
        {
            return db.GetAccounts(CustomerId);
        }
        public object GetCreditDebitInfo(int CustomerId)
        {
            return db.GetAccountActivityLog(CustomerId);
        }
        public bool GetLogin(int customerid, string password)
        {
            if(db.LoginValidation(customerid, password))
            {
                db.DeleteCustomer(customerid, true);
                return true;
            }
            return false;
        }
        public bool GetAdminLogin(int customerid, string password)
        {
            return db.AdminLogin(customerid, password);
        }
        public int ChangePassword(int customerid, string currpass, string newpass)
        {
            return db.ChangePassword(customerid, currpass, newpass);
        }
        public int isHaveAccountType(int customerid,string type)
        {
            return db.isHaveAccType(customerid, type);
        }
        public double GetLoanAmount(int accountno)
        {
            return db.GetAccountBalance(accountno);
        }
        public void IssueLoan(int CustomerId, int accountno, double amount)
        {
            Double balance = db.GetAccountBalance(accountno);
            Double Bankbalance = db.BankBalance();
            balance += amount;
            db.UpdateAccount(CustomerId, accountno, balance);
            db.UpdateBankBalance(Bankbalance - amount);
        }
        public bool RepayLoan(int CustomerId, int accountno, double amount)
        {
            Double balance = db.GetAccountBalance(accountno);
            Double Bankbalance = db.BankBalance();
            if (amount <= balance)
            {
                balance -= amount;
                db.UpdateAccount(CustomerId, accountno, balance);
                db.UpdateBankBalance(Bankbalance + amount);
                return true;
            }
            else { return false; }
        }
        public double GetBankBalance()
        {
            return db.BankBalance();
        }
        public int GetStatus(int CustomerId, int accountno)
        {
            return db.GetAccountStatus(CustomerId, accountno);
        }
        public double GetAccountBalance(int accountno)
        {
            return db.GetAccountBalance(accountno);
        }
        public string GetAccountType(int accountno)
        {
            return db.GetAccountType(accountno);
        }
        public void CalculateTime()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for(int i=0; i<100; i++)
            {
                CreateCustomer("ABCD","98765434567","qwerty",DateTime.Now,"qwerty");
                ModifyCustomer(db.GetMaxCustomerId(), "98765434567", "qwerty");
                RemoveCustomer(db.GetMaxCustomerId());
            }
            watch.Stop();
            StreamWriter sw = new StreamWriter("time.txt", true);
            sw.WriteLine("Total time taken : " + watch.ElapsedMilliseconds);
            sw.Close();
            //Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}
