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
    public partial class ShowAccountForm : Form
    {
        Bank Bankobj;
        int CustomerId;
        public ShowAccountForm(Bank bank,int Id)
        {
            Bankobj = bank;
            CustomerId = Id;
            InitializeComponent();
        }
        private BindingSource AccountBindingSource = new BindingSource();
        private void ShowAccountForm_Load(object sender, EventArgs e)
        {
            AccountBindingSource.DataSource = Bankobj.GetAllAccount(CustomerId);
            AccountlistBox.DataSource = AccountBindingSource;
            AccountlistBox.DisplayMember = "AccountNo";

            AccountnotextBox.DataBindings.Add("Text", AccountBindingSource, "AccountNo");
            AccounttypetextBox.DataBindings.Add("Text", AccountBindingSource, "AccountType");
            BalancetextBox.DataBindings.Add("Text", AccountBindingSource, "Balance");
            DOOtextBox.DataBindings.Add("Text", AccountBindingSource, "DOO");
            StatustextBox.DataBindings.Add("Text", AccountBindingSource, "Status");
        }
    }
}
