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
    public partial class AmountForm : Form
    {
        Bank Bankobj;
        int CustomerId;
        public AmountForm(Bank bank,int customerid)
        {
            Bankobj = bank;
            CustomerId = customerid;
            InitializeComponent();
        }

        private void AmountForm_Load(object sender, EventArgs e)
        {
            IDtextBox.Text = CustomerId.ToString();
        }

        public void Withdraw()
        {
            try
            {
                int i = Bankobj.GetStatus(CustomerId, int.Parse(AccountNotextBox.Text));
                if (i == 1)
                {
                    if (Bankobj.GetAccountType(int.Parse(AccountNotextBox.Text)) != "Liability")
                    {
                        if (Bankobj.Withdraw(CustomerId, int.Parse(AccountNotextBox.Text), double.Parse(AmounttextBox.Text)))
                        {
                            MessageBox.Show("Transaction Successfull");
                        }
                        else { MessageBox.Show("Insufficient Balance."); }
                    }
                    else { MessageBox.Show("Can't Perform transaction on loan account. Declined."); }
                }
                else { MessageBox.Show("AccountNo Don't Exist or Account has been Closed. Contact Admin."); }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter valid Details.");
            }
        }
        public void Deposit()
        {
            try
            {
                int i = Bankobj.GetStatus(CustomerId, int.Parse(AccountNotextBox.Text));
                if (i == 1)
                {
                    if (Bankobj.GetAccountType(int.Parse(AccountNotextBox.Text)) != "Liability")
                    {
                        if (Bankobj.Deposit(CustomerId, int.Parse(AccountNotextBox.Text), double.Parse(AmounttextBox.Text)))
                        {
                            MessageBox.Show("Transaction Successfull");
                        }
                        else { MessageBox.Show("Maximum Limit is 5000. Limit Exceeded"); }
                    }
                    else { MessageBox.Show("Can't Perform transaction on loan account. Declined."); }
                }
                else { MessageBox.Show("AccountNo Don't Exist or Account has been Closed. Contact Admin."); }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter valid Details.");
            }
        }
    }
}
