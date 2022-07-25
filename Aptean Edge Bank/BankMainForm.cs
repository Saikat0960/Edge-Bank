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
    public partial class BankMainForm : Form
    {
        public BankMainForm()
        {
            InitializeComponent();
        }
        Bank BankObject = new Bank();
        private void BankMainForm_Load(object sender, EventArgs e)
        {
            Timelabel.Text = DateTime.Now.ToString();
        }
        private void Adminbutton_Click(object sender, EventArgs e)
        {
            LoginValidation form = new LoginValidation(BankObject);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (form.AdminValidation())
                {
                    EdgeBank form1 = new EdgeBank(BankObject);
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter Valid Username & Password");
                }
            }
        }
        private void CustomerLoginbutton_Click(object sender, EventArgs e)
        {
            LoginValidation form = new LoginValidation(BankObject);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                form.UserValidation();
            }
        }

        private void BankInfobutton_Click(object sender, EventArgs e)
        {
            LoginValidation form = new LoginValidation(BankObject);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (form.AdminValidation())
                {
                    BankDetailsForm form1 = new BankDetailsForm(BankObject);
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter Valid Username & Password");
                }
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
