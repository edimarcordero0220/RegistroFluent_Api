using RegistroFluent_Api.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroFluent_Api
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarEstudiantes Re = new RegistrarEstudiantes();
            Re.MdiParent = this.MdiParent;
            Re.Show(); 
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegitrarGrupos Re = new RegitrarGrupos();
            Re.MdiParent = this.MdiParent;
            Re.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalles de = new Detalles();
            de.MdiParent = this.MdiParent;
            de.Show();
        }
    }
}
