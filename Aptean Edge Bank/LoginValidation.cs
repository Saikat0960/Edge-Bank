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
    public partial class LoginValidation : Form
    {
        Bank Bankobj;
        public LoginValidation(Bank bank)
        {
            Bankobj = bank;
            InitializeComponent();
        }
        public bool AdminValidation()
        {
            try
            {
                return Bankobj.GetAdminLogin(int.Parse(CustomerIdtextBox.Text), PasswordtextBox.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter valid Details.");
                return false;
            }
        }
        public void UserValidation()
        {
            try
            {
                if (Bankobj.GetLogin(int.Parse(CustomerIdtextBox.Text), PasswordtextBox.Text))
                {
                    CustomerLoginForm form1 = new CustomerLoginForm(Bankobj, int.Parse(CustomerIdtextBox.Text));
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter Valid Username & Password");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter valid Details.");
            }
        }
    }
}
