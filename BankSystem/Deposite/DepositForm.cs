using BankSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankSystem.Deposite
{
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (iban.Text != "" && money.Text != "")
            {
                //Save in Text

                if (iban.Text.Length != 18)
                {
                    MessageBox.Show("Input IBAN not valid.");
                }
                else
                {
                    //Save
                    BankManage bank = new BankManage();
                    if (!bank.IsDupIBAN(iban.Text))
                    {
                        MessageBox.Show("Not found IBAN in system.");
                    }
                    else
                    {
                        //Save
                        bank.Deposite(iban.Text, decimal.Parse(money.Text));
                        this.Close();
                    }

                }

            }
            else
            {
                MessageBox.Show("Input Invalid.");
            }
        }
    }
}
