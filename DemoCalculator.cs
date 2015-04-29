using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoCalculatorLib
{
    public partial class DemoCalculator : Form
    {
        public DemoCalculator()
        {
            InitializeComponent();
        }
        string text="0";
        double op1=0, op2=0, sol=0;
        string optr;
        private void Value_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            text += b.Text;
            while (text != "0" && text[0] == '0' && text[1] != '.')
                text = text.Substring(1);
            txtDisplay.Text = text;
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                if (optr != "=")
                {
                    op2 = double.Parse(txtDisplay.Text);
                    switch (optr)
                    {
                        case "+": sol = op1 + op2; break;
                        case "-": sol = op1 - op2; break;
                        case "*": sol = op1 * op2; break;
                        case "/": sol = op1 / op2; break;
                        case "x^y": sol = Math.Pow(op1, op2); break;
                        case "nPr": if (op1 >= op2) sol = fact(op1) / fact(op1 - op2);break;
                        case "nCr": if (op1 >= op2) sol = fact(op1) / (fact(op1 - op2) * fact(op2));break;
                    }
                    optr = "=";
                    if (decimalButton.Enabled == false)
                        sol = Math.Floor(sol);                        
                    txtDisplay.Text = sol.ToString();
                }
                op1 = double.Parse(txtDisplay.Text);
                Button b = (Button)sender;
                optr = b.Text;
                text = "0";
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            text = "0";
            txtDisplay.Clear();
            op1 = op2 = sol = 0;
            optr = "=";
        }
        private void SingleOp_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                Button b = (Button)sender;
                if (b.Text == "x²")
                {
                    txtDisplay.Text = (Math.Pow(double.Parse(txtDisplay.Text), 2.0)).ToString();
                }
                if (b.Text == "x³")
                {
                    txtDisplay.Text = (Math.Pow(double.Parse(txtDisplay.Text), 3.0)).ToString();
                }
                if (b.Text == "x½")
                {
                    txtDisplay.Text = (Math.Pow(double.Parse(txtDisplay.Text), 0.5)).ToString();
                }
                if (b.Text == "x^1/3")
                {
                    txtDisplay.Text = (Math.Pow(double.Parse(txtDisplay.Text), 0.3333)).ToString();
                }
                if (b.Text == "n!" && double.Parse(txtDisplay.Text) % 1 == 0)
                {
                    txtDisplay.Text = (fact(double.Parse(txtDisplay.Text))).ToString();
                }
                if (b.Text == "N")
                {
                    txtDisplay.Text = (-double.Parse(txtDisplay.Text)).ToString();
                }
                if (b.Text == "Sin")
                {
                    txtDisplay.Text = (Math.Sin(double.Parse(txtDisplay.Text))).ToString();
                }
                if (b.Text == "iSin")
                {
                    txtDisplay.Text = (Math.Asin(double.Parse(txtDisplay.Text))).ToString();
                }
                if (b.Text == "iCos")
                {
                    txtDisplay.Text = (Math.Acos(double.Parse(txtDisplay.Text))).ToString();
                }
                if (b.Text == "Cos")
                {

                    txtDisplay.Text = (Math.Cos(double.Parse(txtDisplay.Text))).ToString();
                }
                if (b.Text == "Tan")
                {
                    txtDisplay.Text = (Math.Tan(double.Parse(txtDisplay.Text))).ToString();
                }
                if (b.Text == "iTan")
                {
                    txtDisplay.Text = (Math.Atan(double.Parse(txtDisplay.Text))).ToString();
                }
                if (b.Text == "1/x")
                {
                    txtDisplay.Text = (1 / double.Parse(txtDisplay.Text)).ToString();
                }
                if (b.Text == "Ln x")
                {
                    txtDisplay.Text = Math.Log(double.Parse(txtDisplay.Text)).ToString();

                }
                if (b.Text == "Log x")
                    {
                        txtDisplay.Text = Math.Log10(double.Parse(txtDisplay.Text)).ToString();

                    }
                }
            }
        double fact(double n)
        {
            if (n == 1 || n==0)
                return 1;
            else
                return n * fact(n - 1);
        }
        private void BaseChange_Click(object sender, EventArgs e)
        {
            int basetennumb = int.Parse(txtDisplay.Text);
            if (txtDisplay.Text != "" && !txtDisplay.Text.Contains('.'))
            {
                Button b = (Button)sender;
                if (b.Text == "Hex")
                {
                    txtDisplay.Text = Convert.ToString(basetennumb, 16);

                }
                if (b.Text == "Oct")
                {
                    txtDisplay.Text = Convert.ToString(basetennumb, 8);
                }
                if (b.Text == "Bool")
                {
                    txtDisplay.Text = Convert.ToString(basetennumb, 2);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Enabled = true;
            buttonOct.Enabled = false;
            buttonHex.Enabled = false;
            buttonBoolean.Enabled = false;
            sinebutton.Enabled = true;
            cosinebutton.Enabled = true;
            tangentbutton.Enabled = true;
            buttoncombination.Enabled = true;
            buttonPermutation.Enabled = true;
            buttoninverse.Enabled = true;
            factorial.Enabled = true;
            buttoniCos.Enabled = true;
            buttonisin.Enabled = true;
            buttoniTan.Enabled = true;
            buttonln.Enabled = true;
            buttonlog.Enabled =true;
            buttonpower.Enabled = true;
            buttonSquare.Enabled = true;
            buttonroot.Enabled = true;
            buttoncube.Enabled = true;
            buttoncuberoot.Enabled = true;
            decimalButton.Enabled = true;
            txtMode.Text = "Scientific";
        }
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Enabled = false;
            decimalButton.Enabled = true;
            txtMode.Text = "Standard";
        }

        private void programmerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel2.Enabled = true;
            buttonHex.Enabled = true;
            buttonBoolean.Enabled = true;
            buttonOct.Enabled = true;
            sinebutton.Enabled = false;
            cosinebutton.Enabled = false;
            tangentbutton.Enabled = false;
            buttoncombination.Enabled = false;
            buttonPermutation.Enabled = false;
            buttoninverse.Enabled = false;
            factorial.Enabled = false;
            buttoniCos.Enabled = false;
            buttonisin.Enabled = false;
            buttoniTan.Enabled = false;
            buttonln.Enabled = false;
            buttonlog.Enabled = false;
            buttonpower.Enabled = false;
            buttonSquare.Enabled = false;
            buttonroot.Enabled = false;
            buttoncube.Enabled = false;
            buttoncuberoot.Enabled = false;
            decimalButton.Enabled = false;
            txtMode.Text = "Programmer";
        }

        private void versiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0(Build 21)\nCopyright : Elvis Limited \nAll Rights Reserved", "About Calculator");
        }

        private void DemoCalculator_Load(object sender, EventArgs e)
        {
            text = "0";
            op1 = 0; op2 = 0; sol = 0;
            optr = "=";
        }

      
    }
}
