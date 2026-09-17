using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElJuegoDeLaVida
{
    public partial class FormMenu : Form
    {
        public bool modoNocturno = Configuracion.modoNocturno;
        private Tablero transiciones;

        public FormMenu()
        {
            InitializeComponent();
        }

        // iniciar juego y oculta el menú
        private void button1_Click(object sender, EventArgs e)
        {
            FormJuego juego = new FormJuego(this);
            juego.Show();

            // (oculta el menú)
            this.Hide();
        }

        // cargar partida y oculta el menú
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog pestanyaCargar = new OpenFileDialog();

            pestanyaCargar.Title = "Cargar partida";
            pestanyaCargar.Filter = "Archivo de texto (*.txt)|*.txt";

            if (pestanyaCargar.ShowDialog() == DialogResult.OK)
            {
                FormJuego juego = new FormJuego(this);

                juego.Show();
                juego.Cargar(pestanyaCargar.FileName);

                this.Hide();
            }
        }

        // muestra información sobre el juego
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "El Juego de la Vida:\n\n" +
                "- Puedes hacer clic en las células (Cuadrito) para cambiar" +
                " su estado, la idea de este juego es simular la vida.\n" +
                "- Los cambios los verás generación a generación creando " +
                "patrones de lo más interesantes.\n" +
                "- Debes respetar las siguientes reglas: \n" +
                "- Una célula nace con 3 vecinos\n" +
                "- Una célula muere con menos de 2 o más de 3 vecinos\n" +
                "- Una célula sobrevive con 2 o 3 vecinos\n" +
                "¡DIVIÉRTETE!",
                "Cómo jugar", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }


        // alternar modo nocturno y modo diurno
        private void button4_Click(object sender, EventArgs e)
        {
            Configuracion.modoNocturno = !Configuracion.modoNocturno;

            AplicarModo();
        }

        // carga un tablero con transiciones para mostrar en el menú.
        private void FormMenu_Load(object sender, EventArgs e)
        {
            transiciones = new Tablero();
            // transisiones lado izquierdo
            transiciones.ObtenerCelula(13, 10).EstaViva = true;
            transiciones.ObtenerCelula(13, 11).EstaViva = true;
            transiciones.ObtenerCelula(13, 12).EstaViva = true;
            transiciones.ObtenerCelula(15, 8).EstaViva = true;
            transiciones.ObtenerCelula(16, 8).EstaViva = true;
            transiciones.ObtenerCelula(17, 8).EstaViva = true;
            transiciones.ObtenerCelula(19, 10).EstaViva = true;
            transiciones.ObtenerCelula(19, 11).EstaViva = true;
            transiciones.ObtenerCelula(19, 12).EstaViva = true;
            transiciones.ObtenerCelula(15, 14).EstaViva = true;
            transiciones.ObtenerCelula(16, 14).EstaViva = true;
            transiciones.ObtenerCelula(17, 14).EstaViva = true;
            transiciones.ObtenerCelula(15, 11).EstaViva = true;
            transiciones.ObtenerCelula(16, 11).EstaViva = true;
            transiciones.ObtenerCelula(17, 11).EstaViva = true;

            transiciones.ObtenerCelula(6, 11).EstaViva = true;
            transiciones.ObtenerCelula(6, 12).EstaViva = true;
            transiciones.ObtenerCelula(7, 10).EstaViva = true;
            transiciones.ObtenerCelula(7, 11).EstaViva = true;
            transiciones.ObtenerCelula(8, 11).EstaViva = true;

            // transisiones lado derecho
            transiciones.ObtenerCelula(13, 47).EstaViva = true;
            transiciones.ObtenerCelula(13, 48).EstaViva = true;
            transiciones.ObtenerCelula(13, 49).EstaViva = true;
            transiciones.ObtenerCelula(15, 45).EstaViva = true;
            transiciones.ObtenerCelula(16, 45).EstaViva = true;
            transiciones.ObtenerCelula(17, 45).EstaViva = true;
            transiciones.ObtenerCelula(19, 47).EstaViva = true;
            transiciones.ObtenerCelula(19, 48).EstaViva = true;
            transiciones.ObtenerCelula(19, 49).EstaViva = true;
            transiciones.ObtenerCelula(15, 51).EstaViva = true;
            transiciones.ObtenerCelula(16, 51).EstaViva = true;
            transiciones.ObtenerCelula(17, 51).EstaViva = true;
            transiciones.ObtenerCelula(15, 48).EstaViva = true;
            transiciones.ObtenerCelula(16, 48).EstaViva = true;
            transiciones.ObtenerCelula(17, 48).EstaViva = true;

            transiciones.ObtenerCelula(6, 48).EstaViva = true;
            transiciones.ObtenerCelula(6, 49).EstaViva = true;
            transiciones.ObtenerCelula(7, 47).EstaViva = true;
            transiciones.ObtenerCelula(7, 48).EstaViva = true;
            transiciones.ObtenerCelula(8, 48).EstaViva = true;
            this.Invalidate();
        }

        // aplicar el modo nocturno o diurno al menú
        private void AplicarModo()
        {
            if (Configuracion.modoNocturno)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }

        // actualizar el modo nocturno o diurno al activar el menú
        public void ActualizarModo()
        {
            if (Configuracion.modoNocturno)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }

            this.Invalidate();
        }

        // cerrar el menú
        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        // mostrar mensaje de despedida al cerrar el menú
        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("¡Gracias por jugar!", "Gracias",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // dibujar las células vivas que estan en el menú
        private void FormMenu_Paint(object sender, PaintEventArgs e)
        {
            // objeto Graphics para dibujar
            Graphics g = e.Graphics;

            // Calcular tamaño de cada celda adaptado a pantalla
            int tamanyoCeldaX = this.ClientSize.Width / Configuracion.COLUMNAS;
            int tamanyoCeldaY = this.ClientSize.Height / Configuracion.FILAS;
            int tamanyoCelda = Math.Min(tamanyoCeldaX, tamanyoCeldaY);

            //limpiar el fondo
            g.Clear(this.BackColor);

            for (int i = 0; i < Configuracion.FILAS; i++)
            {
                for (int j = 0; j < Configuracion.COLUMNAS; j++)
                {
                    Celula celula = transiciones.ObtenerCelula(i, j);
                    int x = j * tamanyoCelda;
                    int y = i * tamanyoCelda;

                    if (celula.EstaViva)
                    {
                        if (Configuracion.modoNocturno)
                        {
                            // Dibujar cuadro
                            g.FillRectangle(Brushes.White, x, y, tamanyoCelda,
                                tamanyoCelda);

                            // Dibujar borde
                            g.DrawRectangle(Pens.Gray, x, y, tamanyoCelda,
                                tamanyoCelda);
                        }
                        else
                        {
                            // Dibujar cuadro
                            g.FillRectangle(Brushes.Black, x, y, tamanyoCelda,
                                tamanyoCelda);

                            // Dibujar borde
                            g.DrawRectangle(Pens.White, x, y, tamanyoCelda,
                                tamanyoCelda);
                        }
                    }
                }
            }
        }

        // avanzar a la siguiente generación cada vez que el timer se active
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            transiciones.SiguienteGeneracion();
            this.Invalidate();
        }

        // actualizar el modo nocturno o diurno al activar el menú
        private void FormMenu_Activated(object sender, EventArgs e)
        {
            ActualizarModo();
        }
    }
}
