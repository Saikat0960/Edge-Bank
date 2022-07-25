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
    public partial class AddAccount : Form
    {
        Bank BankObject;
        int CustomerId;
        public AddAccount(Bank bank,int customerid)
        {
            BankObject = bank;
            CustomerId = customerid;
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            CustomerIDtextBox.Text = CustomerId.ToString();

        }
        public void Addaccount()
        {
            try
            {
                if (Chequing.Checked)
                {
                    if (BankObject.isHaveAccountType(CustomerId, "Chequing") == 0)
                    {
                        BankObject.CreateAccount(CustomerId, "Chequing");
                        MessageBox.Show("Account Added to Database.");
                    }
                    else { MessageBox.Show("Customer already have an existing Chequing Account"); }
                }
                else if (Taxfree.Checked)
                {
                    if (BankObject.isHaveAccountType(CustomerId, "TaxFree") == 0)
                    {
                        BankObject.CreateAccount(CustomerId, "TaxFree");
                        MessageBox.Show("Account Added to Database.");
                    }
                    else { MessageBox.Show("Customer already have an existing Taxfree Account"); }
                }
                else if (Liability.Checked)
                {
                    if (BankObject.isHaveAccountType(CustomerId, "Liability") == 0)
                    {
                        BankObject.CreateAccount(CustomerId, "Liability");
                        MessageBox.Show("Account Added to Database.");
                    }
                    else { MessageBox.Show("Customer already have an existing Liability Account"); }
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Please select the Type of Account");
            }
        }
    }
}
