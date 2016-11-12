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
        Grupos gr = new Grupos();
        private Grupos grupo = new Grupos();
        public Detalles()
        {
            InitializeComponent();
           EstudiantescomboBox.DataSource = EstudiantesBLL.GetLista();
            EstudiantescomboBox.ValueMember = "EstudianteId";
           EstudiantescomboBox.ValueMember = "Nombre";
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            GrupoBLL.Buscar(Convert.ToInt32(IdtextBox.Text));
            if (grupo != null)
            {
                NombreGrupotextBox.Text = grupo.Nombre;
            }
            
            //IdtextBox.Text = "";

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            grupo.GrupoId = Convert.ToInt32(IdtextBox.Text);
            grupo.Nombre = NombreGrupotextBox.Text;
            GrupoBLL.Guardar(grupo);
        }
        private void CargaEst(List<Estudiantes>lista)
        {
            List<Estudiantes> estudiante = new List<Estudiantes>();
            foreach(Estudiantes estudiant in lista)
            {
                estudiante.Add(EstudiantesBLL.Buscar(estudiant.EstudianteId));
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
            EstudiantescomboBox.Text = ""; 
           
        }

        private void LlenarGruposEstudiantes(List<Estudiantes>lista)
        {
            var estudiante = new List<Estudiantes>();
            foreach(Estudiantes estu in lista)
            {
                estudiante.Add(EstudiantesBLL.Buscar(estu.EstudianteId));
            }
            EstudiantedataGridView.DataSource = null;
            EstudiantedataGridView.DataSource = estudiante;

        }

        private void Insertarbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void EstudiantedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IdtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EstudiantescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Detalles_Load(object sender, EventArgs e)
        {

        }

        private void NombreGrupotextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
