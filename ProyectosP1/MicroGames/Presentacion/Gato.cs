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
    public partial class Gato : Form
    {
        public Gato()
        {
            InitializeComponent();
        }
        byte Turno = 0;
        byte bot1 = 0;
        byte bot2 = 0;
        byte bot3 = 0;
        byte bot4 = 0;
        byte bot5 = 0;
        byte bot6 = 0;
        byte bot7 = 0;
        byte bot8 = 0;
        byte bot9 = 0;
        double puntaje1 = 0;
        double puntaje2 = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void x3y3_Click(object sender, EventArgs e)
        {
            if (Turno == 0)
            {
                x3y3.BackgroundImage = Properties.Resources.Tacha;
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
                bot9 = 1;
                x3y3.Enabled = false;
                Win();
            }
            else
            {
                x3y3.BackgroundImage = Properties.Resources.Circulo;
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
                bot9 = 2;
                x3y3.Enabled = false;
                Win();
            }
        }

        private void x2y3_Click(object sender, EventArgs e)
        {
            if (Turno == 0)
            {
                x2y3.BackgroundImage = Properties.Resources.Tacha;
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
                bot8 = 1;
                x2y3.Enabled = false;
                Win();
            }
            else
            {
                x2y3.BackgroundImage = Properties.Resources.Circulo;
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
                bot8 = 2;
                x2y3.Enabled = false;
                Win();
            }
        }

        private void x1y3_Click(object sender, EventArgs e)
        {
            if (Turno == 0)
            {
                x1y3.BackgroundImage = Properties.Resources.Tacha;
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
                bot7 = 1;
                x1y3.Enabled = false;
                Win();
            }
            else
            {
                x1y3.BackgroundImage = Properties.Resources.Circulo;
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
                bot7 = 2;
                x1y3.Enabled = false;
                Win();
            }
        }

        private void x3y2_Click(object sender, EventArgs e)
        {
            if (Turno == 0)
            {
                x3y2.BackgroundImage = Properties.Resources.Tacha;
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
                bot6 = 1;
                x3y2.Enabled = false;
                Win();
            }
            else
            {
                x3y2.BackgroundImage = Properties.Resources.Circulo;
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
                bot6 = 2;
                x3y2.Enabled = false;
                Win();
            }
        }

        private void x2y2_Click(object sender, EventArgs e)
        {
            if (Turno == 0)
            {
                x2y2.BackgroundImage = Properties.Resources.Tacha;
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
                bot5 = 1;
                x2y2.Enabled = false;
                Win();
            }
            else
            {
                x2y2.BackgroundImage = Properties.Resources.Circulo;
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
                bot5 = 2;
                x2y2.Enabled = false;
                Win();
            }
        }

        private void x1y2_Click(object sender, EventArgs e)
        {
            if (Turno == 0)
            {
                x1y2.BackgroundImage = Properties.Resources.Tacha;
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
                bot4 = 1;
                x1y2.Enabled = false;
                Win();
            }
            else
            {
                x1y2.BackgroundImage = Properties.Resources.Circulo;
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
                bot4 = 2;
                x1y2.Enabled = false;
                Win();
            }
        }

        private void x3y1_Click(object sender, EventArgs e)
        {
            if (Turno == 0)
            {
                x3y1.BackgroundImage = Properties.Resources.Tacha;
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
                bot3 = 1;
                x3y1.Enabled = false;
                Win();
            }
            else
            {
                x3y1.BackgroundImage = Properties.Resources.Circulo;
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
                bot3 = 2;
                x3y1.Enabled = false;
                Win();
            }
        }

        private void x2y1_Click(object sender, EventArgs e)
        {
            if (Turno == 0)
            {
                x2y1.BackgroundImage = Properties.Resources.Tacha;
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
                bot2 = 1;
                x2y1.Enabled = false;
                Win();
            }
            else
            {
                x2y1.BackgroundImage = Properties.Resources.Circulo;
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
                bot2 = 2;
                x2y1.Enabled = false;
                Win();
            }
        }

        private void x1y1_Click(object sender, EventArgs e)
        {
            if (Turno == 0)
            {
                x1y1.BackgroundImage = Properties.Resources.Tacha;
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
                bot1 = 1;
                x1y1.Enabled = false;
                Win();
            }
            else
            {
                x1y1.BackgroundImage = Properties.Resources.Circulo;
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
                bot1 = 2;
                x1y1.Enabled = false;
                Win();
            }
        }
        public void Win()
        {
            if (bot1 == 1 && bot2 == 1 && bot3 == 1)
            {
                x1y1.BackgroundImage = Properties.Resources.TachaWin;
                x2y1.BackgroundImage = Properties.Resources.TachaWin;
                x3y1.BackgroundImage = Properties.Resources.TachaWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 1");
                puntaje1 = puntaje1 + 1;
                textBox1.Text = puntaje1.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
            }
            else if (bot1 == 2 && bot2 == 2 && bot3 == 2)
            {
                x1y1.BackgroundImage = Properties.Resources.CirculoWin;
                x2y1.BackgroundImage = Properties.Resources.CirculoWin;
                x3y1.BackgroundImage = Properties.Resources.CirculoWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 2");
                puntaje2 = puntaje2 + 1;
                textBox2.Text = puntaje2.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
            }
            else if (bot4 == 1 && bot5 == 1 && bot6 == 1)
            {
                x1y2.BackgroundImage = Properties.Resources.TachaWin;
                x2y2.BackgroundImage = Properties.Resources.TachaWin;
                x3y2.BackgroundImage = Properties.Resources.TachaWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 1");
                puntaje1 = puntaje1 + 1;
                textBox1.Text = puntaje1.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
            }
            else if (bot4 == 2 && bot5 == 2 && bot6 == 2)
            {
                x1y2.BackgroundImage = Properties.Resources.CirculoWin;
                x2y2.BackgroundImage = Properties.Resources.CirculoWin;
                x3y2.BackgroundImage = Properties.Resources.CirculoWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 2");
                puntaje2 = puntaje2 + 1;
                textBox2.Text = puntaje2.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
            }
            else if (bot7 == 1 && bot8 == 1 && bot9 == 1)
            {
                x1y3.BackgroundImage = Properties.Resources.TachaWin;
                x2y3.BackgroundImage = Properties.Resources.TachaWin;
                x3y3.BackgroundImage = Properties.Resources.TachaWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 1");
                puntaje1 = puntaje1 + 1;
                textBox1.Text = puntaje1.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
            }
            else if (bot7 == 2 && bot8 == 2 && bot9 == 2)
            {
                x1y3.BackgroundImage = Properties.Resources.CirculoWin;
                x2y3.BackgroundImage = Properties.Resources.CirculoWin;
                x3y3.BackgroundImage = Properties.Resources.CirculoWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 2");
                puntaje2 = puntaje2 + 1;
                textBox2.Text = puntaje2.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
            }
            else if (bot1 == 1 && bot4 == 1 && bot7 == 1)
            {
                x1y1.BackgroundImage = Properties.Resources.TachaWin;
                x1y2.BackgroundImage = Properties.Resources.TachaWin;
                x1y3.BackgroundImage = Properties.Resources.TachaWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 1");
                puntaje1 = puntaje1 + 1;
                textBox1.Text = puntaje1.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
            }
            else if (bot1 == 2 && bot4 == 2 && bot7 == 2)
            {
                x1y1.BackgroundImage = Properties.Resources.CirculoWin;
                x1y2.BackgroundImage = Properties.Resources.CirculoWin;
                x1y3.BackgroundImage = Properties.Resources.CirculoWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 2");
                puntaje2 = puntaje2 + 1;
                textBox2.Text = puntaje2.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
            }
            else if (bot2 == 1 && bot5 == 1 && bot8 == 1)
            {
                x2y1.BackgroundImage = Properties.Resources.TachaWin;
                x2y2.BackgroundImage = Properties.Resources.TachaWin;
                x2y3.BackgroundImage = Properties.Resources.TachaWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 1");
                puntaje1 = puntaje1 + 1;
                textBox1.Text = puntaje1.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
            }
            else if (bot2 == 2 && bot5 == 2 && bot8 == 2)
            {
                x2y1.BackgroundImage = Properties.Resources.CirculoWin;
                x2y2.BackgroundImage = Properties.Resources.CirculoWin;
                x2y3.BackgroundImage = Properties.Resources.CirculoWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 2");
                puntaje2 = puntaje2 + 1;
                textBox2.Text = puntaje2.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
            }
            else if (bot3 == 1 && bot6 == 1 && bot9 == 1)
            {
                x3y1.BackgroundImage = Properties.Resources.TachaWin;
                x3y2.BackgroundImage = Properties.Resources.TachaWin;
                x3y3.BackgroundImage = Properties.Resources.TachaWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 1");
                puntaje1 = puntaje1 + 1;
                textBox1.Text = puntaje1.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
            }
            else if (bot3 == 2 && bot6 == 2 && bot9 == 2)
            {
                x3y1.BackgroundImage = Properties.Resources.CirculoWin;
                x3y2.BackgroundImage = Properties.Resources.CirculoWin;
                x3y3.BackgroundImage = Properties.Resources.CirculoWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 2");
                puntaje2 = puntaje2 + 1;
                textBox2.Text = puntaje2.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
            }
            else if (bot1 == 1 && bot5 == 1 && bot9 == 1)
            {
                x1y1.BackgroundImage = Properties.Resources.TachaWin;
                x2y2.BackgroundImage = Properties.Resources.TachaWin;
                x3y3.BackgroundImage = Properties.Resources.TachaWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 1");
                puntaje1 = puntaje1 + 1;
                textBox1.Text = puntaje1.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
            }
            else if (bot1 == 2 && bot5 == 2 && bot9 == 2)
            {
                x1y1.BackgroundImage = Properties.Resources.CirculoWin;
                x2y2.BackgroundImage = Properties.Resources.CirculoWin;
                x3y3.BackgroundImage = Properties.Resources.CirculoWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 2");
                puntaje2 = puntaje2 + 1;
                textBox2.Text = puntaje2.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
            }
            else if (bot3 == 1 && bot5 == 1 && bot7 == 1)
            {
                x1y3.BackgroundImage = Properties.Resources.TachaWin;
                x2y2.BackgroundImage = Properties.Resources.TachaWin;
                x3y1.BackgroundImage = Properties.Resources.TachaWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 1");
                puntaje1 = puntaje1 + 1;
                textBox1.Text = puntaje1.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                Turno = 0;
            }
            else if (bot3 == 2 && bot5 == 2 && bot7 == 2)
            {
                x1y3.BackgroundImage = Properties.Resources.CirculoWin;
                x2y2.BackgroundImage = Properties.Resources.CirculoWin;
                x3y1.BackgroundImage = Properties.Resources.CirculoWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                MessageBox.Show("Gano Jugador 2");
                puntaje2 = puntaje2 + 1;
                textBox2.Text = puntaje2.ToString();
                Reset.Enabled = true;
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                Turno = 1;
            }
            else if (bot1 != 0 && bot2 != 0 && bot3 != 0 && bot4 != 0 && bot5 != 0 && bot6 != 0 && bot7 != 0 && bot8 != 0 && bot9 != 0)
            {
                MessageBox.Show("Empate");
                Reset.Enabled = true;
            }
            else
            {

            }

        }
        public void Block()
        {
            x1y1.Enabled = false;
            x1y2.Enabled = false;
            x1y3.Enabled = false;
            x2y1.Enabled = false;
            x2y2.Enabled = false;
            x2y3.Enabled = false;
            x3y1.Enabled = false;
            x3y2.Enabled = false;
            x3y3.Enabled = false;
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            x1y1.Enabled = true;
            x1y2.Enabled = true;
            x1y3.Enabled = true;
            x2y1.Enabled = true;
            x2y2.Enabled = true;
            x2y3.Enabled = true;
            x3y1.Enabled = true;
            x3y2.Enabled = true;
            x3y3.Enabled = true;
            x1y1.BackgroundImage = Properties.Resources.Blacky;
            x2y1.BackgroundImage = Properties.Resources.Blacky;
            x3y1.BackgroundImage = Properties.Resources.Blacky;
            x1y2.BackgroundImage = Properties.Resources.Blacky;
            x2y2.BackgroundImage = Properties.Resources.Blacky;
            x3y2.BackgroundImage = Properties.Resources.Blacky;
            x1y3.BackgroundImage = Properties.Resources.Blacky;
            x2y3.BackgroundImage = Properties.Resources.Blacky;
            x3y3.BackgroundImage = Properties.Resources.Blacky;
            bot1 = 0;
            bot2 = 0;
            bot3 = 0;
            bot4 = 0;
            bot5 = 0;
            bot6 = 0;
            bot7 = 0;
            bot8 = 0;
            bot9 = 0;
            Reset.Enabled = false;
            Cato.BackgroundImage = Properties.Resources.cato;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();
        }
    }
}
