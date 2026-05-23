using CashierApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashier;
        public frmLoginAccount()
        {
            InitializeComponent();
             cashier = new Cashier("Jasper Ferrer", "Finance", "admin", "Anokaswerte123");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cashier.validateLogin(txtLogin.Text, txtPassword.Text))
            {

                string name = cashier.getFullName();
                string dept = cashier.getDepartment();
                MessageBox.Show($"Welcome {name} of {dept}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPurchaseDiscountedItem frm = new frmPurchaseDiscountedItem();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
