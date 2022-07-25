using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class Account
    {
        DBConnection db = new DBConnection();
        public int AccountNo { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }
        public DateTime DateofOpening { get; set; }
        public bool isActive { get; set; }

        public Account(string type)
        {
            this.AccountNo = db.GetMaxAccountNo() + 1;
            this.AccountType = type;
            this.Balance = 0;
            this.DateofOpening = DateTime.Now;
            this.isActive = true;
        }
    }
}
