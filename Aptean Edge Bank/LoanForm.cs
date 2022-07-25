using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Aptean_Edge_Bank
{
    public partial class LoanForm : Form
    {
        Bank Bankobj;
        int CustomerId, AccountNo;
        public LoanForm(Bank bank,int customerid,int accountno)
        {
            Bankobj = bank;
            CustomerId = customerid;
            AccountNo = accountno;
            InitializeComponent();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            IDtextBox.Text = CustomerId.ToString();
            AccountNotextBox.Text = AccountNo.ToString();
            AmounttextBox.Text = Bankobj.GetLoanAmount(AccountNo).ToString();
        }

        private void Repaymentbutton_Click(object sender, EventArgs e)
        {
            if (int.Parse(AmounttextBox.Text) != 0)
            {
                RepaymentLoanForm form1 = new RepaymentLoanForm(Bankobj, CustomerId, AccountNo, double.Parse(AmounttextBox.Text));
                form1.ShowDialog();
            }
            else { MessageBox.Show("You don't have Current Loan"); }
            this.Close();
        }
    }
}
