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
    public partial class RepaymentLoanForm : Form
    {
        Bank BankObj;
        int CustomerId, AccountNo;
        Double LoanAmount;
        public RepaymentLoanForm(Bank bank,int customerid,int accountno,double amount)
        {
            BankObj = bank;
            CustomerId = customerid;
            LoanAmount = amount;
            AccountNo = accountno;
            InitializeComponent();
        }

        private void AmounttextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoantextBox.Text = (LoanAmount - double.Parse(AmounttextBox.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter valid Details.");
            }
        }

        private void RepaymentLoanForm_Load(object sender, EventArgs e)
        {
            try
            {
                IDtextBox.Text = CustomerId.ToString();
                AccountNotextBox.Text = AccountNo.ToString();
                LoantextBox.Text = LoanAmount.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter valid Details.");
            }
        }

        private void Proceedbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BankObj.RepayLoan(CustomerId, AccountNo, double.Parse(AmounttextBox.Text)))
                {
                    MessageBox.Show("Transaction Successfull.");
                    this.Close();
                }
                else { MessageBox.Show("Loan Amount is Less."); }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter valid Details.");
            }
        }
    }
}
