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

namespace RegistroFluent_Api.Consultas
{
    public partial class ConsultarEstudiante : Form
    {
        Grupos grupo = new Grupos();
         
        public ConsultarEstudiante()
        {
            InitializeComponent();
        }
        Util u = new Util();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var grupo = EstudiantesBLL.Buscar(u.StringToInt(BuscartextBox.Text));
            
        }
        private void cargarEstudianteGrupo(List<Estudiantes> lista)
        {
            var estudiantes = new List<Estudiantes>();
            foreach (Estudiantes est in lista)
            {
                estudiantes.Add(BLL.EstudiantesBLL.Buscar(est.IdEstudiante));
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = estudiantes;
        }
    }
}
