using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;


namespace RegistroFluent_Api.Registros
{
    public partial class RegistrarEstudiantes : Form
    {
        public RegistrarEstudiantes()
        {
            InitializeComponent();
        }
        public void LlenarClase(Entidades.Estudiantes estudiante)
        {
            //estudiante.IdEstudiante = Convert.ToInt32(IdtextBox.Text);
            estudiante.EstudianteNombre = NombretextBox.Text;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = new Estudiantes();
            LlenarClase(estudiante);
            EstudiantesBLL.Guardar(estudiante);
            MessageBox.Show("Guardado");
        }
    }
}
