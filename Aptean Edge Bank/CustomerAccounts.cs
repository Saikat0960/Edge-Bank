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
    public partial class CustomerAccounts : Form
    {
        Bank Bankobj;
        int CustomerId;
        public CustomerAccounts(Bank bank,int Id)
        {
            Bankobj = bank;
            CustomerId = Id;
            InitializeComponent();
        }
        private BindingSource AccountBindingSource = new BindingSource();
        private void CustomerAccounts_Load(object sender, EventArgs e)
        {
            AccountBindingSource.DataSource = Bankobj.GetAllAccount(CustomerId);
            AccountlistBox.DataSource = AccountBindingSource;
            AccountlistBox.DisplayMember = "AccountNo";
            AccountlistBox.ValueMember = "AccountNo";

            AccountnotextBox.DataBindings.Add("Text", AccountBindingSource, "AccountNo");
            AccounttypetextBox.DataBindings.Add("Text", AccountBindingSource, "AccountType");
            BalancetextBox.DataBindings.Add("Text", AccountBindingSource, "Balance");
            DOOtextBox.DataBindings.Add("Text", AccountBindingSource, "DOO");
            StatustextBox.DataBindings.Add("Text", AccountBindingSource, "Status");
        }

        private void AddAccounttoolStripButton_Click(object sender, EventArgs e)
        {
            AddAccount form = new AddAccount(Bankobj,CustomerId);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                form.Addaccount();
            }
        }

        private void DeleteAccounttoolStripButton_Click(object sender, EventArgs e)
        {
            var AccountNo = Convert.ToInt32(AccountlistBox.SelectedValue);
            if (Bankobj.GetStatus(CustomerId, AccountNo) == 1)
            {
                if (Bankobj.GetAccountType(AccountNo) != "Liability")
                {
                    if (Bankobj.GetAccountBalance(AccountNo) == 0)
                    {
                        Bankobj.DeleteAccount(CustomerId, AccountNo);
                        MessageBox.Show("Account Deleted from database.");
                    }
                    else { MessageBox.Show("You must have Zero Balance to Close Account");}
                }
                else { MessageBox.Show("Liability Account Can't be Closed"); }
            }
            else { MessageBox.Show("Account is already Closed."); }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerAccounts form = new CustomerAccounts(Bankobj, CustomerId);
            form.ShowDialog();
        }

        private void ReopenAccounttoolStripButton_Click(object sender, EventArgs e)
        {
            var AccountNo = Convert.ToInt32(AccountlistBox.SelectedValue);
            if (Bankobj.GetStatus(CustomerId,AccountNo) == 0)
            {
                Bankobj.ReopenAccount(CustomerId, AccountNo);
                MessageBox.Show("Account Reopened in database.");
            }
            else { MessageBox.Show("Account is Already Opened"); }
        }
    }
}
