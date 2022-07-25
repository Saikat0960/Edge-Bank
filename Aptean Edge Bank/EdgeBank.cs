using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Aptean_Edge_Bank
{
    public partial class EdgeBank : Form
    {
        Bank BankObject;
        public EdgeBank(Bank bank)
        {
            BankObject = bank;
            InitializeComponent();
        }
        private BindingSource CustomerBindingSource = new BindingSource();
        private void EdgeBank_Load(object sender, EventArgs e)
        {
            try
            {
                CustomerBindingSource.DataSource = BankObject.GetAllCustomer();
                CustomerListBox.DataSource = CustomerBindingSource;
                CustomerListBox.DisplayMember = "Name";
                CustomerListBox.ValueMember = "CustomerID";

                IDtextBox.DataBindings.Add("Text", CustomerBindingSource, "CustomerID");
                NametextBox.DataBindings.Add("Text", CustomerBindingSource, "Name");
                ContacttextBox.DataBindings.Add("Text", CustomerBindingSource, "Contact");
                BirthdatetextBox.DataBindings.Add("Text", CustomerBindingSource, "DOB");
                DOJtextBox.DataBindings.Add("Text", CustomerBindingSource, "DOJ");
                AddresstextBox.DataBindings.Add("Text", CustomerBindingSource, "Address");
                StatustextBox.DataBindings.Add("Text", CustomerBindingSource, "Status");
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter valid Details.");
            }
        }
        private void AddusertoolStripButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm(BankObject);
            var result = form.ShowDialog();
            if (result == DialogResult.Yes)
            {
                form.Addcustomer();
                MessageBox.Show("Customer Added to database.");
            }
        }

        private void DeleteusertoolStripButton_Click(object sender, EventArgs e)
        {
            var CustomerId = Convert.ToInt32(CustomerListBox.SelectedValue);
            BankObject.RemoveCustomer(CustomerId);
            MessageBox.Show("Customer Deleted from database.");
            //CustomerBindingSource.Remove(customer);
        }

        private void AccountDetailsbutton_Click(object sender, EventArgs e)
        {
            var CustomerId = Convert.ToInt32(CustomerListBox.SelectedValue);
            CustomerAccounts form = new CustomerAccounts(BankObject,CustomerId);
            form.ShowDialog();
        }

        private void UpdatetoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                var CustomerId = Convert.ToInt32(CustomerListBox.SelectedValue);
                BankObject.ModifyCustomer(CustomerId, ContacttextBox.Text, AddresstextBox.Text);
                MessageBox.Show("Customer Details Updated.");
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter valid Details.");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EdgeBank form = new EdgeBank(BankObject);
            form.ShowDialog();
        }

        private void Loanbutton_Click(object sender, EventArgs e)
        {
            var CustomerId = Convert.ToInt32(CustomerListBox.SelectedValue);
            int AccountNo = BankObject.isHaveAccountType(CustomerId, "Liability");
            if (AccountNo!=0)
            {
                IssueLoanForm form = new IssueLoanForm(BankObject, CustomerId, AccountNo);
                form.ShowDialog();
            }
            else { MessageBox.Show("Customer don't have a Liability Account."); }
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
