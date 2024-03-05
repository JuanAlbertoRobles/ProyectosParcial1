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

namespace MicroGames.Presentacion
{
    public partial class Ahorcado : Form
    {
        public Ahorcado()
        {
            InitializeComponent();

        }
        double resBien = 0;
        double puntaje = 0;
        double GameOver = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (Res.TextLength == 1 && Res.TextLength == 1)
            {
                Res.Text = "0";
            }
            else
            {
                Res.Text = Res.Text.Substring(0, Res.Text.Length - 1);
            }
        }

        private void Error_TextChanged(object sender, EventArgs e)
        {

        }

        private void Botcero_Click(object sender, EventArgs e)
        {
            if (Res.Text == "0")
            {
                Res.Text = "0";
            }
            else
            {
                Res.Text = Res.Text + "0";
            }
        }

        private void BotNueve_Click(object sender, EventArgs e)
        {
            if (Res.Text == "0")
            {
                Res.Text = "9";
            }
            else
            {
                Res.Text = Res.Text + "9";
            }
        }

        private void BotOcho_Click(object sender, EventArgs e)
        {
            if (Res.Text == "0")
            {
                Res.Text = "8";
            }
            else
            {
                Res.Text = Res.Text + "8";
            }
        }

        private void BotSiete_Click(object sender, EventArgs e)
        {
            if (Res.Text == "0")
            {
                Res.Text = "7";
            }
            else
            {
                Res.Text = Res.Text + "7";
            }
        }

        private void BotSeis_Click(object sender, EventArgs e)
        {
            if (Res.Text == "0")
            {
                Res.Text = "6";
            }
            else
            {
                Res.Text = Res.Text + "6";
            }
        }

        private void BotCin_Click(object sender, EventArgs e)
        {
            if (Res.Text == "0")
            {
                Res.Text = "5";
            }
            else
            {
                Res.Text = Res.Text + "5";
            }
        }

        private void BotCua_Click(object sender, EventArgs e)
        {
            if (Res.Text == "0")
            {
                Res.Text = "4";
            }
            else
            {
                Res.Text = Res.Text + "4";
            }
        }

        private void BotTres_Click(object sender, EventArgs e)
        {
            if (Res.Text == "0")
            {
                Res.Text = "3";
            }
            else
            {
                Res.Text = Res.Text + "3";
            }
        }

        private void BotDos_Click(object sender, EventArgs e)
        {
            if (Res.Text == "0")
            {
                Res.Text = "2";
            }
            else
            {
                Res.Text = Res.Text + "2";
            }
        }

        private void BotUno_Click(object sender, EventArgs e)
        {
            if (Res.Text == "0")
            {
                Res.Text = "1";
            }
            else
            {
                Res.Text = Res.Text + "1";
            }
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            StartGame.Visible = false;
            StartGame.Enabled = false;
            Random random = new Random();
            double num1 = random.Next(1, 11);
            double num2 = random.Next(1, 11);
            Dat1.Text = num1.ToString();
            Dat2.Text = num2.ToString();
            resBien = num1 * num2;
            Res.Text = "0";
            if (ModoNoche.Selection == 1)
            {
                
            }
            else if (ModoNoche.Selection == 2)
            {
                BackgroundImage = Properties.Resources.Fondo;
            }
            //Res.Text = resBien.ToString();
            if (GameOver == 6)
            {
                Form formulario = new Form1();
                formulario.Show();
                Close();
            }

        }

        private void Puntaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void Punp1_Click(object sender, EventArgs e)
        {

        }

        private void Probar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Res.Text, out double resPlayer))
            {
                if (resPlayer == resBien)
                {
                    MessageBox.Show("Gano");
                    puntaje = puntaje + 1;
                    Puntaje.Text = puntaje.ToString();
                    StartGame.Visible = true;
                    StartGame.Enabled = true;
                    StartGame.Text = "Continuar";
                    StartGame.Width = 150;

                }
                else
                {
                    MessageBox.Show("Perdio");
                    StartGame.Visible = true;
                    StartGame.Enabled = true;
                    StartGame.Text = "Continuar";
                    StartGame.Width = 150;
                    GameOver = GameOver + 1;
                    Error.Text = GameOver.ToString();
                    if (GameOver == 1)
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.Axel1;
                        StartGame.Width = 150;
                    }
                    else if (GameOver == 2)
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.Axel2;
                    }
                    else if (GameOver == 3)
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.Axel3;
                    }
                    else if (GameOver == 4)
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.Axel4;
                    }
                    else if (GameOver == 5)
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.Axel5;
                    }
                    else if (GameOver == 6)
                    {
                        MessageBox.Show("Has perdido :(, tu record es de " + puntaje);
                        pictureBox1.BackgroundImage = Properties.Resources.Axel6;
                        StartGame.Visible = true;
                        StartGame.Enabled = true;
                        StartGame.Size = new Size(88, 70);
                        StartGame.Text = "Salir";
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Res_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dat2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dat1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();
        }

        private void Ahorcado_Load(object sender, EventArgs e)
        {

        }
    }
}
