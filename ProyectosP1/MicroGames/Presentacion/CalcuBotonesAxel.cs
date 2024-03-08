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

        //funcion para agregar el signo de resta a la textPant
        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textPant.Text);
            btnPunto.Enabled = true;
            textPant.Text = "0";
        }

        // funcion para borrar un caracter que se encuntre en la textPant
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

        //funcion para agregar el signo de multiplicar a la textPant
        private void btnMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textPant.Text);
            btnPunto.Enabled = true;
            textPant.Text = "0";
        }

        //funcion para agregar el signo de division a la textPant
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

        //funcion para agregar el signo de suma a la textPant
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(textPant.Text);
            btnPunto.Enabled = true;
            textPant.Text = "0";
        }

        //funcion para dejar todo en 0 en la textPant
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Se deja la textPant en 0
            textPant.Text = "0";
            //Se restablecen los valores de las variables
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        //Funcion para realizar las operaciones 
        private void button12_Click(object sender, EventArgs e)
        {

            num2 = Convert.ToDouble(textPant.Text);

            switch (operador)
            {
                case "+":
                    //se realiza la operacion de suma 
                    //Se pone los valores dentro del string
                    textPant.Text = $"{num1 + num2}";
                    break;
                case "-":
                    //se realiza la operacion de resta 
                    //Se pone los valores dentro del string
                    textPant.Text = $"{num1 - num2}";
                    break;
                case "*":
                    //se realiza la operacion de multiplicacion 
                    //Se pone los valores dentro del string
                    textPant.Text = $"{num1 * num2}";
                    break;
                case "/":
                    //se realiza la operacion de divicion 
                    //Se pone los valores dentro del string
                    textPant.Text = $"{num1 / num2}";
                    break;
            }
        }

        //funcion para agregar un punto a la textPant
        private void btnPunto_Click(object sender, EventArgs e)
        {
            //se agrega un punto a la textPant
            textPant.Text = textPant.Text + ".";
            //se desabilita el boton para agregar un putno en la textPant
            btnPunto.Enabled = false;
        }

        //funcion para agregar un 0
        private void btn0_Click(object sender, EventArgs e)
        {
            //se agrega un 0 a la textPant
            textPant.Text = textPant.Text + "0";
        }

        //funcion del boton 3 
        private void btn3_Click(object sender, EventArgs e)
        {
            // si la textPant se encuentra un 0 se ejecuta
            if (textPant.Text == "0")
            {
                //se remplaza el 0 de la textPant por el 3
                textPant.Text = "3";
            }
            //en otro caso se suma un 3 a la textPant
            else
            {
                //se agrega un 3 a la textPant
                textPant.Text = textPant.Text + "3";
            }
        }

        //funcion del boton 2
        private void btn2_Click(object sender, EventArgs e)
        {
            // si la textPant se encuentra un 0 se ejecuta
            if (textPant.Text == "0")
            {
                //se remplaza el 0 de la textPant por el 2
                textPant.Text = "2";
            }
            //en otro caso se suma un 2 a la textPant
            else
            {
                //se agrega un 2 a la textPant
                textPant.Text = textPant.Text + "2";
            }
        }

        //funcion del boton 1
        private void btn1_Click(object sender, EventArgs e)
        {
            // si la textPant se encuentra un 0 se ejecuta
            if (textPant.Text == "0")
            {
                //se remplaza el 0 de la textPant por el 1
                textPant.Text = "1";
            }
            //en otro caso se suma un 1 a la textPant
            else
            {
                //se agrega un 1 a la textPant
                textPant.Text = textPant.Text + "1";
            }
        }

        //funcion del boton 6
        private void btn6_Click(object sender, EventArgs e)
        {
            // si la textPant se encuentra un 0 se ejecuta
            if (textPant.Text == "0")
            {
                //se remplaza el 0 de la textPant por el 6
                textPant.Text = "6";
            }
            //en otro caso se suma un 6 a la textPant
            else
            {
                //se agrega un 6 a la textPant
                textPant.Text = textPant.Text + "6";
            }
        }

        //funcion del boton 5
        private void btn5_Click(object sender, EventArgs e)
        {
            // si la textPant se encuentra un 0 se ejecuta
            if (textPant.Text == "0")
            {
                //se remplaza el 0 de la textPant por el 5
                textPant.Text = "5";
            }
            //en otro caso se suma un 5 a la textPant
            else
            {
                //se agrega un 5 a la textPant
                textPant.Text = textPant.Text + "5";
            }
        }

        //funcion del boton 4
        private void btn4_Click(object sender, EventArgs e)
        {
            // si la textPant se encuentra un 0 se ejecuta
            if (textPant.Text == "0")
            {
                //se remplaza el 0 de la textPant por el 4
                textPant.Text = "4";
            }
            //en otro caso se suma un 4 a la textPant
            else
            {
                //se agrega un 4 a la textPant
                textPant.Text = textPant.Text + "4";
            }
        }

        //funcion del boton 9
        private void btn9_Click(object sender, EventArgs e)
        {
            // si la textPant se encuentra un 0 se ejecuta
            if (textPant.Text == "0")
            {
                //se remplaza el 0 de la textPant por el 9
                textPant.Text = "9";
            }
            //en otro caso se suma un 9 a la textPant
            else
            {
                //se agrega un 9 a la textPant
                textPant.Text = textPant.Text + "9";
            }
        }

        //funcion del boton 8
        private void btn8_Click(object sender, EventArgs e)
        {
            // si la textPant se encuentra un 0 se ejecuta
            if (textPant.Text == "0")
            {
                //se remplaza el 0 de la textPant por el 8
                textPant.Text = "8";
            }
            //en otro caso se suma un 8 a la textPant
            else
            {
                //se agrega un 8 a la textPant
                textPant.Text = textPant.Text + "8";
            }
        }

        //funcion del boton 7
        private void btn7_Click(object sender, EventArgs e)
        {
            // si la textPant se encuentra un 0 se ejecuta
            if (textPant.Text == "0")
            {
                // se remplaza el 0 de la textPant por el 7
                textPant.Text = "7";
            }
            //en otro caso se suma un 7 a la textPant
            else
            {
                //se agrega un 7 a la textPant
                textPant.Text = textPant.Text + "7";
            }
        }

        private void textPant_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcuBotonesAxel_Load(object sender, EventArgs e)
        {

        }
    }
}
