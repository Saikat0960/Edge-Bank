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
    public partial class AddCustomerForm : Form
    {
        Bank BankObject;
        public AddCustomerForm(Bank bank)
        {
            InitializeComponent();
            BankObject = bank;
        }

        public void Addcustomer()
        {
            try
            {
                BankObject.CreateCustomer(NametextBox.Text, ContacttextBox.Text, AddresstextBox.Text, DOBtextBox.Value, PasswordtextBox.Text);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }   
    }
}
