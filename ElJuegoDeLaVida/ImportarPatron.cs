using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElJuegoDeLaVida
{

    // Formulario para importar patrones predefinidos al juego
    public partial class ImportarPatron : Form
    {
        private List<Patron> patrones = GestorPatrones.ObtenerPatrones();
        private FormJuego formjuego;

        public ImportarPatron(FormJuego formJuego)
        {
            InitializeComponent();
            this.formjuego = formJuego;
            MostrarPatrones(patrones);
            lblInformacion.Hide();
        }

        // Muestra los patrones en la lista del formulario
        private void MostrarPatrones(List<Patron> patrones)
        {
            listPatrones.Items.Clear();

            foreach (Patron patron in patrones)
            {
                listPatrones.Items.Add(patron);
            }
        }


        // Muestra información detallada del patrón seleccionado
        private void listPatrones_SelectedIndexChanged(object sender, 
            EventArgs e)
        {
            Patron seleccionado = (Patron)listPatrones.SelectedItem;

            if (seleccionado != null)
            {
                lblNombre.Text = seleccionado.Nombre;

                if (seleccionado is Oscilador)
                {
                    lblInformacion.Show();

                    lblInformacion.Text =
                        "Generaciones para repetir dibujo: " +
                        ((Oscilador)seleccionado).Generaciones;
                }

                else if (seleccionado is NaveEspacial)
                {
                    lblInformacion.Show();

                    lblInformacion.Text =
                        ((NaveEspacial)seleccionado).Descripcion;
                }

                else if (seleccionado is Matusalen)
                {
                    lblInformacion.Show();

                    lblInformacion.Text =
                        "Generaciones para estabilizarse: " +
                        ((Matusalen)seleccionado).Generaciones;
                }

                else
                {
                    lblInformacion.Hide();
                }
            }
        }


        // Importa el patrón seleccionado al juego y cierra el formulario
        private void button1_Click(object sender, EventArgs e)
        {
            Patron patronSeleccionado = (Patron)listPatrones.SelectedItem;

            if (patronSeleccionado != null)
            {
                formjuego.Importar(patronSeleccionado);
                this.Close();
            }
        }
    }
}
