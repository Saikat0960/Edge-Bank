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
    public partial class CustomerLoginForm : Form
    {
        Bank Bankobj;
        int CustomerId;
        public CustomerLoginForm(Bank bank,int customerid)
        {
            Bankobj = bank;
            CustomerId = customerid;
            InitializeComponent();
        }

        private void Withdrawbutton_Click(object sender, EventArgs e)
        {
            AmountForm form1 = new AmountForm(Bankobj,CustomerId);
            var result1 = form1.ShowDialog();
            if (result1 == DialogResult.OK) { form1.Withdraw(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AmountForm form1 = new AmountForm(Bankobj, CustomerId);
            var result1 = form1.ShowDialog();
            if (result1 == DialogResult.OK) { form1.Deposit(); }
        }

        private void Loanbutton_Click(object sender, EventArgs e)
        {
            int AccountNo = Bankobj.isHaveAccountType(CustomerId, "Liability");
            if (AccountNo != 0)
            {
                LoanForm form1 = new LoanForm(Bankobj, CustomerId,AccountNo);
                form1.ShowDialog();
            }
            else { MessageBox.Show("You Don't have a Loan Account."); }
        }

        private void CreditDebitbutton_Click(object sender, EventArgs e)
        {
            CreditDebitForm form= new CreditDebitForm(Bankobj, CustomerId);
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowAccountForm form1 = new ShowAccountForm(Bankobj,CustomerId);
            form1.ShowDialog();
        }

        private void CustomerLoginForm_Load(object sender, EventArgs e)
        {
            IDtextBox.Text = CustomerId.ToString();
        }

        private void ChangePasswordbutton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(Bankobj, CustomerId);
            form.Show();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
