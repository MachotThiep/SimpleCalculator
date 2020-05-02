using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    /* Machot Thiep 
     * May 1, 2020
     * Exercise 6-1*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Operand1 = Convert.ToDecimal(txtOperand1.Text);
            decimal Operand2 = Convert.ToDecimal(txtOperand2.Text);
            Calculate(Operand1, txtOperator.Text, Operand2);
        }

        private void Calculate(decimal v1, string v2, decimal v3)
        {
            //I am not sure why the rounding doesn't working but everything is working
            decimal Result;
            if (v2.Equals("+"))
            {
                Result = v1 + v3;
               Decimal.Round(Result,4);
                txtResult.Text = Convert.ToDecimal(Result).ToString();
            }
            else if (v2.Equals("-"))
            {
                Result = v1 - v3;
                Decimal.Round(Result,4);
                txtResult.Text = Convert.ToDecimal(Result).ToString();
            }
            else if (v2.Equals("*"))
            {
                Result = v1 * v3;
                Decimal.Round(Result,4);
                txtResult.Text = Convert.ToDecimal(Result).ToString();
            }
            else if (v2.Equals("/"))
            {
                Result = v1 / v3;
                Decimal.Round(Result,4);
                txtResult.Text = Convert.ToDecimal(Result).ToString();

            }
        }
    }
}
