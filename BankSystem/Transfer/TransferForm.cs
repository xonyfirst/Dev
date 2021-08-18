using BankSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankSystem.Transfer
{
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //valid from exist
            BankManage bank = new BankManage();
            if (!bank.IsDupIBAN(from_iban.Text))
            {
                 MessageBox.Show("Not found FROM IBAN in system.");
                this.Close();
            }

            //valid to exist
            if (!bank.IsDupIBAN(to_Iban.Text))
            {
                MessageBox.Show("Not found To IBAN in system.");
                this.Close();
            }

            //valid to exist
            if (String.IsNullOrEmpty(send_money.Text))
            {
                MessageBox.Show("Not found money.");
                this.Close();
            }

            //valid money
            string res = bank.Transfer(from_iban.Text, to_Iban.Text, send_money.Text);

            MessageBox.Show(res);
            this.Close();

        }
    }
}
