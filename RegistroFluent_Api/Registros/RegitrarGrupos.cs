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
    }
}
