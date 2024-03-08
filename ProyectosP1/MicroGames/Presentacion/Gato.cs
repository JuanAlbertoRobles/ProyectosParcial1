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
        //se definen las variables 
        //turno, puntaje de los jugadores y el valor de los botones
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

        //funcion para el boton x3y3
        private void x3y3_Click(object sender, EventArgs e)
        {
            // si el turno del jugador es 0 se ejecuta lo siguiente
            if (Turno == 0)
            {
                //se cambia la imagen del boton a la del jugador 1
                x3y3.BackgroundImage = Properties.Resources.Tacha;
                //cambia la imagen del turno a la del jugador 2
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                //se cambia el valor de las variables
                Turno = 1;
                bot9 = 1;
                //se desabilita el bton
                x3y3.Enabled = false;
                //llama a la funcion win
                Win();
            }
            else
            {
                //se cambia la imagen del boton 
                x3y3.BackgroundImage = Properties.Resources.Circulo;
                //cambia la imagen del turno a la del jugador 1
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                //cambia el valor de las variables
                Turno = 0;
                bot9 = 2;
                //se desabilita el botn
                x3y3.Enabled = false;
                // se llama a la funcion win
                Win();
            }
        }

        //funcion del bton x2y3
        private void x2y3_Click(object sender, EventArgs e)
        {
            // se ejecuta si turno es 0
            if (Turno == 0)
            {
                // se cambia la imagen del borton a la del jugador 1
                x2y3.BackgroundImage = Properties.Resources.Tacha;
                //cambia la imagen de turno a la del jugador 2
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                //se cambia las variables 
                Turno = 1;
                bot8 = 1;
                // se desabilita el boton
                x2y3.Enabled = false;
                // se llama a la funcion win
                Win();
            }
            else
            {
                // se cambia la imagen del boton a la del jugador 1
                x2y3.BackgroundImage = Properties.Resources.Circulo;
                //se cambia la imagen de truno a la del jugador 2
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                //se cambia el valor de las variables
                Turno = 0;
                bot8 = 2;
                //se desabilita el boton
                x2y3.Enabled = false;
                //se llama a la funcion win
                Win();
            }
        }

        //funcion de boton x1y3
        private void x1y3_Click(object sender, EventArgs e)
        {
            //se ejecuta si el turno es 0
            if (Turno == 0)
            {
                //se cambia la imagen del boton a la del jugador 1
                x1y3.BackgroundImage = Properties.Resources.Tacha;
                // se cambia la imagen a la del jugador 2
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                // se cambia los valores de la variable
                Turno = 1;
                bot7 = 1;
                //se desahabilita el bton
                x1y3.Enabled = false;
                //se llama a la funcion de win
                Win();
            }
            // si es deiferente a 0 se ejecuta
            else
            {
                //cambia la imagen del boton a la del jugador 2
                x1y3.BackgroundImage = Properties.Resources.Circulo;
                // cambia la imagen del turno a la del jugador 1
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                //cambia el valor de las variables
                Turno = 0;
                bot7 = 2;
                //se desabilita el boton
                x1y3.Enabled = false;
                //se llama a la funcion de win
                Win();
            }
        }


        //funcion del boton x3y2
        private void x3y2_Click(object sender, EventArgs e)
        {
            //si turno es 0 se ejcuta
            if (Turno == 0)
            {
                //se cambia la imagen del boton a la del jugador 1
                x3y2.BackgroundImage = Properties.Resources.Tacha;
                //se cambi la imagen del turno a la del juagador 2
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                //cambia el valor de las variables 
                Turno = 1;
                bot6 = 1;
                //se desabilita e boton
                x3y2.Enabled = false;
                //se llama a la funcion de win
                Win();
            } 
            //si es diferente a 0 se ejecuta 
            else
            {
                //cambia la imagen del boton a la del jugador 2
                x3y2.BackgroundImage = Properties.Resources.Circulo;
                //cambia la imagen del turno a la del jugador 1
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                //csambia el valor de las variables 
                Turno = 0;
                bot6 = 2;
                //se desabilita el boton
                x3y2.Enabled = false;
                //se llama a la funcion de win
                Win();
            }
        }

        //funcion de l boton x2y2
        private void x2y2_Click(object sender, EventArgs e)
        {
            //si turno es 0 se ejecuta 
            if (Turno == 0)
            {
                //se cambia la imagen del boton por la del jugador 1
                x2y2.BackgroundImage = Properties.Resources.Tacha;
                //se cambia la imagen de turno por la del jugador 2
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                //se cambia el valor de las variables 
                Turno = 1;
                bot5 = 1;
                //se desabilita el boton
                x2y2.Enabled = false;
                //se llama a la funcion de win
                Win();
            }
            // si es diferente a 0 se ejecuta
            else
            {
                //se cambia la imagen del boton por la del jugador 2
                x2y2.BackgroundImage = Properties.Resources.Circulo;
                //se cambi la imagen del turno por la del jugador 1
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                //se cambia las variables 
                Turno = 0;
                bot5 = 2;
                //se desabilita el boton
                x2y2.Enabled = false;
                //se llama a la funcion de win
                Win();
            }
        }

        //funcion del boton x1y2
        private void x1y2_Click(object sender, EventArgs e)
        {
            //si turno es 0 se ejecuta
            if (Turno == 0)
            {
                //se cambia la imagen del boton port la del jugador 1
                x1y2.BackgroundImage = Properties.Resources.Tacha;
                //se cambia la imagen del turno por la del jugador 2
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                //se cambia el valor de las variables 
                Turno = 1;
                bot4 = 1;
                //se desabilita el boton
                x1y2.Enabled = false;
                //se llama a la funcion de win
                Win();
            }
            //si es diferente a 0 se ejecuta
            else
            {
                //se cambia la imagen del boton por la del jugador 2
                x1y2.BackgroundImage = Properties.Resources.Circulo;
                //se cambia la imagen del turno por la del jugador 1
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                //se cambia el valor de las variables
                Turno = 0;
                bot4 = 2;
                //se desabilita ek boton
                x1y2.Enabled = false;
                //se llama a la funcion de win
                Win();
            }
        }

        //funcion del boton x3y1
        private void x3y1_Click(object sender, EventArgs e)
        {
            //si turno es 0 se ejecuta
            if (Turno == 0)
            {
                //se cambia la imagen del boton por la del jugador 1
                x3y1.BackgroundImage = Properties.Resources.Tacha;
                //se cambia la imagen del turno por la del jugador 2
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                // se cambia el valor de las variables
                Turno = 1;
                bot3 = 1;
                //se desabilita el botn
                x3y1.Enabled = false;
                //se llama a la funcion de win
                Win();
            }
            //si es diferente a 0 se ejecuta 
            else
            {
                //se cambi la imagen del boton por la del jugador 2
                x3y1.BackgroundImage = Properties.Resources.Circulo;
                //se cambia la imagen del turno por la del jugador 1
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                //se cambia el valor de las variables
                Turno = 0;
                bot3 = 2;
                //se desabilita el boton
                x3y1.Enabled = false;
                //llama a la funcion de win
                Win();
            }
        }

        //funcion del boton x2y1
        private void x2y1_Click(object sender, EventArgs e)
        {
            if (Turno == 0)
            {
                //se cambi la imagen del boton por la del jugador 1
                x2y1.BackgroundImage = Properties.Resources.Tacha;
                //se cambia la imagen del turno por la del jugador 2
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                //se cambia el valor de las variables
                Turno = 1;
                bot2 = 1;
                //se desabilita el boton
                x2y1.Enabled = false;
                //llama a la funcion de win
                Win();
            }
            else
            {
                //se cambi la imagen del boton por la del jugador 2
                x2y1.BackgroundImage = Properties.Resources.Circulo;
                //se cambia la imagen del turno por la del jugador 1
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                //se cambia el valor de las variables
                Turno = 0;
                bot2 = 2;
                //se desabilita el boton
                x2y1.Enabled = false;
                //llama a la funcion de win
                Win();
            }
        }

        //funcion del boton x1y1
        private void x1y1_Click(object sender, EventArgs e)
        {
            if (Turno == 0)
            {
                //se cambi la imagen del boton por la del jugador 1
                x1y1.BackgroundImage = Properties.Resources.Tacha;
                //se cambia la imagen del turno por la del jugador 2
                pictureBox2.BackgroundImage = Properties.Resources.Circulo;
                //se cambia el valor de las variables
                Turno = 1;
                bot1 = 1;
                //se desabilita el boton
                x1y1.Enabled = false;
                //llama a la funcion de win
                Win();
            }
            else
            {
                //se cambi la imagen del boton por la del jugador 2
                x1y1.BackgroundImage = Properties.Resources.Circulo;
                //se cambia la imagen del turno por la del jugador 1
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                //se cambia el valor de las variables
                Turno = 0;
                bot1 = 2;
                //se desabilita el boton
                x1y1.Enabled = false;
                //llama a la funcion de win
                Win();
            }
        }

        //funcion para determinar quien gano
        public void Win()
        {
            // si los botones 1, 2 y 3 son del jugador uno 1 ejecuta
            if (bot1 == 1 && bot2 == 1 && bot3 == 1)
            {
                //se cambia las imagenes de los tres botones por las de tache win
                x1y1.BackgroundImage = Properties.Resources.TachaWin;
                x2y1.BackgroundImage = Properties.Resources.TachaWin;
                x3y1.BackgroundImage = Properties.Resources.TachaWin;
                Cato.BackgroundImage = Properties.Resources.catoWin;
                //se muestra un mensaje 
                MessageBox.Show("Gano Jugador 1");
                // aumenta el punytaje del jugador 1
                puntaje1 = puntaje1 + 1;
                textBox1.Text = puntaje1.ToString();
                //se habilita el botn
                Reset.Enabled = true;
                //llama a la funcion de block
                Block();
                pictureBox2.BackgroundImage = Properties.Resources.Tacha;
                //se cambia el valor de turno
                Turno = 0;
            }
            // si los botones 1, 2 y 3 son del jugador uno 2 ejecuta
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
            // si los botones 4, 5 y 6 son del jugador uno 1 ejecuta
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
            // si los botones 4, 5 y 6 son del jugador uno 1 ejecuta
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
            // si los botones 7, 8 y 9 son del jugador uno 1 ejecuta
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
            // si los botones 7, 8 y 9 son del jugador uno 2 ejecuta
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
            // si los botones 1, 4 y 7 son del jugador uno 1 ejecuta
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
            // si los botones 1, 4 y 7 son del jugador  2 ejecuta
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
            // si los botones 2, 5 y 8 son del jugador uno 1 ejecuta
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
            // si los botones 2, 5 y 8 son del jugador 2 ejecuta
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
            // si los botones 3, 6 y 9 son del jugador uno 1 ejecuta
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
            // si los botones 3, 6 y 9 son del jugador uno 1 ejecuta
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
            // si los botones 1, 5 y 9 son del jugador uno 1 ejecuta
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
            // si los botones 1, 5 y  son del jugador 2 ejecuta
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
            // si los botones 3, 5 y 7 son del jugador uno 1 ejecuta
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
            // si los botones 2, 5 y 7 son del jugador 2 ejecuta
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
            //si los botones son diferentes a 0 se ejecuta
            else if (bot1 != 0 && bot2 != 0 && bot3 != 0 && bot4 != 0 && bot5 != 0 && bot6 != 0 && bot7 != 0 && bot8 != 0 && bot9 != 0)
            {
                //muestra un mesnaje de error
                MessageBox.Show("Empate");
                Reset.Enabled = true;
            }
            else
            {

            }

        }

        //funcion para bloquear los botones 
        public void Block()
        {
            //se bloquean todos los botones donde el jugador puede jugar
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

        //funcion para resert todo
        private void Reset_Click(object sender, EventArgs e)
        {
            //todos los bottones donde pueden jugar los jugadores se habilitan
            x1y1.Enabled = true;
            x1y2.Enabled = true;
            x1y3.Enabled = true;
            x2y1.Enabled = true;
            x2y2.Enabled = true;
            x2y3.Enabled = true;
            x3y1.Enabled = true;
            x3y2.Enabled = true;
            x3y3.Enabled = true;
            //todos los botones se vuleven a poder con su imagen original
            x1y1.BackgroundImage = Properties.Resources.Blacky;
            x2y1.BackgroundImage = Properties.Resources.Blacky;
            x3y1.BackgroundImage = Properties.Resources.Blacky;
            x1y2.BackgroundImage = Properties.Resources.Blacky;
            x2y2.BackgroundImage = Properties.Resources.Blacky;
            x3y2.BackgroundImage = Properties.Resources.Blacky;
            x1y3.BackgroundImage = Properties.Resources.Blacky;
            x2y3.BackgroundImage = Properties.Resources.Blacky;
            x3y3.BackgroundImage = Properties.Resources.Blacky;
            //las variables vuelven a su valor original
            bot1 = 0;
            bot2 = 0;
            bot3 = 0;
            bot4 = 0;
            bot5 = 0;
            bot6 = 0;
            bot7 = 0;
            bot8 = 0;
            bot9 = 0;
            //se desabilita el boton
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

        private void Gato_Load(object sender, EventArgs e)
        {

        }
    }
}
