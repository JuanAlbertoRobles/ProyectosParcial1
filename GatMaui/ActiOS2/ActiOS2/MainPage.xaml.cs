
using static System.Net.Mime.MediaTypeNames;

namespace ActiOS2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
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
        int puntaje1 = 0;
        int puntaje2 = 0;
        private void OnCounterClicked(object sender, EventArgs e)
        {


        }

        void conta(object sender, EventArgs args)
        {

        }

        public void x1y1_Click(object sender, EventArgs args)
        {
            if (Turno == 0)
            {
                x1y1.ImageSource = "tacha.png";
                jugadorenjuego.Source = "circulo.png";
                Turno = 1;
                bot1 = 1;
                x1y1.IsEnabled = false;
                Win();
            }
            else
            {
                x1y1.ImageSource = "circulo.png";
                jugadorenjuego.Source = "tacha.png";
                Turno = 0;
                bot1 = 2;
                x1y1.IsEnabled = false;
                Win();
            }
        }
        public void x1y2_Click(object sender, EventArgs args)
        {
            if (Turno == 0)
            {
                x1y2.ImageSource = "tacha.png";
                jugadorenjuego.Source = "circulo.png";
                Turno = 1;
                bot4 = 1;
                x1y2.IsEnabled = false;
                Win();
            }
            else
            {
                x1y2.ImageSource = "circulo.png";
                jugadorenjuego.Source = "tacha.png";
                Turno = 0;
                bot4 = 2;
                x1y2.IsEnabled = false;
                Win();
            }
        }
        public void x1y3_Click(object sender, EventArgs args)
        {
            if (Turno == 0)
            {
                x1y3.ImageSource = "tacha.png";
                jugadorenjuego.Source = "circulo.png";
                Turno = 1;
                bot7 = 1;
                x1y3.IsEnabled = false;
                Win();
            }
            else
            {
                x1y3.ImageSource = "circulo.png";
                jugadorenjuego.Source = "tacha.png";
                Turno = 0;
                bot7 = 2;
                x1y3.IsEnabled = false;
                Win();
            }
        }
        public void x2y1_Click(object sender, EventArgs args)
        {
            if (Turno == 0)
            {
                x2y1.ImageSource = "tacha.png";
                jugadorenjuego.Source = "circulo.png";
                Turno = 1;
                bot2 = 1;
                x2y1.IsEnabled = false;
                Win();
            }
            else
            {
                x2y1.ImageSource = "circulo.png";
                jugadorenjuego.Source = "tacha.png";
                Turno = 0;
                bot2 = 2;
                x2y1.IsEnabled = false;
                Win();
            }
        }
        public void x2y2_Click(object sender, EventArgs args)
        {
            if (Turno == 0)
            {
                x2y2.ImageSource = "tacha.png";
                jugadorenjuego.Source = "circulo.png";
                Turno = 1;
                bot5 = 1;
                x2y2.IsEnabled = false;
                Win();
            }
            else
            {
                x2y2.ImageSource = "circulo.png";
                jugadorenjuego.Source = "tacha.png";
                Turno = 0;
                bot5 = 2;
                x2y2.IsEnabled = false;
                Win();
            }
        }
        public void x2y3_Click(object sender, EventArgs args)
        {
            if (Turno == 0)
            {
                x2y3.ImageSource = "tacha.png";
                jugadorenjuego.Source = "circulo.png";
                Turno = 1;
                bot8 = 1;
                x2y3.IsEnabled = false;
                Win();
            }
            else
            {
                x2y3.ImageSource = "circulo.png";
                jugadorenjuego.Source = "tacha.png";
                Turno = 0;
                bot8 = 2;
                x2y3.IsEnabled = false;
                Win();
            }
        }
        public void x3y1_Click(object sender, EventArgs args)
        {
            if (Turno == 0)
            {
                x3y1.ImageSource = "tacha.png";
                jugadorenjuego.Source = "circulo.png";
                Turno = 1;
                bot3 = 1;
                x3y1.IsEnabled = false;
                Win();
            }
            else
            {
                x3y1.ImageSource = "circulo.png";
                jugadorenjuego.Source = "tacha.png";
                Turno = 0;
                bot3 = 2;
                x3y1.IsEnabled = false;
                Win();
            }
        }
        public void x3y2_Click(object sender, EventArgs args)
        {
            if (Turno == 0)
            {
                x3y2.ImageSource = "tacha.png";
                jugadorenjuego.Source = "circulo.png";
                Turno = 1;
                bot6 = 1;
                x3y2.IsEnabled = false;
                Win();
            }
            else
            {
                x3y2.ImageSource = "circulo.png";
                jugadorenjuego.Source = "tacha.png";
                Turno = 0;
                bot6 = 2;
                x3y2.IsEnabled = false;
                Win();
            }
        }
        public void x3y3_Click(object sender, EventArgs args)
        {
            if (Turno == 0)
            {
                x3y3.ImageSource = "tacha.png";
                jugadorenjuego.Source = "circulo.png";
                Turno = 1;
                bot9 = 1;
                x3y3.IsEnabled = false;
                Win();
            }
            else
            {
                x3y3.ImageSource = "circulo.png";
                jugadorenjuego.Source = "tacha.png";
                Turno = 0;
                bot9 = 2;
                x3y3.IsEnabled = false;
                Win();
            }
        }

        public void Win()
        {
            if (bot1 == 1 && bot2 == 1 && bot3 == 1)
            {
                x1y1.ImageSource = "tachawin.png";
                x2y1.ImageSource = "tachawin.png";
                x3y1.ImageSource = "tachawin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "tacha.png";
                Block();

                puntaje1 = puntaje1 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 1", "OK");
                scorep1.Text = "PuntajeP1 = " + puntaje1.ToString();


                Turno = 0;
            }
            else if (bot1 == 2 && bot2 == 2 && bot3 == 2)
            {
                x1y1.ImageSource = "circulowin.png";
                x2y1.ImageSource = "circulowin.png";
                x3y1.ImageSource = "circulowin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "circulo.png";
                Block();

                puntaje2 = puntaje2 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 2", "OK");
                scorep2.Text = "PuntajeP2 = " + puntaje2.ToString();


                Turno = 1;
            }
            else if (bot4 == 1 && bot5 == 1 && bot6 == 1)
            {
                x1y2.ImageSource = "tachawin.png";
                x2y2.ImageSource = "tachawin.png";
                x3y2.ImageSource = "tachawin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "tacha.png";
                Block();

                puntaje1 = puntaje1 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 1", "OK");
                scorep1.Text = "PuntajeP1 = " + puntaje1.ToString();


                Turno = 0;
            }
            else if (bot4 == 2 && bot5 == 2 && bot6 == 2)
            {
                x1y2.ImageSource = "circulowin.png";
                x2y2.ImageSource = "circulowin.png";
                x3y2.ImageSource = "circulowin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "circulo.png";
                Block();

                puntaje2 = puntaje2 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 2", "OK");
                scorep2.Text = "PuntajeP2 = " + puntaje2.ToString();


                Turno = 1;
            }
            else if (bot7 == 1 && bot8 == 1 && bot9 == 1)
            {
                x1y3.ImageSource = "tachawin.png";
                x2y3.ImageSource = "tachawin.png";
                x3y3.ImageSource = "tachawin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "tacha.png";
                Block();

                puntaje1 = puntaje1 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 1", "OK");
                scorep1.Text = "PuntajeP1 = " + puntaje1.ToString();


                Turno = 0;
            }
            else if (bot7 == 2 && bot8 == 2 && bot9 == 2)
            {
                x1y3.ImageSource = "circulowin.png";
                x2y3.ImageSource = "circulowin.png";
                x3y3.ImageSource = "circulowin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "circulo.png";
                Block();

                puntaje2 = puntaje2 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 2", "OK");
                scorep2.Text = "PuntajeP2 = " + puntaje2.ToString();


                Turno = 1;
            }
            else if (bot1 == 1 && bot4 == 1 && bot7 == 1)
            {
                x1y1.ImageSource = "tachawin.png";
                x1y2.ImageSource = "tachawin.png";
                x1y3.ImageSource = "tachawin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "tacha.png";
                Block();

                puntaje1 = puntaje1 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 1", "OK");
                scorep1.Text = "PuntajeP1 = " + puntaje1.ToString();


                Turno = 0;
            }
            else if (bot1 == 2 && bot4 == 2 && bot7 == 2)
            {
                x1y1.ImageSource = "circulowin.png";
                x1y2.ImageSource = "circulowin.png";
                x1y3.ImageSource = "circulowin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "circulo.png";
                Block();

                puntaje2 = puntaje2 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 2", "OK");
                scorep2.Text = "PuntajeP2 = " + puntaje2.ToString();


                Turno = 1;
            }
            else if (bot2 == 1 && bot5 == 1 && bot8 == 1)
            {
                x2y1.ImageSource = "tachawin.png";
                x2y2.ImageSource = "tachawin.png";
                x2y3.ImageSource = "tachawin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "tacha.png";
                Block();

                puntaje1 = puntaje1 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 1", "OK");
                scorep1.Text = "PuntajeP1 = " + puntaje1.ToString();


                Turno = 0;
            }
            else if (bot2 == 2 && bot5 == 2 && bot8 == 2)
            {
                x2y1.ImageSource = "circulowin.png";
                x2y2.ImageSource = "circulowin.png";
                x2y3.ImageSource = "circulowin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "circulo.png";
                Block();

                puntaje2 = puntaje2 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 2", "OK");
                scorep2.Text = "PuntajeP2 = " + puntaje2.ToString();


                Turno = 1;
            }
            else if (bot3 == 1 && bot6 == 1 && bot9 == 1)
            {
                x3y1.ImageSource = "tachawin.png";
                x3y2.ImageSource = "tachawin.png";
                x3y3.ImageSource = "tachawin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "tacha.png";
                Block();

                puntaje1 = puntaje1 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 1", "OK");
                scorep1.Text = "PuntajeP1 = " + puntaje1.ToString();


                Turno = 0;
            }
            else if (bot3 == 2 && bot6 == 2 && bot9 == 2)
            {
                x3y1.ImageSource = "circulowin.png";
                x3y2.ImageSource = "circulowin.png";
                x3y3.ImageSource = "circulowin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "circulo.png";
                Block();

                puntaje2 = puntaje2 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 2", "OK");
                scorep2.Text = "PuntajeP2 = " + puntaje2.ToString();


                Turno = 1;
            }
            else if (bot1 == 1 && bot5 == 1 && bot9 == 1)
            {
                x1y1.ImageSource = "tachawin.png";
                x2y2.ImageSource = "tachawin.png";
                x3y3.ImageSource = "tachawin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "tacha.png";
                Block();

                puntaje1 = puntaje1 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 1", "OK");
                scorep1.Text = "PuntajeP1 = " + puntaje1.ToString();


                Turno = 0;
            }
            else if (bot1 == 2 && bot5 == 2 && bot9 == 2)
            {
                x1y1.ImageSource = "circulowin.png";
                x2y2.ImageSource = "circulowin.png";
                x3y3.ImageSource = "circulowin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "circulo.png";
                Block();

                puntaje2 = puntaje2 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 2", "OK");
                scorep2.Text = "PuntajeP2 = " + puntaje2.ToString();


                Turno = 1;
            }
            else if (bot3 == 1 && bot5 == 1 && bot7 == 1)
            {
                x1y3.ImageSource = "tachawin.png";
                x2y2.ImageSource = "tachawin.png";
                x3y1.ImageSource = "tachawin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "tacha.png";
                Block();

                puntaje1 = puntaje1 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 1", "OK");
                scorep1.Text = "PuntajeP1 = " + puntaje1.ToString();



                Turno = 0;
            }
            else if (bot3 == 2 && bot5 == 2 && bot7 == 2)
            {
                x1y3.ImageSource = "circulowin.png";
                x2y2.ImageSource = "circulowin.png";
                x3y1.ImageSource = "circulowin.png";
                gato.ImageSource = "catowin.png";
                jugadorenjuego.Source = "circulo.png";
                Block();

                puntaje2 = puntaje2 + 1;
                DisplayAlert("Felicidades", "Gano el Jugador 2", "OK");
                scorep2.Text = "PuntajeP2 = " + puntaje2.ToString();


                Turno = 1;
            }
            else if (bot1 != 0 && bot2 != 0 && bot3 != 0 && bot4 != 0 && bot5 != 0 && bot6 != 0 && bot7 != 0 && bot8 != 0 && bot9 != 0)
            {
                DisplayAlert("Empate", "El resultado fue empate", "OK");
                gato.IsEnabled = true;
            }
            else
            {

            }

        }
        public void Block()
        {
            x1y1.IsEnabled = false;
            x1y2.IsEnabled = false;
            x1y3.IsEnabled = false;
            x2y1.IsEnabled = false;
            x2y2.IsEnabled = false;
            x2y3.IsEnabled = false;
            x3y1.IsEnabled = false;
            x3y2.IsEnabled = false;
            x3y3.IsEnabled = false;
            gato.IsEnabled = true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            x1y1.IsEnabled = true;
            x1y2.IsEnabled = true;
            x1y3.IsEnabled = true;
            x2y1.IsEnabled = true;
            x2y2.IsEnabled = true;
            x2y3.IsEnabled = true;
            x3y1.IsEnabled = true;
            x3y2.IsEnabled = true;
            x3y3.IsEnabled = true;
            x1y1.ImageSource = "blacky32.png";
            x2y1.ImageSource = "blacky32.png";
            x3y1.ImageSource = "blacky32.png";
            x1y2.ImageSource = "blacky32.png";
            x2y2.ImageSource = "blacky32.png";
            x3y2.ImageSource = "blacky32.png";
            x1y3.ImageSource = "blacky32.png";
            x2y3.ImageSource = "blacky32.png";
            x3y3.ImageSource = "blacky32.png";
            bot1 = 0;
            bot2 = 0;
            bot3 = 0;
            bot4 = 0;
            bot5 = 0;
            bot6 = 0;
            bot7 = 0;
            bot8 = 0;
            bot9 = 0;
            gato.IsEnabled = false;
            gato.ImageSource = "cato.png";

        }

    }

}
