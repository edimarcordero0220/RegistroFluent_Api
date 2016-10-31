using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace RegistroFluent_Api
{
    public partial class Detalles : Form
    {
        private Grupos grupo = new Grupos();
        public Detalles()
        {
            InitializeComponent();
            EstudiantescomboBox.DataSource = EstudiantesBLL.GetLista();
            EstudiantescomboBox.ValueMember = "IDEstudiante";
            //EstudiantescomboBox.ValueMember = "NombreGrupo";
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            GrupoBLL.Buscar(Convert.ToInt32(IdtextBox.Text));
            if (grupo != null)
            {
                NombreGrupotextBox.Text = grupo.NombreGrupo;
            }

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            grupo.IdGrupo = Convert.ToInt32(IdtextBox.Text);
            grupo.NombreGrupo = NombreGrupotextBox.Text;
            GrupoBLL.Guardar(grupo);
        }
        private void CargaEst(List<Estudiantes>lista)
        {
            List<Estudiantes> estudiante = new List<Estudiantes>();
            foreach(Estudiantes estudiant in lista)
            {
                estudiante.Add(EstudiantesBLL.Buscar(estudiant.IdEstudiante));
            }
            EstudiantedataGridView.DataSource = null;
            EstudiantedataGridView.DataSource = estudiante;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = new Estudiantes();
            grupo.Estudiante.Add(estudiante);
            EstudiantedataGridView.DataSource = null;
            EstudiantedataGridView.DataSource = grupo.Estudiante;
        }
    }
}
