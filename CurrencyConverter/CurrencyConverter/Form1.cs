using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            //USD
            double i = int.Parse(amount_txt.Text);
            if(fromcombo1.SelectedItem.ToString()== "USD" && tocombo2.SelectedItem.ToString() == "EUR")
            {
               double conver = i * 0.85;
                display_txt.Text = "Итог:" + conver+"\t EUR";
            }
            if (fromcombo1.SelectedItem.ToString() == "USD" && tocombo2.SelectedItem.ToString() == "USD")
            {
                double conver = i * 0;
                display_txt.Text = "Итог:" + conver + "\t USD";
            }
            if (fromcombo1.SelectedItem.ToString() == "USD" && tocombo2.SelectedItem.ToString() == "RUB")
            {
                double conver = i * 65.03;
                display_txt.Text = "Итог:" + conver+"\t RUB";
            }
            if (fromcombo1.SelectedItem.ToString() == "USD" && tocombo2.SelectedItem.ToString() == "BYN")
            {
                double conver = i * 2.08;
                display_txt.Text = "Итог:" + conver + "\t BYN";
            }
            if (fromcombo1.SelectedItem.ToString() == "USD" && tocombo2.SelectedItem.ToString() == "PLN")
            {
                double conver = i *3.66;
                display_txt.Text = "Итог:" + conver + "\t PLN";
            }
            if (fromcombo1.SelectedItem.ToString() == "USD" && tocombo2.SelectedItem.ToString() == "UAX")
            {
                double conver = i *28.12;
                display_txt.Text = "Итог:" + conver + "\t UAX";
            }


            //EUR
            if (fromcombo1.SelectedItem.ToString() == "EUR" && tocombo2.SelectedItem.ToString() == "USD")
            {
                double conver = i *1.17;
                display_txt.Text = "Итог:" + conver + "\t USD";
            }
            if (fromcombo1.SelectedItem.ToString() == "EUR" && tocombo2.SelectedItem.ToString() == "EUR")
            {
                double conver = i * 1;
                display_txt.Text = "Итог:" + conver + "\t EUR";
            }
            if (fromcombo1.SelectedItem.ToString() == "EUR" && tocombo2.SelectedItem.ToString() == "RUB")
            {
                double conver = i *77.31;
                display_txt.Text = "Итог:" + conver + "\t RUB";
            }
            if (fromcombo1.SelectedItem.ToString() == "EUR" && tocombo2.SelectedItem.ToString() == "BYN")
            {
                double conver = i *2.45;
                display_txt.Text = "Итог:" + conver + "\t BYN";
            }
            if (fromcombo1.SelectedItem.ToString() == "EUR" && tocombo2.SelectedItem.ToString() == "PLN")
            {
                double conver = i *4.30;
                display_txt.Text = "Итог:" + conver + "\t PLN";
            }
            if (fromcombo1.SelectedItem.ToString() == "EUR" && tocombo2.SelectedItem.ToString() == "UAX")
            {
                double conver = i *33.02;
                display_txt.Text = "Итог:" + conver + "\t UAX";
            }



            //RUB
            if (fromcombo1.SelectedItem.ToString() == "RUB" && tocombo2.SelectedItem.ToString() == "USD")
            {
                double conver = i *0.015;
                display_txt.Text = "Итог:" + conver + "\t USD";
            }
            if (fromcombo1.SelectedItem.ToString() == "RUB" && tocombo2.SelectedItem.ToString() == "RUB")
            {
                double conver = i * 0;
                display_txt.Text = "Итог:" + conver + "\t RUB";
            }
            if (fromcombo1.SelectedItem.ToString() == "RUB" && tocombo2.SelectedItem.ToString() == "EUR")
            {
                double conver = i *0.013;
                display_txt.Text = "Итог:" + conver + "\t EUR";
            }
            if (fromcombo1.SelectedItem.ToString() == "RUB" && tocombo2.SelectedItem.ToString() == "BYN")
            {
                double conver = i *0.032;
                display_txt.Text = "Итог:" + conver + "\t BYN";
            }
            if (fromcombo1.SelectedItem.ToString() == "RUB" && tocombo2.SelectedItem.ToString() == "PLN")
            {
                double conver = i *0.056;
                display_txt.Text = "Итог:" + conver + "\t PLN";
            }
            if (fromcombo1.SelectedItem.ToString() == "RUB" && tocombo2.SelectedItem.ToString() == "UAX")
            {
                double conver = i *0.43;
                display_txt.Text = "Итог:" + conver + "\t UAX";
            }

            //BYN
            if (fromcombo1.SelectedItem.ToString() == "BYN" && tocombo2.SelectedItem.ToString() == "USD")
            {
                double conver = i *0.48;
                display_txt.Text = "Итог:" + conver + "\t USD";
            }
            if (fromcombo1.SelectedItem.ToString() == "BYN" && tocombo2.SelectedItem.ToString() == "BYN")
            {
                double conver = i * 0.5;
                display_txt.Text = "Итог:" + conver + "\t BYN";
            }
            if (fromcombo1.SelectedItem.ToString() == "BYN" && tocombo2.SelectedItem.ToString() == "EUR")
            {
                double conver = i *0.41;
                display_txt.Text = "Итог:" + conver + "\t EUR";
            }
            if (fromcombo1.SelectedItem.ToString() == "BYN" && tocombo2.SelectedItem.ToString() == "RUB")
            {
                double conver = i *31.60;
                display_txt.Text = "Итог:" + conver + "\t RUB";
            }
            if (fromcombo1.SelectedItem.ToString() == "BYN" && tocombo2.SelectedItem.ToString() == "PLN")
            {
                double conver = i *1.76;
                display_txt.Text = "Итог:" + conver + "\t PLN";
            }
            if (fromcombo1.SelectedItem.ToString() == "BYN" && tocombo2.SelectedItem.ToString() == "UAX")
            {
                double conver = i *13.48;
                display_txt.Text = "Итог:" + conver + "\t UAX";
            }

            //PLN
            if (fromcombo1.SelectedItem.ToString() == "PLN" && tocombo2.SelectedItem.ToString() == "USD")
            {
                double conver = i *0.27;
                display_txt.Text = "Итог:" + conver + "\t USD";
            }
            if (fromcombo1.SelectedItem.ToString() == "PLN" && tocombo2.SelectedItem.ToString() == "PLN")
            {
                double conver = i * 1;
                display_txt.Text = "Итог:" + conver + "\t BYN";
            }
            if (fromcombo1.SelectedItem.ToString() == "PLN" && tocombo2.SelectedItem.ToString() == "EUR")
            {
                double conver = i *0.23;
                display_txt.Text = "Итог:" + conver + "\t EUR";
            }
            if (fromcombo1.SelectedItem.ToString() == "PLN" && tocombo2.SelectedItem.ToString() == "RUB")
            {
                double conver = i *17.29;
                display_txt.Text = "Итог:" + conver + "\t RUB";
            }
            if (fromcombo1.SelectedItem.ToString() == "PLN" && tocombo2.SelectedItem.ToString() == "BYN")
            {
                double conver = i *0.57;
                display_txt.Text = "Итог:" + conver + "\t BYN";
            }
            if (fromcombo1.SelectedItem.ToString() == "PLN" && tocombo2.SelectedItem.ToString() == "UAX")
            {
                double conver = i *7.67;
                display_txt.Text = "Итог:" + conver + "\t UAX";
            }


            //UAX
            if (fromcombo1.SelectedItem.ToString() == "UAX" && tocombo2.SelectedItem.ToString() == "USD")
            {
                double conver = i *0.036;
                display_txt.Text = "Итог:" + conver + "\t USD";
            }
            if (fromcombo1.SelectedItem.ToString() == "UAX" && tocombo2.SelectedItem.ToString() == "UAX")
            {
                double conver = i * 1;
                display_txt.Text = "Итог:" + conver;
            }
            if (fromcombo1.SelectedItem.ToString() == "UAX" && tocombo2.SelectedItem.ToString() == "EUR")
            {
                double conver = i *0.030;
                display_txt.Text = "Итог:" + conver + "\t EUR";
            }
            if (fromcombo1.SelectedItem.ToString() == "UAX" && tocombo2.SelectedItem.ToString() == "RUB")
            {
                double conver = i *2.34;
                display_txt.Text = "Итог:" + conver + "\t RUB";
            }
            if (fromcombo1.SelectedItem.ToString() == "UAX" && tocombo2.SelectedItem.ToString() == "BYN")
            {
                double conver = i *0.0074;
                display_txt.Text = "Итог:" + conver + "\t BYN";
            }
            if (fromcombo1.SelectedItem.ToString() == "UAX" && tocombo2.SelectedItem.ToString() == "PLN")
            {
                double conver = i *0.13;
                display_txt.Text = "Итог:" + conver + "\t PLN";
            }
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ОПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ");
        }

        private void RUBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 RUB= 0.032 BYN | 0.013 EUR | 0.015 USD | 0.056 PLN | 0.43 UAX");
        }

        private void BYNToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("1 UAX= 0.13 PLN | 0.0074 BLN | 0.036 USD | 0.030 EUR | 2.34 RUB");
        }

        private void EURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 EUR= 2.45 BLN | 77.31 RUB |  1.17 USD | 33.02 UAX | 4.30 PLN");
        }

        private void PLNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 PLN= 0.57 BYN | 0.27 USD | 0.23 EUR | 17.29 RUB | 7.67 UAX");
        }

        private void UAXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 BYN= 0.48 USD | 0.41 EUR | 1.76 PLN | 31.60 RUB | 13.48 UAX");
        }

        private void USDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 USD= 65.83 RUB | 2.08 BYN | 0.85 EUR | 3.66 PLN | 28.12 UAX");
        }

        private void курсВалютToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
           
        }
    }
}
