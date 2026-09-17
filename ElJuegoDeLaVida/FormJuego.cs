using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace ElJuegoDeLaVida
{
    public partial class FormJuego : Form
    {
        // Menu agregado para que abra al cerrar el juego
        private FormMenu menu;
        private Tablero tablero;

        public FormJuego(FormMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            tablero = new Tablero();
        }

        // Al cerrar el juego, se muestra el menú principal
        private void FormJuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        // Configura el modo nocturno o diurno al cargar el formulario
        private void FormJuego_Load(object sender, EventArgs e)
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

        // Método para dibujar el tablero y las células
        private void FormJuego_Paint(object sender, PaintEventArgs e)
        {

            // objeto Graphics para dibujar
            Graphics g = e.Graphics;

            // Calcular tamaño de cada celda adaptado a pantalla
            int tamanyoCeldaX = this.ClientSize.Width / Configuracion.COLUMNAS;
            int tamanyoCeldaY = this.ClientSize.Height / Configuracion.FILAS;
            int tamanyoCelda = Math.Min(tamanyoCeldaX, tamanyoCeldaY);

            // Calcular el tamaño total del tablero
            int tamanyoTableroX = tamanyoCelda * Configuracion.COLUMNAS;
            int tamanyoTableroY = tamanyoCelda * Configuracion.FILAS;

            // Calcular padding para centrar el tablero
            int paddingX = (this.ClientSize.Width - tamanyoTableroX) / 2;
            int paddingY = (this.ClientSize.Height - tamanyoTableroY) / 2;

            //limpiar el fondo
            g.Clear(this.BackColor);

            for (int i = 0; i < Configuracion.FILAS; i++)
            {
                for (int j = 0; j < Configuracion.COLUMNAS; j++)
                {
                    Celula celula = tablero.ObtenerCelula(i, j);
                    int x = paddingX + j * tamanyoCelda;
                    int y = paddingY + i * tamanyoCelda;

                    if (Configuracion.modoNocturno)
                    {
                        if (celula.EstaViva)
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
                    else
                    {
                        if (celula.EstaViva)
                        {
                            // Dibujar cuadro
                            g.FillRectangle(Brushes.Black, x, y, tamanyoCelda,
                                tamanyoCelda);

                            // Dibujar borde
                            g.DrawRectangle(Pens.White, x, y, tamanyoCelda,
                                tamanyoCelda);
                        }

                        else
                        {
                            // Dibujar cuadro
                            g.FillRectangle(Brushes.White, x, y, tamanyoCelda,
                                tamanyoCelda);
                            // Dibujar borde
                            g.DrawRectangle(Pens.Black, x, y, tamanyoCelda,
                                tamanyoCelda);
                        }
                    }
                }
            }
        }

        // Método para manejar el click del menú "Salir"
        private void menuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para manejar el click del menú "Simulación Manual"
        private void menuSimulacionMan_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            menuIniciar.Text = "Iniciar";
            tablero.SiguienteGeneracion();
            this.Invalidate();
        }

        // Método para manejar el click del menú "Reiniciar"
        private void menuReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            menuIniciar.Text = "Iniciar";
            tablero.ReiniciarTablero();
            this.Invalidate();
        }

        // Método para manejar el click del menú "Modo Nocturno"
        private void menuModoNocturno_Click(object sender, EventArgs e)
        {
            Configuracion.modoNocturno = !Configuracion.modoNocturno;

            if (Configuracion.modoNocturno)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = Color.Black;
            }

            this.Invalidate();
        }

        /* Metodo para manejar el click del mouse y cambiar el
        * estado de la celula correspondiente */
        private void FormJuego_MouseClick(object sender, MouseEventArgs e)
        {
            // Calcular tamaño de cada celda adaptado a pantalla
            int tamanyoCeldaX = this.ClientSize.Width / Configuracion.COLUMNAS;
            int tamanyoCeldaY = this.ClientSize.Height / Configuracion.FILAS;
            int tamanyoCelda = Math.Min(tamanyoCeldaX, tamanyoCeldaY);

            // Calcular el tamaño total del tablero
            int tamanyoTableroX = tamanyoCelda * Configuracion.COLUMNAS;
            int tamanyoTableroY = tamanyoCelda * Configuracion.FILAS;

            // Calcular padding para centrar el tablero
            int paddingX = (this.ClientSize.Width - tamanyoTableroX) / 2;
            int paddingY = (this.ClientSize.Height - tamanyoTableroY) / 2;

            int xRel = e.X - paddingX;
            int yRel = e.Y - paddingY;

            // 🔹 Comprobar si el click está dentro del tablero
            if (xRel >= 0 && yRel >= 0 &&
                xRel < tamanyoTableroX && yRel < tamanyoTableroY)
            {
                int columna = xRel / tamanyoCelda;
                int fila = yRel / tamanyoCelda;

                Celula c = tablero.ObtenerCelula(fila, columna);

                // confirma que la celda existe antes de cambiar su estado
                if (c != null)
                {
                    c.EstaViva = !c.EstaViva;
                }
                this.Invalidate();
            }
        }

        // Método para manejar el tick del timer y avanzar a la siguiente
        // generación

        private void timer1_Tick(object sender, EventArgs e)
        {
            tablero.SiguienteGeneracion();
            this.Invalidate();
        }

        // Método para mostrar las instrucciones del juego al hacer click en
        // el menú "Cómo jugar"
        private void menuComoJugar_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "El Juego de la Vida:\n\n" +
                "- Puedes hacer clic en las células (Cuadrito) para cambiar" +
                " su estado, la idea de este juego es simular la vida.\n" +
                "- Los cambios los veras generación a generación creando " +
                "patrones de lo más interesantes.\n" +
                "- Debes respetar las siguientes reglas: \n" +
                "- Una célula nace con 3 vecinos\n" +
                "- Una célula muere con menos de 2 o más de 3 vecinos\n" +
                "- Una célula sobrevive con 2 o 3 vecinos\n" +
                "¡DIVIERTETE!",
                "Cómo jugar", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        // Método para manejar el click del menú "Iniciar/Detener"
        // y controlar el timer
        private void menuIniciar_Click(object sender, EventArgs e)
        {
            // cambiar estado del timer para iniciar o detener la simulación

            if (timer1.Enabled == false)
            {
                timer1.Start();
                menuIniciar.Text = "Detener";
            }
            else
            {
                timer1.Stop();
                menuIniciar.Text = "Iniciar";
            }
        }

        // Método para manejar el click del menú "Acerca de" y abrir un enlace
        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            try
            {
                // usa using System.Diagnostics, lanza un proceso externo
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://es.wikipedia.org/wiki/Juego_de_la_vida",
                    // UseShellExecute es necesario para abrir el enlace en el
                    // navegador predeterminado
                    UseShellExecute = true
                });
            }

            catch
            {
                MessageBox.Show("No se pudo abrir el enlace. Por favor, " +
                    "visita " +
                    "https://es.wikipedia.org/wiki/Juego_de_la_vida para más " +
                    "información.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos para guardar y cargar el estado del tablero en un
        // archivo de texto
        public void Guardar(String rutaFichero)
        {
            using (StreamWriter fichero = new StreamWriter(rutaFichero))
            {
                for (int i = 0; i < Configuracion.FILAS; i++)
                {

                    for (int j = 0; j < Configuracion.COLUMNAS; j++)
                    {

                        Celula c = tablero.ObtenerCelula(i, j);

                        // guardamos las posiciones de las células vivas
                        if (c != null && c.EstaViva)
                        {
                            fichero.WriteLine(i + "," + j);
                        }
                    }
                }
            }
        }

        // Método para cargar el estado del tablero desde un archivo de texto
        public void Cargar(string rutaFichero)
        {
            string linea;
            string[] partes;

            try
            {
                tablero.ReiniciarTablero();

                using (StreamReader fichero = new StreamReader(rutaFichero))
                {
                    do
                    {
                        linea = fichero.ReadLine();
                        if (linea != null)
                        {
                            partes = linea.Split(',');
                            if (partes.Length == 2 &&
                                int.TryParse(partes[0], out int fila) &&
                                int.TryParse(partes[1], out int columna))
                            {
                                Celula c = tablero.ObtenerCelula(fila,
                                    columna);
                                if (c != null)
                                {
                                    c.EstaViva = true;
                                }
                            }
                        }
                    }
                    while (linea != null);
                }
            }

            catch
            {
                MessageBox.Show("No se pudo cargar el archivo. Por favor," +
                    " asegúrate de que el formato es correcto y que el" +
                    " archivo existe.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Invalidate();
        }

        // Métodos para manejar el click de los menús "Guardar" y "Cargar"
        private void menuGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog pestanyaGuardar = new SaveFileDialog();

            pestanyaGuardar.Title = "Guardar partida";
            pestanyaGuardar.Filter = "Archivo de texto (*.txt)|*.txt";
            pestanyaGuardar.DefaultExt = "txt";
            pestanyaGuardar.AddExtension = true;

            if (pestanyaGuardar.ShowDialog() == DialogResult.OK)
            {
                Guardar(pestanyaGuardar.FileName);
            }
        }

        // Método para manejar el click del menú "Cargar" y
        // abrir un diálogo para seleccionar el archivo
        private void menuCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog pestanyaCargar = new OpenFileDialog();

            pestanyaCargar.Title = "Cargar partida";
            pestanyaCargar.Filter = "Archivo de texto (*.txt)|*.txt";

            if (pestanyaCargar.ShowDialog() == DialogResult.OK)
            {
                Cargar(pestanyaCargar.FileName);
            }
        }

        // Método para manejar el evento de cierre del formulario y preguntar
        // alusuario si desea guardar la partida antes de salir
        private void FormJuego_FormClosing(object sender, FormClosingEventArgs
            e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas guardar tu " +
                "partida antes de salir?", "Guardar partida",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                SaveFileDialog pestanyaGuardar = new SaveFileDialog();

                pestanyaGuardar.Title = "Guardar partida";
                pestanyaGuardar.Filter = "Archivo de texto (*.txt)|*.txt";
                pestanyaGuardar.DefaultExt = "txt";
                pestanyaGuardar.AddExtension = true;

                if (pestanyaGuardar.ShowDialog() == DialogResult.OK)
                {
                    Guardar(pestanyaGuardar.FileName);
                }

                // si el usuario cancela el guardado no se cierra el juego
                else
                {
                    e.Cancel = true;
                }
            }

            else if (resultado == DialogResult.Cancel)
            {
                // si cancela no se cierra el juego
                e.Cancel = true;
            }
        }

        private void importarPatronToolStripMenuItem_Click(object sender,
            EventArgs e)
        {
            ImportarPatron importarPatron = new ImportarPatron(this);
            importarPatron.ShowDialog();
        }

        // Método para importar un patrón de células desde un objeto Patron
        internal void Importar(Patron patron)
        {
            tablero.ReiniciarTablero();

            for (int i = 0; i < Configuracion.FILAS; i++)
            {
                for (int j = 0; j < Configuracion.COLUMNAS; j++)
                {
                    Celula origen =
                        patron.Disenyo.ObtenerCelula(i, j);

                    Celula destino =
                        tablero.ObtenerCelula(i, j);

                    if (origen != null && destino != null)
                    {
                        destino.EstaViva = origen.EstaViva;
                    }
                }
            }

            this.Invalidate();
        }

        private void avanzarGeneraciónToolStripMenuItem_Click(object sender,
            EventArgs e)
        {
            timer1.Stop();
            menuIniciar.Text = "Iniciar";
            tablero.SiguienteGeneracion();
            this.Invalidate();
        }
    }
}
