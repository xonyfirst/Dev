using BankSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BankSystem.Create
{
    public partial class CreateAccount : Form
    {

        public  CreateAccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(iban.Text != "" && name.Text != "")
            {
                //Save in Text
                
                if(iban.Text.Length != 18)
                {
                    MessageBox.Show("Input IBAN not valid.");
                }else
                {
                    //Save
                    BankManage bank = new BankManage();
                    if(bank.IsDupIBAN(iban.Text))
                    {
                        MessageBox.Show("IBAN have exist in system.");
                    }else
                    {
                        //Save
                        bank.CreateBank(iban.Text, name.Text);
                        this.Close();
                    }

                }

            }
            else
            {
                MessageBox.Show("Input Invalid.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
