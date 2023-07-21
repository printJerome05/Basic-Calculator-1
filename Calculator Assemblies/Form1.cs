using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Assemblies
{
    public partial class Form1 : Form
    {
        double num1, num2, total;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            if (cbOperator.SelectedItem.Equals("+"))
            {
                total = num1 + num2;
                lbnDisplayTotal.Text = total.ToString();

            }
            else
                if (cbOperator.SelectedItem.Equals("-"))
            {
                total = num1 - num2;
                lbnDisplayTotal.Text = total.ToString();
            }
            else
                if (cbOperator.SelectedItem.Equals("*"))
            {
                total = num1 * num2;
                lbnDisplayTotal.Text = total.ToString();
            }
            else
                if (cbOperator.SelectedItem.Equals("/"))
            {
                total = num1 / num2;
                lbnDisplayTotal.Text = total.ToString();
            }
        }
    }
}
