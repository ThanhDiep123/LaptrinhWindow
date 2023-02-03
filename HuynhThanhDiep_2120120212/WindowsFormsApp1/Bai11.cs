using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bai11 : Form
    {
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";
        public Bai11()
        {
            InitializeComponent();
        }

        

        private void Bai11_Load(object sender, EventArgs e)
        {

        }

        private void btMC_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if ((char.IsDigit(bt.Text, 0) & Text.Length == 1) || bt.Text == ".")
            {
                txtDisplay.Text += bt.Text;
            }
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();

            }
            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(txtDisplay.Text);
                switch (opr)
                {
                    case "+":
                        {
                            txtDisplay.Text = (workingMemory + secondValue).ToString();
                            break;
                        }
                    case "-":
                        {
                            txtDisplay.Text = (workingMemory - secondValue).ToString();
                            break;
                        }
                    case "*":
                        {
                            txtDisplay.Text = (workingMemory * secondValue).ToString();
                            break;
                        }
                    case "/":
                        {
                            txtDisplay.Text = (workingMemory / secondValue).ToString();
                            break;
                        }

                }

            }
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = -currVal;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = (decimal)Math.Sqrt((double)currVal);
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = currVal / 100;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = 1 / currVal;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "←")
            {
                if (txtDisplay.TextLength != 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
                }
            }
            else if (bt.Text == "MC")
            {
                memory = 0;
            }
            else if (bt.Text == "MR")
            {
                txtDisplay.Text = memory.ToString();
            }
            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (bt.Text == "M+")
            {
                memory = memory + decimal.Parse(txtDisplay.Text);
            }
            else if (bt.Text == "M-")
            {
                memory = memory - decimal.Parse(txtDisplay.Text);
            }
            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Clear();
            }
            else if (bt.Text == "CE")
            {
                txtDisplay.Clear();
            }


        }

        private void btMS_Click(object sender, EventArgs e)
        {
            
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt1.Text;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt0.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt3.Text;
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            opr = btCong.Text;
            workingMemory = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btBang_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(txtDisplay.Text);
            if (opr == "+")
                txtDisplay.Text = (workingMemory + secondValue).ToString();
            if (opr == "*")
                txtDisplay.Text = (workingMemory * secondValue).ToString();
            if (opr == "-")
                txtDisplay.Text = (workingMemory * secondValue).ToString();
            if (opr == "/")
                txtDisplay.Text = (workingMemory * secondValue).ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            opr = btTru.Text;
            workingMemory = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        

       

        private void BtCongtru_Click(object sender, EventArgs e)
        {
            opr = BtCongtru.Text;
            workingMemory = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btcang_Click(object sender, EventArgs e)
        {
            opr = btcang.Text;
            workingMemory = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btPhantram_Click(object sender, EventArgs e)
        {
            opr = btPhantram.Text;
            workingMemory = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void bt1chiax_Click(object sender, EventArgs e)
        {
            opr = bt1chiax.Text;
            workingMemory = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            opr = btNhan.Text;
            workingMemory = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            opr = btChia.Text;
            workingMemory = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt4.Text;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt5.Text;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt6.Text;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt7.Text;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt8.Text;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt9.Text;
        }
    }
}
