using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LectorInstrumentacionAvance;
using LectorProyectosDescarga;

namespace DossierTec
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmSeleccionarInstrumentacion form = new FrmSeleccionarInstrumentacion();
            form.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmSeleccionarProyectos form = new FrmSeleccionarProyectos();
            form.ShowDialog();
        }

        private void instrumentaicionesYAvanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmSeleccionarInstrumentacion());
        }

        private void proyectosDeDescargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmSeleccionarProyectos());
        }

        private void BtnInstrumentacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmSeleccionarInstrumentacion());
        }

        private void BtnProyectos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmSeleccionarProyectos());
        }

        public Form FormActivo = null;
        public void AbrirFormulario(Form FormHijo)
        {
            if (FormActivo != null)
            {
                FormActivo.Close();
            }
            FormActivo = FormHijo;
            FormActivo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            PnlPrincipal.Controls.Add(FormHijo);
            PnlPrincipal.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }
    }
}
