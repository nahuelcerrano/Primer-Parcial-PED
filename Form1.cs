namespace juego_num_aleatorios
{
    public partial class Form1 : Form
    {
        //------------------VARIABLE GLOBALES-----------------------//

        private int intentosRestantes;          //Intentos restantes que tiene el jugador
        private int intentosContador = 0;       //Contador de intentos para la grilla
        private int tiempoRestante;             //Contador para el timer
        private int numeroRand;                 //El número creado aleatoriamente
        private int numeroJugador;              //El numero que ingresa el jugador
        private int puntajeJg = 0;              //Puntaje del jugador
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        //------------------TIMER-----------------------//
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--;

                //Tiempo restante
                label6.Text = tiempoRestante.ToString();
            }
            else if (tiempoRestante == 0)  //Si se queda sin tiempo
            {
                timer1.Stop();

                dataGridView1.Rows.Add(intentosContador, numeroJugador, numeroRand);

                //Se habilitan botones, scrolls y label
                label8.Visible = true;
                hScrollBar2.Enabled = true;
                button1.Enabled = true;

                //Se deshabilita el botón de intentos
                button2.Enabled = false;

                intentosContador = 0;
            }
        }

        //------------------BOTÓN DE INICIAR-----------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            //Intentos
            intentosRestantes = hScrollBar1.Value;

            //Tiempo Restante
            tiempoRestante = hScrollBar2.Value;


            //Seteo de interval en 1 seg
            timer1.Interval = 1000;

            timer1.Start();

            //Visibilidad de labels
            label8.Visible = false;
            label9.Visible = false;

            //Habilitar boton intentar
            button2.Enabled = true;

            //Deshabilitar boton iniciar
            button1.Enabled = false;

            //Deshabilitar scrolls
            hScrollBar1.Enabled = false;
            hScrollBar2.Enabled = false;


            //Seleccion de dificultad
            if (radioButton1.Checked)
            {
                numeroRand = r.Next(1, 11);
            }
            else if (radioButton2.Checked)
            {
                numeroRand = r.Next(1, 51);
            }
            else if (radioButton3.Checked)
            {
                numeroRand = r.Next(1, 101);
            }

        }

        //------------------BOTÓN DE INTENTAR-----------------------//
        private void button2_Click_1(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Por favor ingrese un número");
                return;
            }
            
            numeroJugador = Convert.ToInt32(textBox1.Text);

            //Verifica si el jugador acertó o no

            if (numeroJugador != numeroRand)
            {
                intentosRestantes--;
                label7.Text = intentosRestantes.ToString();
                intentosContador++;
            }
            else //Si gana
            {
                timer1.Stop();
                hScrollBar1.Enabled = true;
                hScrollBar2.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = false;
                dataGridView1.Rows.Add(intentosContador, numeroJugador, numeroRand);
                intentosContador = 0;
                puntajeJg++;
                label12.Text = puntajeJg.ToString();
            }

            //Verifica si el jugador se quedó sin intentos

            if (intentosRestantes == 0) //Si se queda sin intentos
            {
                timer1.Stop();
                hScrollBar1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = false;
                dataGridView1.Rows.Add(intentosContador, numeroJugador, numeroRand);
                label9.Visible = true;
                intentosContador = 0;
            }

            if (checkBox1.Checked)
            {
                if (numeroRand > numeroJugador)
                {
                    label3.Text = "El número es mayor";
                }
                else
                {
                    label3.Text = "El número es menor";
                }
            }
        }

        //------------------BOTÓN DE RECURSIVA-----------------------//
        private void button3_Click(object sender, EventArgs e)
        {
            string pares = recursivaParesJuego(0);

            MessageBox.Show($"Números pares del jugador:{pares}");

        }

        //------------------SCROLLS DE INTENTOS Y TIEMPO-----------------------//
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label7.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label6.Text = hScrollBar2.Value.ToString();
        }

        //------------------FUNCIÓN RECURSIVA-----------------------//
        private string recursivaParesJuego(int n)
        {
            string pares = String.Empty;
            string auxPares = String.Empty;

            DataGridView filas = dataGridView1;

            if (n >= filas.Rows.Count - 1)
            {
                pares = "";
            }
            else
            {
                if (Convert.ToInt32(filas.Rows[n].Cells[1].Value) % 2 == 0)
                {
                    auxPares = filas.Rows[n].Cells[1].Value.ToString();
                }

                pares = $"{auxPares} {recursivaParesJuego(n + 1)}";
            }

            return pares;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
