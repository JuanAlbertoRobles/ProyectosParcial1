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
        //definen las variables con el valor 0
        double resBien = 0;
        double puntaje = 0;
        double GameOver = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        //funcion del boton de borrar
        private void Borrar_Click(object sender, EventArgs e)
        {
            //si  res es igual a 1 se ejecuta 
            if (Res.TextLength == 1 && Res.TextLength == 1)
            {
                //cabia el numero que se encutra en res a 0
                Res.Text = "0";
            }
            // en otro caso se elimina el ultimo numero agregado
            else
            {
                // se elimina de res el ultimo numero agragado
                Res.Text = Res.Text.Substring(0, Res.Text.Length - 1);
            }
        }

        private void Error_TextChanged(object sender, EventArgs e)
        {

        }

        // funcion del boton 0
        private void Botcero_Click(object sender, EventArgs e)
        {
            // si en res se igual a 0 se ejecuta
            if (Res.Text == "0")
            {
                //cambia res a 0
                Res.Text = "0";
            }
            // en otro caso se agraga un cero a res 
            else
            {
                Res.Text = Res.Text + "0";
            }
        }

        // funcion del boton 9
        private void BotNueve_Click(object sender, EventArgs e)
        {
            // si en res se igual a 0 se ejecuta
            // varable inicla 
            if (Res.Text == "0")
            {
                // en res cambia el 0 por el 9
                Res.Text = "9";
            }
            // en otro caso se agrega un 9 a res 
            else
            {
                Res.Text = Res.Text + "9";
            }
        }

        // funcion del boton 8
        private void BotOcho_Click(object sender, EventArgs e)
        {
            // si en res se igual a 0 se ejecuta
            // varable inicla
            if (Res.Text == "0")
            {
                // se cambia el 0 por un 8 en res 
                Res.Text = "8";
            }
            //en otro caso se agrega un 8 a res
            else
            {
                // agrega un 8 a res
                Res.Text = Res.Text + "8";
            }
        }

        //funcion del boton 7
        private void BotSiete_Click(object sender, EventArgs e)
        {
            // si en res se igual a 0 se ejecuta
            // varable inicla
            if (Res.Text == "0")
            {
                // se cambia el 0 por un 7 en res
                Res.Text = "7";
            }
            // en otro caso se agrega un 7 a res 
            else
            {
                //agrega un 7 a res 
                Res.Text = Res.Text + "7";
            }
        }

        //funcion del boton 6
        private void BotSeis_Click(object sender, EventArgs e)
        {
            // si en res se igual a 0 se ejecuta
            // varable inicla
            if (Res.Text == "0")
            {
                //cambia el 0 por un 6 en res
                Res.Text = "6";
            }
            // en otro caso se agrega un 6 a res
            else
            {
                //aumenta un 6 a res 
                Res.Text = Res.Text + "6";
            }
        }

        //funcion del boton 5
        private void BotCin_Click(object sender, EventArgs e)
        {
            // si en res se igual a 0 se ejecuta
            // varable inicla
            if (Res.Text == "0")
            {
                // se cambia el 0 por un 5 en res 
                Res.Text = "5";
            }
            //en otro caso se agrega un 5 a res 
            else
            {
                //aumneta un 5 a res 
                Res.Text = Res.Text + "5";
            }
        }

    
        // funcion del boton 4
        private void BotCua_Click(object sender, EventArgs e)
        {
            // si en res se igual a 0 se ejecuta
            // varable inicla
            if (Res.Text == "0")
            {
                //se cambia el 0 por un 4 en res 
                Res.Text = "4";
            }
            //en otro caso se agrega un 4 a res
            else
            {
                //se agrega un 4 a res
                Res.Text = Res.Text + "4";
            }
        }

        //funcion del boton 3
        private void BotTres_Click(object sender, EventArgs e)
        {
            // si en res se igual a 0 se ejecuta
            // varable inicla
            if (Res.Text == "0")
            {
                //se cambia el 0 por un 3 en res
                Res.Text = "3";
            }
            //en otro caso se agrega un 3 a res
            else
            {
                //agrega un 3 a res
                Res.Text = Res.Text + "3";
            }
        }

        //funcion del boton 2
        private void BotDos_Click(object sender, EventArgs e)
        {
            // si en res se igual a 0 se ejecuta
            // varable inicla
            if (Res.Text == "0")
            {
                //se cambia el 0 inicial por un 2
                Res.Text = "2";
            }
            // en otro caso se agrega un 2 a res
            else
            {
                //agrega un 2 a res
                Res.Text = Res.Text + "2";
            }
        }

        //funcion del boton 1 
        private void BotUno_Click(object sender, EventArgs e)
        {
            // si en res se igual a 0 se ejecuta
            // varable inicla
            if (Res.Text == "0")
            {
                //se cambia el 0 inicial por un 1
                Res.Text = "1";
            }
            //en otro caso se agrega un 1
            else
            {
                //agrega un 1 a res
                Res.Text = Res.Text + "1";
            }
        }

        //funcion del boton de start
        private void StartGame_Click(object sender, EventArgs e)
        {
            //se hace invisible y se desabilita el boton de start
            StartGame.Visible = false;
            StartGame.Enabled = false;
            Random random = new Random();
            // se pone un numero al asar entre el 1 y el 11
            double num1 = random.Next(1, 11);
            double num2 = random.Next(1, 11);
            Dat1.Text = num1.ToString();
            Dat2.Text = num2.ToString();
            // se obtiene la respueta correcta
            resBien = num1 * num2;
            Res.Text = "0";
            if (ModoNoche.Selection == 1)
            {
                
            }
            else if (ModoNoche.Selection == 2)
            {
                // cambio de imaguen
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

        // funcion para comprobar la respuesta 
        private void Probar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Res.Text, out double resPlayer))
            {
                // si la respuesta del jugador es igual a la resbien se ejecuta
                if (resPlayer == resBien)
                {
                    //muestra un mensaje de que estubo corecto 
                    MessageBox.Show("Gano");
                    //suma un punto a su puntaje
                    puntaje = puntaje + 1;
                    Puntaje.Text = puntaje.ToString();
                    //se habilita el boton de start
                    StartGame.Visible = true;
                    StartGame.Enabled = true;
                    //se cambia el texto del boton
                    StartGame.Text = "Continuar";
                    StartGame.Width = 150;

                }
                //si se respondio mal se ejecuta
                else
                {
                    // muestra un mensaje de que estubo mal su respuesta 
                    MessageBox.Show("Perdio");
                    // se habilita el boton de start
                    StartGame.Visible = true;
                    StartGame.Enabled = true;
                    //se cambia el texto del boton
                    StartGame.Text = "Continuar";
                    StartGame.Width = 150;
                    // aumenta un punto a la varable gameover
                    GameOver = GameOver + 1;
                    Error.Text = GameOver.ToString();
                    //si gameover es igual a 1 se ejecuta
                    if (GameOver == 1)
                    {
                        //se cambia la imagen del ahorcado
                        pictureBox1.BackgroundImage = Properties.Resources.Axel1;
                        StartGame.Width = 150;
                    }
                    //si gameover es igual a 2 se ejecuta
                    else if (GameOver == 2)
                    {
                        //se cambia de imagen 
                        pictureBox1.BackgroundImage = Properties.Resources.Axel2;
                    }
                    //si gameover es igual a 3 se ejecuta
                    else if (GameOver == 3)
                    {
                        // se cambia de imagen
                        pictureBox1.BackgroundImage = Properties.Resources.Axel3;
                    }
                    //si gameover es igual a 4 se ejecuta
                    else if (GameOver == 4)
                    {
                        // se cambia de imagen
                        pictureBox1.BackgroundImage = Properties.Resources.Axel4;
                    }
                    //si gameover es igual a 5 se ejecuta
                    else if (GameOver == 5)
                    {
                        //se cambia de imagen
                        pictureBox1.BackgroundImage = Properties.Resources.Axel5;
                    }
                    //si gameover es igual a 6 se ejecuta
                    else if (GameOver == 6)
                    {
                        //muetra un mensaje de que perdio el usuario mas el puntaje obtenido 
                        MessageBox.Show("Has perdido :(, tu record es de " + puntaje);
                        //cambia a la ultima imagen
                        pictureBox1.BackgroundImage = Properties.Resources.Axel6;
                        //se habilita el boton de start
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
