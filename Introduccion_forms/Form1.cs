using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Introduccion_forms
{
    public partial class Form1 : Form
    {
        private List<string> listEstudiantes = new List<string>();
        public Form1()
        {
            InitializeComponent();
            lblEstudiantes.Text = "Estudiantes:" +"\n";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string carnet = txtcarnet.Text.Trim();
            string carrera = txtCarrera.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCarrera.Focus();
                return;
            }
            if (carnet.Length != 7)
            {
                MessageBox.Show("El carnet debe tener 7 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcarnet.Focus();
                return;
            }

            if (string.IsNullOrEmpty(carrera))
            {
                MessageBox.Show("La carrera esta vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCarrera.Focus();
                return;
            }

            string nuevoEstudiante = "\n" + "Nombre: " + nombre + "    Carnet: " + carnet + "    Carrera: " + carrera;
            listEstudiantes.Add(nuevoEstudiante);

            ActualizarListEstudiantes();

        }

        private void ActualizarListEstudiantes()
        {
            lblEstudiantes.Text = "Estudiantes: " + listEstudiantes.Count;

            foreach (string estudiante in listEstudiantes)
            {
                lblEstudiantes.Text += estudiante + "\n";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtnombre.Clear();
            txtcarnet.Clear();
            txtCarrera.Clear();

            lblEstudiantes.Text = "Estudiantes:" + "\n";
            listEstudiantes.Clear();
            txtnombre.Focus();
        }
    }
}
