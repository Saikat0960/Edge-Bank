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
    public partial class CreditDebitForm : Form
    {
        Bank Bankobj;
        int CustomerID;
        public CreditDebitForm(Bank bank, int customer)
        {
            Bankobj = bank;
            CustomerID = customer;
            InitializeComponent();
        }
        private BindingSource ActivityBindingSource = new BindingSource();
        private void CreditDebitForm_Load(object sender, EventArgs e)
        {
            IDtextBox.Text = CustomerID.ToString();
            ActivityBindingSource.DataSource = Bankobj.GetCreditDebitInfo(CustomerID);
            ActivityDataGridView.DataSource = ActivityBindingSource;
        }
    }
}
