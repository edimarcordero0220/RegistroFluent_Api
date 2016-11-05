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
        public void LlenarClase(Grupos gr)
        {
            //grupo.IdGrupo = Convert.ToInt32(IdtextBox.Text);
            gr.NombreGrupo = NombreGrupotextBox.Text;
        }

        private void RegitrarGrupos_Load(object sender, EventArgs e)
        {

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
            if (ValidarId("Ingresa el Id") && ValidarBuscar())
                LlenarClase(GrupoBLL.Buscar(String(IdtextBox.Text)));

        }
    }
}
