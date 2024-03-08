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
    public partial class Calculadora1Axel : Form
    {
        public Calculadora1Axel()
        {
            InitializeComponent();
        }

        //se define una variable 

        double resultado = 0;

        private void Home_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();
        }

        // Funcion para calcular el resultado de la operacion
        private void button1_Click(object sender, EventArgs e)
        {
            // Condicion 
            if (double.TryParse(Numero_1.Text, out double n1) && double.TryParse(Numero_2.Text, out double n2))
            {
                char op = operacion.Text[0];
                switch (op)
                {

                    case '+':
                        //suma los valores
                        resultado = n1 + n2;
                        break;
                    case '-':
                        //resta los valores
                        resultado = n1 - n2;
                        break;
                    case '*':
                        //multiplica los valores
                        resultado = n1 * n2;
                        break;
                    case '/':
                        //divide los valores 
                        resultado = n1 / n2;
                        break;
                }
                // Mostrar el resultado en el TextBox correspondiente
                Resultado.Text = resultado.ToString();

            }
            //se pide que ingrese un valor valido
            else
            {
                MessageBox.Show("Ingrese números válidos en los TextBox.");
            }
        }

        private void operacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numero_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numero_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
