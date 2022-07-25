using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class DBConnection
    {
        public void InsertCustomer(Customer customer)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            con.Open();
            //string s = "Declare @p1 int,@p2 nvarchar(50),@p3 nvarchar(50),@p4 datetime,@p5 datetime,@p6 nvarchar(50),@p7 nvarchar(50),@p8 nvarchar(50);" +
            //    "insert into Customer_Data values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            string s = "insert into Customer_Data values(" + customer.CustomerID + ",'" + customer.Name + "','" + customer.Contact + "'," + customer.Birthdate.ToString("yyyy-MM-dd") + "" +
                "," + customer.DateofJoining.ToString("yyyy-MM-dd") + ",'" + customer.Address + "','" + customer.isActive + "','" + customer.Password + "')";
            OleDbCommand cmd = new OleDbCommand(s, con);
            //cmd.Parameters.AddWithValue("@p1", customer.CustomerID);
            //cmd.Parameters.AddWithValue("@p2", customer.Name);
            //cmd.Parameters.AddWithValue("@p3", customer.Contact);
            //cmd.Parameters.AddWithValue("@p4", customer.Birthdate);
            //cmd.Parameters.AddWithValue("@p5", customer.DateofJoining);
            //cmd.Parameters.AddWithValue("@p6", customer.Address);
            //cmd.Parameters.AddWithValue("@p7", customer.isActive);
            //cmd.Parameters.AddWithValue("@p8", customer.Password);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }
        //public void InsertAccount(int CustomerId, Account account)
        //{
        //    OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
        //    OleDbCommand cmd;
        //    con.Open();
        //    string s = "insert into Account_Data values(@p1,@p2,@p3,@p4,@p5,@p6)";
        //    cmd = new OleDbCommand(s, con);
        //    cmd.Parameters.AddWithValue("@p1", CustomerId);
        //    cmd.Parameters.AddWithValue("@p2", account.AccountNo);
        //    cmd.Parameters.AddWithValue("@p3", account.AccountType);
        //    cmd.Parameters.AddWithValue("@p4", account.Balance);
        //    cmd.Parameters.AddWithValue("@p5", account.DateofOpening);
        //    cmd.Parameters.AddWithValue("@p6", account.isActive);
        //    cmd.CommandType = CommandType.Text;
        //    int i = cmd.ExecuteNonQuery();
        //    con.Close();
        //}
        public virtual void InsertAccountActivity(int CustomerId, int AccountNo, string AccountType, string Operation, double amount)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            OleDbCommand cmd;
            con.Open();
            string s = "insert into Account_Activity_Log values(@p1,@p2,@p3,@p4,@p5,@p6)";
            cmd = new OleDbCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", CustomerId);
            cmd.Parameters.AddWithValue("@p2", AccountNo);
            cmd.Parameters.AddWithValue("@p3", AccountType);
            cmd.Parameters.AddWithValue("@p4", Operation);
            cmd.Parameters.AddWithValue("@p5", amount);
            cmd.Parameters.AddWithValue("@p6", DateTime.Now);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }
        public object GetCustomers()
        {
            DataSet dataSet = new DataSet();
            var cn = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            OleDbDataAdapter Cda = new OleDbDataAdapter("Select * From Customer_Data", cn);
            var builder = new OleDbCommandBuilder(Cda);
            Cda.Fill(dataSet, "Customer_Data");
            var table = dataSet.Tables["Customer_Data"];
            return table;
        }
        public object GetAccounts(int CustomerId)
        {
            DataSet dataSet = new DataSet();
            var cn = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            OleDbDataAdapter Ada = new OleDbDataAdapter("Select * From Account_Data", cn);
            var builder = new OleDbCommandBuilder(Ada);
            Ada.Fill(dataSet, "Account_Data");
            var table = dataSet.Tables["Account_Data"];
            table.DefaultView.RowFilter = "CustomerID = " + CustomerId;
            return table;
        }
        public object GetAccountActivityLog(int CustomerId)
        {
            DataSet dataSet = new DataSet();
            var cn = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            OleDbDataAdapter Ada = new OleDbDataAdapter("Select * From Account_Activity_Log", cn);
            var builder = new OleDbCommandBuilder(Ada);
            Ada.Fill(dataSet, "Account_Activity_Log");
            var table = dataSet.Tables["Account_Activity_Log"];
            table.DefaultView.RowFilter = "CustomerID = " + CustomerId;
            return table;
        }
        public void UpdateCustomer(int CustomerId, string Contact, string Address)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            con.Open();
            string s = "update Customer_Data set Contact='" + Contact + "',Address='" + Address + "' where CustomerID=" + CustomerId;
            OleDbCommand cmd = new OleDbCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", Contact);
            cmd.Parameters.AddWithValue("@p2", Address);
            cmd.Parameters.AddWithValue("@p3", CustomerId);
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }
        public virtual void UpdateAccount(int CustomerId, int AccountNo, double Balance)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            con.Open();
            string s = "update Account_Data set Balance=@p1 where AccountNo=@p2 and CustomerID=@p3";
            OleDbCommand cmd = new OleDbCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", Balance);
            cmd.Parameters.AddWithValue("@p2", AccountNo);
            cmd.Parameters.AddWithValue("@p3", CustomerId);
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }
        public virtual void UpdateBankBalance(double Balance)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            con.Open();
            string s = "update Admin_Data set Balance=@p1";
            OleDbCommand cmd = new OleDbCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", Balance);
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteCustomer(int CustomerId, bool isActive)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            con.Open();
            string s = "update Customer_Data set Status='" + isActive + "' where CustomerID=" + CustomerId;
            OleDbCommand cmd = new OleDbCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", isActive);
            cmd.Parameters.AddWithValue("@p2", CustomerId);
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteAccount(int CustomerId, int AccountNo, bool isActive)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            con.Open();
            string s = "update Account_Data set Status=@p1 where AccountNo=@p2 and CustomerID=@p3";
            OleDbCommand cmd = new OleDbCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", isActive);
            cmd.Parameters.AddWithValue("@p2", AccountNo);
            cmd.Parameters.AddWithValue("@p3", CustomerId);
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }
        public int ChangePassword(int CustomerId, string Currentpass, string Newpass)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            con.Open();
            string s = "update Customer_Data set Password=@p1 where Password=@p2 and CustomerID=@p3";
            OleDbCommand cmd = new OleDbCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", Newpass);
            cmd.Parameters.AddWithValue("@p2", Currentpass);
            cmd.Parameters.AddWithValue("@p3", CustomerId);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public bool LoginValidation(int customerid, string password)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
                con.Open();
                string s = "select CustomerID, Password from Customer_Data";
                OleDbCommand cmd = new OleDbCommand(s, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetValue(0).ToString() == customerid.ToString() && reader.GetString(1) == password)
                    {
                        return true;
                    }
                }
                int i = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public bool AdminLogin(int customerid, string password)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat; Integrated Security=SSPI;");
                con.Open();
                string s = "select CustomerID, Password from Admin_Data";
                OleDbCommand cmd = new OleDbCommand(s, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetValue(0).ToString() == customerid.ToString() && reader.GetString(1) == password)
                    {
                        return true;
                    }
                }
                int i = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public virtual string GetAccountType(int AccountNo)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            con.Open();
            string s = "select AccountType from Account_Data where AccountNo=@p1";
            OleDbCommand cmd = new OleDbCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", AccountNo);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0).Equals("Chequing"))
                {
                    return "Chequing";
                }
                else if (reader.GetString(0).Equals("TaxFree"))
                {
                    return "TaxFree";
                }
                else if (reader.GetString(0).Equals("Liability"))
                {
                    return "Liability";
                }
            }
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return null;
        }
        public virtual double GetAccountBalance(int AccountNo)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            con.Open();
            string s = "select Balance from Account_Data where AccountNo=@p1";
            OleDbCommand cmd = new OleDbCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", AccountNo);
            double balance = Convert.ToDouble(cmd.ExecuteScalar());
            con.Close();
            return balance;
        }
        public virtual double BankBalance()
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            con.Open();
            string s = "select Balance from Admin_Data";
            OleDbCommand cmd = new OleDbCommand(s, con);
            double balance = Convert.ToDouble(cmd.ExecuteScalar());
            con.Close();
            return balance;
        }

        public int GetMaxAccountNo()
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            con.Open();
            string s = "select MAX(AccountNo) from Account_Data";
            OleDbCommand cmd = new OleDbCommand(s, con);
            int max = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return max;
        }
        public int GetMaxCustomerId()
        {
            OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
            con.Open();
            string s = "select MAX(CustomerID) from Customer_Data";
            OleDbCommand cmd = new OleDbCommand(s, con);
            int max = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return max;
        }
        public int isHaveAccType(int CustomerId, string AccType)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
                con.Open();
                string s = "select AccountNo from Account_Data where CustomerID=@p1 and AccountType=@p2";
                OleDbCommand cmd = new OleDbCommand(s, con);
                cmd.Parameters.AddWithValue("@p1", CustomerId);
                cmd.Parameters.AddWithValue("@p2", AccType);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                //int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int GetAccountStatus(int CustomerId, int AccountNo)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=Saikat;Integrated Security=SSPI");
                con.Open();
                string s = "select Status from Account_Data where CustomerID=@p1 and AccountNo=@p2";
                OleDbCommand cmd = new OleDbCommand(s, con);
                cmd.Parameters.AddWithValue("@p1", CustomerId);
                cmd.Parameters.AddWithValue("@p2", AccountNo);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return i;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
