using PromediosAlumnos.Entidades;
using PromediosAlumnos.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromediosAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string Materia;

            ClsAlumno datos = new ClsAlumno();
            Materia = txtAsignatura.Text;
            datos.Nombre = txtNombre.Text;
            datos.Apellido = txtApellido.Text;
            datos.Lab1 = double.Parse(txtNotalab1.Text);
            datos.Lab2 = double.Parse(txtNotalab2.Text);
            datos.Lab3 = double.Parse(txtNotaLab3.Text);
            datos.Parcial1 = double.Parse(txtNotaparcial1.Text);
            datos.Parcial2 = double.Parse(txtNotaparcial2.Text);
            datos.Parcial3 = double.Parse(txtNotaparcial3.Text);
            
            NClsDatos logic = new NClsDatos();
            MessageBox.Show("Estas son sus notas en la Asignatura de: " + Materia + logic.Calculo(datos));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtAsignatura.Clear();
            txtNotalab1.Clear();
            txtNotalab2.Clear();
            txtNotaLab3.Clear();
            txtNotaparcial1.Clear();
            txtNotaparcial2.Clear();
            txtNotaparcial3.Clear();

        }
    }
}
