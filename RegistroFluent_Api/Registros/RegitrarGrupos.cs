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
    public partial class RegitrarGrupos : Form
    {
        public RegitrarGrupos()
        {
            InitializeComponent();
        }
        
        Grupos grupo = new Grupos();
        Util u = new Util();
        public void LlenarClase(Grupos gr)

        {
            
            gr.Nombre = NombreGrupotextBox.Text;
        }

        private void Pasar(Grupos gr)
        {
            var g = GrupoBLL.Buscar(u.StringToInt(IdtextBox.Text));
            IdtextBox.Text = gr.GrupoId.ToString();
            NombreGrupotextBox.Text = gr.Nombre;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gr.Estudiante;
        }
        private void Llenar(Grupos grups)
        {
            var grup = GrupoBLL.Buscar(u.StringToInt(IdtextBox.Text));
            IdtextBox.Text = grups.GrupoId.ToString();
            NombreGrupotextBox.Text = grups.Nombre;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = grup.GrupoId;

        }

        private void RegitrarGrupos_Load(object sender, EventArgs e)
        {
           
            LlenandoCombo();
        }

        private void LlenandoCombo()
        {
            grupo = new Grupos();
            EstudiantecomboBox.DataSource = EstudiantesBLL.GetLista();
            EstudiantecomboBox.ValueMember = "EstudianteId";
            EstudiantecomboBox.DisplayMember = "Nombres";
        }

        private void IdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Grupos grupito = new Grupos();
            LlenarClase(grupito);
            GrupoBLL.Guardar(grupito);
            MessageBox.Show("Guardado");
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            VaciarTexbox();
            
        }

        public void VaciarTexbox()
        {
            IdtextBox.Clear();
            NombreGrupotextBox.Clear();
            


        }

        
        private bool ValidarId(string message)
        {
            if (string.IsNullOrEmpty(IdtextBox.Text))
            {
                errorProvider2.SetError(IdtextBox, "Ingresar Id!!");
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

        public int String(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            if (ValidarId("Ingrese Id del Usuario") && ValidarBuscar())
            {
                EstudiantesBLL.Eliminar(String(IdtextBox.Text));

                VaciarTexbox();
                MessageBox.Show("Eliminacion con Exitosa");
            }

        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            Llenar(GrupoBLL.Buscar(u.StringToInt(IdtextBox.Text)));
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            grupo.Estudiante.Add(new Estudiantes((int)EstudiantecomboBox.SelectedValue, EstudiantecomboBox.Text));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = grupo.Estudiante;
            EstudiantecomboBox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EstudiantecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
