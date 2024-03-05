using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroGames.Presentacion
{
    public partial class CalcuBotonesAxel : Form
    {
        public CalcuBotonesAxel()
        {
            InitializeComponent();
        }
        //Variables
        string operador;
        double num1 = 0;
        double num2 = 0;

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textPant.Text);
            btnPunto.Enabled = true;
            textPant.Text = "0";
        }

        private void btnBor_Click(object sender, EventArgs e)
        {
            if (textPant.TextLength == 1)
            {
                textPant.Text = "0";
            }
            else
            {
                textPant.Text = textPant.Text.Substring(0, textPant.Text.Length - 1);
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textPant.Text);
            btnPunto.Enabled = true;
            textPant.Text = "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textPant.Text);
            btnPunto.Enabled = true;
            textPant.Text = "0";
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(textPant.Text);
            btnPunto.Enabled = true;
            textPant.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textPant.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textPant.Text);
            switch (operador)
            {
                case "+":
                    textPant.Text = $"{num1 + num2}";
                    break;
                case "-":
                    textPant.Text = $"{num1 - num2}";
                    break;
                case "*":
                    textPant.Text = $"{num1 * num2}";
                    break;
                case "/":
                    textPant.Text = $"{num1 / num2}";
                    break;
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textPant.Text = textPant.Text + ".";
            btnPunto.Enabled = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textPant.Text = textPant.Text + "0";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textPant.Text == "0")
            {
                textPant.Text = "3";
            }
            else
            {
                textPant.Text = textPant.Text + "3";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textPant.Text == "0")
            {
                textPant.Text = "2";
            }
            else
            {
                textPant.Text = textPant.Text + "2";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textPant.Text == "0")
            {
                textPant.Text = "1";
            }
            else
            {
                textPant.Text = textPant.Text + "1";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textPant.Text == "0")
            {
                textPant.Text = "6";
            }
            else
            {
                textPant.Text = textPant.Text + "6";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textPant.Text == "0")
            {
                textPant.Text = "5";
            }
            else
            {
                textPant.Text = textPant.Text + "5";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textPant.Text == "0")
            {
                textPant.Text = "4";
            }
            else
            {
                textPant.Text = textPant.Text + "4";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textPant.Text == "0")
            {
                textPant.Text = "9";
            }
            else
            {
                textPant.Text = textPant.Text + "9";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textPant.Text == "0")
            {
                textPant.Text = "8";
            }
            else
            {
                textPant.Text = textPant.Text + "8";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textPant.Text == "0")
            {
                textPant.Text = "7";
            }
            else
            {
                textPant.Text = textPant.Text + "7";
            }
        }

        private void textPant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
