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
    public partial class Calculadora1Juan : Form
    {
        public Calculadora1Juan()
        {
            InitializeComponent();
        }

        private void dato2_TextChanged(object sender, EventArgs e)
        {

        }

        private void operacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res = 0;
            if (double.TryParse(dato1.Text, out double d1) && double.TryParse(dato2.Text, out double d2))
            {
                char op = operacion.Text[0];
                switch (op)
                {
                    case '+':
                        res = d1 + d2;
                        break;
                    case '-':
                        res = d1 - d2;
                        break;
                    case '*':
                        res = d1 * d2;
                        break;
                    case '/':
                        res = d1 / d2;
                        break;
                    default:
                        MessageBox.Show("Ingrese una operacion valida");
                        break;
                }
                resultado.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese valores permitidos en dato 1 y dato 2");
            }
        }

        private void dato20_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dato1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
