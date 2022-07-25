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
    public partial class IssueLoanForm : Form
    {
        Bank Bankobj;
        int CustomerId, AccountNo;
        public IssueLoanForm(Bank bank,int customerid,int accountno)
        {
            Bankobj = bank;
            CustomerId = customerid;
            AccountNo = accountno;
            InitializeComponent();
        }

        private void IssueLoanForm_Load(object sender, EventArgs e)
        {
            IDtextBox.Text = CustomerId.ToString();
            AccountNotextBox.Text = AccountNo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Bankobj.GetBankBalance() > double.Parse(AmounttextBox.Text))
                {
                    Bankobj.IssueLoan(CustomerId, AccountNo, double.Parse(AmounttextBox.Text));
                    MessageBox.Show("Loan Issued Successfully");
                }
                else { MessageBox.Show("Maximum Loan Amount Reached. \nLoan Can't be Issued."); }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter valid Details.");
            }
        }
    }
}
