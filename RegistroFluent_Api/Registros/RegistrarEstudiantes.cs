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
using RegistroFluent_Api.Registros;


namespace RegistroFluent_Api.Registros
{
    public partial class RegistrarEstudiantes : Form
    {
        Estudiantes Es = new Estudiantes();
        Util u = new Util();
        public RegistrarEstudiantes()
        {
            InitializeComponent();
        }
        public void LlenarClase(Entidades.Estudiantes estudiante)
        {
            
            estudiante.Nombre = NombretextBox.Text;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = new Estudiantes();
            LlenarClase(estudiante);
            EstudiantesBLL.Guardar(estudiante);
            MessageBox.Show("Guardado");
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            VaciarTexbox();
        }

        public void VaciarTexbox()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarId("Ingrese Id del Usuario")&& ValidarBuscar() )
            {
                

                VaciarTexbox();
                MessageBox.Show("Eliminacion con Exitosa");
            }
        }
        private bool ValidarId(string message)
        {
            if (string.IsNullOrEmpty(IdtextBox.Text))
            {
                errorProvider1.SetError(IdtextBox, "Ingresar Id!!");
                MessageBox.Show(message);
                return false;
            }
            else
            {

                return true;
            }
        }
        private bool ValidarBuscar()
        {
            if (EstudiantesBLL.Buscar(String(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;

            }

            return true;


        }
        private void Llenar(Estudiantes Est)
        {
            var Estu = EstudiantesBLL.Buscar(u.StringToInt(IdtextBox.Text));
            IdtextBox.Text = Est.EstudianteId.ToString();
            NombretextBox.Text = Est.Nombre;
            EstudiantedataGridView.DataSource = null;
            EstudiantedataGridView.DataSource = Est.EstudianteId;

        }
        private void RegitrarGrupos_Load(object sender, EventArgs e)
        {

            LlenandoCombo();
        }

        private void LlenandoCombo()
        {
            Es = new Estudiantes();
            EstudiantecomboBox.DataSource = GrupoBLL.GetLista();
            EstudiantecomboBox.ValueMember = "EstudianteId";
            EstudiantecomboBox.DisplayMember = "Nombres";
        }

        public int String(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarId("Ingresa el Id") && ValidarBuscar())
                LlenarClase(EstudiantesBLL.Buscar(String(IdtextBox.Text)));
        }

        private void agregarbutton_Click(object sender, EventArgs e)
        {
            Es.Grupo.Add(new Grupos((int)EstudiantecomboBox.SelectedValue, EstudiantecomboBox.Text));
            EstudiantedataGridView.DataSource = null;
            EstudiantedataGridView.DataSource = Es.Grupo;
            EstudiantecomboBox.Text = "";
        }
    }
}
