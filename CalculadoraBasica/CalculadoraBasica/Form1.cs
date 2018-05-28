using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmCalcBasica : Form
    {
        public frmCalcBasica()
        {
            InitializeComponent();
        }

        double num0, res;
        String sinal = "0";

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text.Equals("") || txbVisor.Text.Equals("0"))
            {
                txbVisor.Text = "1";
            }
            else
                txbVisor.Text = txbVisor.Text + "1";

            if (lblConta.Text.Equals("") || lblConta.Text.Equals("0"))
            {
                lblConta.Text = "1";
            }
            else
                lblConta.Text = lblConta.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text.Equals("") || txbVisor.Text.Equals("0"))
            {
                txbVisor.Text = "2";
            }
            else
                txbVisor.Text = txbVisor.Text + "2";

            if (lblConta.Text.Equals("") || lblConta.Text.Equals("0"))
            {
                lblConta.Text = "2";
            }
            else
                lblConta.Text = lblConta.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text.Equals("") || txbVisor.Text.Equals("0"))
            {
                txbVisor.Text = "3";
            }
            else
                txbVisor.Text = txbVisor.Text + "3";

            if (lblConta.Text.Equals("") || lblConta.Text.Equals("0"))
            {
                lblConta.Text = "3";
            }
            else
                lblConta.Text = lblConta.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text.Equals("") || txbVisor.Text.Equals("0"))
            {
                txbVisor.Text = "4";
            }
            else
                txbVisor.Text = txbVisor.Text + "4";

            if (lblConta.Text.Equals("") || lblConta.Text.Equals("0"))
            {
                lblConta.Text = "4";
            }
            else
                lblConta.Text = lblConta.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text.Equals("") || txbVisor.Text.Equals("0"))
            {
                txbVisor.Text = "5";
            }
            else
                txbVisor.Text = txbVisor.Text + "5";

            if (lblConta.Text.Equals("") || lblConta.Text.Equals("0"))
            {
                lblConta.Text = "5";
            }
            else
                lblConta.Text = lblConta.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text.Equals("") || txbVisor.Text.Equals("0"))
            {
                txbVisor.Text = "6";
            }
            else
                txbVisor.Text = txbVisor.Text + "6";

            if (lblConta.Text.Equals("") || lblConta.Text.Equals("0"))
            {
                lblConta.Text = "6";
            }
            else
                lblConta.Text = lblConta.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text.Equals("") || txbVisor.Text.Equals("0"))
            {
                txbVisor.Text = "7";
            }
            else
                txbVisor.Text = txbVisor.Text + "7";

            if (lblConta.Text.Equals("") || lblConta.Text.Equals("0"))
            {
                lblConta.Text = "7";
            }
            else
                lblConta.Text = lblConta.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text.Equals("") || txbVisor.Text.Equals("0"))
            {
                txbVisor.Text = "8";
            }
            else
                txbVisor.Text = txbVisor.Text + "8";

            if (lblConta.Text.Equals("") || lblConta.Text.Equals("0"))
            {
                lblConta.Text = "8";
            }
            else
                lblConta.Text = lblConta.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text.Equals("") || txbVisor.Text.Equals("0"))
            {
                txbVisor.Text = "9";
            }
            else
                txbVisor.Text = txbVisor.Text + "9";

            if (lblConta.Text.Equals("") || lblConta.Text.Equals("0"))
            {
                lblConta.Text = "9";
            }
            else
                lblConta.Text = lblConta.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text.Equals("") || txbVisor.Text.Equals("0"))
            {
                txbVisor.Text = "0";
            }
            else
                txbVisor.Text = txbVisor.Text + "0";

            if (lblConta.Text.Equals("") || lblConta.Text.Equals("0"))
            {
                lblConta.Text = "0";
            }
            else
                lblConta.Text = lblConta.Text + "0";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            num0 = System.Convert.ToDouble(txbVisor.Text);
            lblConta.Text = lblConta.Text + "+";
            res = res + num0;
            sinal = "adição";
            txbVisor.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            num1 = System.Convert.ToDouble(txbVisor.Text);
            lblConta.Text = lblConta.Text + "-";
            txbVisor.Text = "";

            if (sinal == "adição" || sinal == "subtração" || sinal == "multiplicação" || sinal == "divisão")
            {
                res = res - num0;
                sinal = "divisão";
            }
            else
                res = num0;
                sinal = "subtração";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            num2 = System.Convert.ToDouble(txbVisor.Text);
            lblConta.Text = lblConta.Text + "*";
            txbVisor.Text = "";

            if (sinal == "multiplicação" || sinal == "adição" || sinal == "subtração" || sinal == "divisão")
            {
                res = res * num0;
                sinal = "divisão";
            }
            else
                res = num0;
                sinal = "multiplicação";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            num3 = System.Convert.ToDouble(txbVisor.Text);
            lblConta.Text = lblConta.Text + "/";
            txbVisor.Text = "";

            if (sinal == "divisão" || sinal == "adição" || sinal == "subtração" || sinal == "multiplicação")
            {
                res = res / num0;
                sinal = "divisão";
            }
            else
                res = num0;
                sinal = "divisão";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (sinal == "adição")
            {
                num0 = System.Convert.ToDouble(txbVisor.Text);
                res = res + num0;
                lblResultado.Text = "Result " + res.ToString();
            }

            else if (sinal == "subtração")
            {
                num0 = System.Convert.ToDouble(txbVisor.Text);
                res = res - num0;
                lblResultado.Text = "Result " + res.ToString();
            }

            else if (sinal == "multiplicação")
            {
                num0 = System.Convert.ToDouble(txbVisor.Text);
                res = res * num0;
                lblResultado.Text = "Result " + res.ToString();
            }

            else if (sinal == "divisão")
            {
                num0 = System.Convert.ToDouble(txbVisor.Text);
                res = res / num0;
                lblResultado.Text = "Result " + res.ToString();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            num0 = 0;
            res = 0;
            sinal = null;
            lblConta.Text = "";
            txbVisor.Text = "";
            lblResultado.Text = "Result";
        }
    }
}
