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
    public partial class ChangePasswordForm : Form
    {
        Bank Bankobj;
        int CustomerId;
        public ChangePasswordForm(Bank bank,int id)
        {
            Bankobj = bank;
            CustomerId = id;
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            IDtextBox.Text = CustomerId.ToString();
        }

        private void Proceedbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Bankobj.ChangePassword(CustomerId, CurrentPasstextBox.Text, NewPasstextBox.Text) == 1)
                {
                    MessageBox.Show("Password Changed Successfuly");
                    this.Hide();
                }
                else { MessageBox.Show("Current Password is Wrong"); }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter valid Details.");
            }
        }
    }
}
