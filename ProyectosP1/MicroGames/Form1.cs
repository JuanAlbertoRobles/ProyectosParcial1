using MicroGames.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MicroGames.Datos.Conector;

namespace MicroGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void GatoExe_Click(object sender, EventArgs e)
        {
            //El boton para abrir el gato
            Form formulario = new Gato();
            formulario.Show();
            this.Hide();
        }

        private void AhorcadoExe_Click(object sender, EventArgs e)
        {
            //El boton para abrir el ahorcado
            Form formulario = new Ahorcado();
            formulario.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //Boton para salir
            this.Close();
        }

        private void CalculadoraBotonesAX_Click(object sender, EventArgs e)
        {
            //El boton para abrir la calculadora con botones de axel
            Form formulario = new CalcuBotonesAxel();
            formulario.Show();
            this.Hide();
        }

        private void CalculadoraJ_Click(object sender, EventArgs e)
        {
            //El boton para abrir la calculadora de Juan
            Form formulario = new Calculadora1Juan();
            formulario.Show();
            this.Hide();
        }

        private void CalculadoraAX_Click(object sender, EventArgs e)
        {
            //El boton para abrir la calculadora de axel
            Form formulario = new Calculadora1Axel();
            formulario.Show();
            this.Hide();
        }

        private void CalculadoraBotonesJ_Click(object sender, EventArgs e)
        {
            //El boton para abrir la calculadora con botones de Juan
            Form formulario = new CalcuBotonesJuan();
            formulario.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
