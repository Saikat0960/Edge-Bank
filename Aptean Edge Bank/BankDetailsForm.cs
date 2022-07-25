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
    public partial class BankDetailsForm : Form
    {
        Bank BankObj;
        public BankDetailsForm(Bank bank)
        {
            BankObj = bank;
            InitializeComponent();
        }

        private void BankDetailsForm_Load(object sender, EventArgs e)
        {
            BankName.Text = "Aptean Edge Bank";
            IFSCCode.Text = "APEB98765";
            Branch.Text = "Bangalore";
            BalancetextBox.Text = BankObj.GetBankBalance().ToString();
        }
    }
}
