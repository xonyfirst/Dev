using BankSystem.Create;
using BankSystem.Deposite;
using BankSystem.Entity;
using BankSystem.Transfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAccount create_acc = new CreateAccount();
            create_acc.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string math = "70+82*79-78+84/73+83";
            string value = new DataTable().Compute(math, null).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepositForm depo = new DepositForm();
            depo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show_name.Text = "";
            show_money.Text = "";


            BankManage bankM = new BankManage();

            AccountBank acc =  bankM.GetDetailBank(iban_det.Text);



            show_name.Text = acc.Name;
            show_money.Text = acc.Total;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TransferForm transferf = new TransferForm();
            transferf.Show();
        }
    }
}
