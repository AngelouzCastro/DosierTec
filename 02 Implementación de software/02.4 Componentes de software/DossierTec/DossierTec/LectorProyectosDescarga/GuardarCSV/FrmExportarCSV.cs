using ListasInformacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardarCSV
{
    public partial class FrmGenerarArchivoCsv : Form
    {
        private ArchivoCsv mArchivoCsv;
        public FrmGenerarArchivoCsv()
        {
            InitializeComponent();
            mArchivoCsv = new ArchivoCsv();
        }

        private void FrmGenerarArchivoCsv_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Ubicacion = new FolderBrowserDialog();
            if (Ubicacion.ShowDialog() == DialogResult.OK)
            {
                string Ruta = Ubicacion.SelectedPath + @"\proyectos_de_descarga.csv";
                mArchivoCsv.crearArchivoCsv(Listas.ListaProyectos, Ruta);
                MessageBox.Show("Se a creado el archivo exitosamente en "+ Ruta);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo crear el archivo!");
                this.Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
