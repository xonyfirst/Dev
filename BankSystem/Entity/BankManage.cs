using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BankSystem.Entity
{
    public class BankManage
    {
        string path = System.AppDomain.CurrentDomain.BaseDirectory + "\\Data\\BankMaster.txt";
        //StreamReader sr = new StreamReader(path);


        public bool IsDupIBAN(string iban)
        {
            bool res = false;

            string cur = File.ReadAllText(path);

            if(cur.Contains(iban))
            {
                return true;
            }

            return res;
        }


        public void Deposite(string iban , decimal money)
        {

            string[] acc = File.ReadAllLines(path);

            //cal fee
            money =  money - ((money * (decimal) 0.1/ 100));

            //Get cur
            string newdata = "";
            foreach(string inp in acc)
            {
                string[] detail  = inp.Split(",");
                if(detail[0] == iban)
                {
                    //Add
                    decimal total = decimal.Parse(detail[2]) + money;

                    newdata += detail[0] + "," + detail[1] + "," + total + "\r\n";

                }
                else
                {
                    newdata += inp+"\r\n";
                }

            }


            File.WriteAllText(path, newdata);
        }

        public AccountBank GetDetailBank(string iban)
        {
            AccountBank acc_det = new AccountBank();

            string[] acc = File.ReadAllLines(path);

            foreach (string inp in acc)
            {
                string[] detail = inp.Split(",");
                if (detail[0] == iban)
                {
                    acc_det.IBAN = detail[0];
                    acc_det.Name = detail[1];
                    acc_det.Total = detail[2];

                    return acc_det;
                }

            }

            return acc_det;
        }

        public void CreateBank(string iban,string name)
        {
            string cur = File.ReadAllText(path);

            File.WriteAllText(path, cur+"\r\n"+ iban +","+ name+",0");

        }


        public string Transfer(string from_iban,string to_iban, string money)
        {
            string res = "";

            string[] acc = File.ReadAllLines(path);

            //valid money from > send 

            string money_from = "";

            foreach (string inp in acc)
            {
                string[] detail = inp.Split(",");
                if (detail[0] == from_iban)
                {
                    //Get current monry
                    money_from = detail[2];
                }
            }

            if(decimal.Parse(money_from) < decimal.Parse(money))
            {
                return "Cannot transfer because money not enough !!!";
            }else
            {
                //transfer
                decimal updatefrommoney = 0;
                decimal updatetomoney = 0;

                string new_str = "";

                foreach (string inp in acc)
                {
                    string[] detail = inp.Split(",");

                    if(detail[0] != "")
                    {
                        if (detail[0] == from_iban)
                        {
                            //Get current monry
                            updatefrommoney = decimal.Parse(detail[2]) - decimal.Parse(money);
                            //Update
                            new_str += detail[0] + "," + detail[1] + "," + updatefrommoney + "\r\n";

                        }
                        else if (detail[0] == to_iban)
                        {
                            //Get current monry
                            updatetomoney = decimal.Parse(detail[2]) + decimal.Parse(money);

                            //Update
                            new_str += detail[0] + "," + detail[1] + "," + updatetomoney + "\r\n";

                        }
                        else
                        {
                            new_str += detail[0] + "," + detail[1] + "," + detail[2] + "\r\n";
                        }
                    }

                }


                File.WriteAllText(path, new_str);
                return "Success";
            }

            return "Success";

        }

    }
}
