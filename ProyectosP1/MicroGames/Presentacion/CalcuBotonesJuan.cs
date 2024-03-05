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
    public partial class CalcuBotonesJuan : Form
    {
        public CalcuBotonesJuan()
        {
            InitializeComponent();
        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void operacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();
        }

        private void valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void resoculto_TextChanged(object sender, EventArgs e)
        {

        }

        private void delfin_Click(object sender, EventArgs e)
        {
            if (pantalla.TextLength == 1 && valor.TextLength == 1)
            {
                pantalla.Text = "0";
                valor.Text = "0";
                punto.Enabled = true;
            }
            else
            {
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
                valor.Text = valor.Text.Substring(0, valor.Text.Length - 1);
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            operacion.Text = "/  Div   ";
            if (resoculto.Text == "0")
            {
                resoculto.Text = pantalla.Text;
                valor.Text = "0";
                pantalla.Text = "0";
                punto.Enabled = true;
            }
            else
            {
                valor.Text = pantalla.Text;
                pantalla.Text = "0";
                punto.Enabled = true;
            }
        }

        private void Dellete_Click(object sender, EventArgs e)
        {
            pantalla.Text = "0";
            resoculto.Text = "0";
            punto.Enabled = true;
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(resoculto.Text, out double d2) && double.TryParse(valor.Text, out double d1))
            {
                double res = 0;
                char op = operacion.Text[0];
                switch (op)
                {
                    case '+':
                        res = d2 + d1;
                        break;
                    case '-':
                        res = d2 - d1;
                        break;
                    case '*':
                        res = d2 * d1;
                        break;
                    case '/':
                        if (d2 == 0 || d1 == 0)
                        {
                            MessageBox.Show("No tienes permitido continuar con tus calculos por atentar contra el orden natural de las cosas. Por favor cierre la aplicacion");
                            punto.Enabled = false;
                            sum.Enabled = false;
                            rest.Enabled = false;
                            mult.Enabled = false;
                            div.Enabled = false;
                            num0.Enabled = false;
                            num1.Enabled = false;
                            num2.Enabled = false;
                            num3.Enabled = false;
                            num4.Enabled = false;
                            num5.Enabled = false;
                            num6.Enabled = false;
                            num7.Enabled = false;
                            num8.Enabled = false;
                            num9.Enabled = false;
                            Dellete.Enabled = false;
                            delfin.Enabled = false;
                            calcular.Enabled = false;
                        }
                        else
                        {
                            res = d2 / d1;
                        }

                        break;
                    default:
                        MessageBox.Show("Ingrese una operacion valida");
                        break;
                }
                pantalla.Text = res.ToString();
                resoculto.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese valores permitidos en dato 1 y dato 2");
            }
        }

        private void punto_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                pantalla.Text = "0.";
                valor.Text = "0.";
            }
            else
            {
                pantalla.Text = pantalla.Text + ".";
                valor.Text = valor.Text + ".";
            }
            punto.Enabled = false;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            operacion.Text = "*  Mul  ";
            if (resoculto.Text == "0")
            {
                resoculto.Text = pantalla.Text;
                valor.Text = "0";
                pantalla.Text = "0";
                punto.Enabled = true;
            }
            else
            {
                valor.Text = pantalla.Text;
                pantalla.Text = "0";
                punto.Enabled = true;
            }
        }

        private void rest_Click(object sender, EventArgs e)
        {
            operacion.Text = "-  Res   ";

            if (resoculto.Text == "0")
            {
                resoculto.Text = pantalla.Text;
                valor.Text = "0";
                pantalla.Text = "0";
                punto.Enabled = true;
            }
            else
            {
                valor.Text = pantalla.Text;
                pantalla.Text = "0";
                punto.Enabled = true;
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            operacion.Text = "+  Sum  ";
            if (resoculto.Text == "0")
            {
                resoculto.Text = pantalla.Text;
                valor.Text = "0";
                pantalla.Text = "0";
                punto.Enabled = true;
            }
            else
            {
                valor.Text = pantalla.Text;
                pantalla.Text = "0";
                punto.Enabled = true;
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                pantalla.Text = "0";
                valor.Text = "0";
            }
            else
            {
                pantalla.Text = pantalla.Text + "0";
                valor.Text = valor.Text + "0";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                pantalla.Text = "9";
                valor.Text = "9";
            }
            else
            {
                pantalla.Text = pantalla.Text + "9";
                valor.Text = valor.Text + "9";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                pantalla.Text = "8";
                valor.Text = "8";
            }
            else
            {
                pantalla.Text = pantalla.Text + "8";
                valor.Text = valor.Text + "8";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                pantalla.Text = "7";
                valor.Text = "7";
            }
            else
            {
                pantalla.Text = pantalla.Text + "7";
                valor.Text = valor.Text + "7";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                pantalla.Text = "6";
                valor.Text = "6";
            }
            else
            {
                pantalla.Text = pantalla.Text + "6";
                valor.Text = valor.Text + "6";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                pantalla.Text = "5";
                valor.Text = "5";
            }
            else
            {
                pantalla.Text = pantalla.Text + "5";
                valor.Text = valor.Text + "5";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                pantalla.Text = "4";
                valor.Text = "4";
            }
            else
            {
                pantalla.Text = pantalla.Text + "4";
                valor.Text = valor.Text + "4";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                pantalla.Text = "3";
                valor.Text = "3";
            }
            else
            {
                pantalla.Text = pantalla.Text + "3";
                valor.Text = valor.Text + "3";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                pantalla.Text = "2";
                valor.Text = "2";
            }
            else
            {
                pantalla.Text = pantalla.Text + "2";
                valor.Text = valor.Text + "2";
            }
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                pantalla.Text = "1";
                valor.Text = "1";
            }
            else
            {
                pantalla.Text = pantalla.Text + "1";
                valor.Text = valor.Text + "1";
            }
        }
    }
}
