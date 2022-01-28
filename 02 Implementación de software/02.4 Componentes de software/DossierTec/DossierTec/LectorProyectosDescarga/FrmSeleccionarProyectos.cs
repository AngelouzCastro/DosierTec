using GeneradorProyectosDescarga;
using GuardarCSV;
using ListasInformacion;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectorProyectosDescarga
{
    public partial class FrmSeleccionarProyectos : Form
    {
        private string RutaArchivo;
        private Archivo mArchivo;
        public FrmSeleccionarProyectos()
        {
            InitializeComponent();
            BtnCargar.Enabled = false;
            BtnGenerar.Enabled = false;
            BtnGuardarCSV.Enabled = false;
            TxtArchivo.Enabled = false;
        }

        

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbrirArchivo = new OpenFileDialog();
            AbrirArchivo.Title = "Seleccionar un Archivo";
            AbrirArchivo.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; // Para evitar que se seleccionen archivos que no sean xls o xlsx 
            AbrirArchivo.FileName = this.TxtArchivo.Text;

            if (AbrirArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TxtArchivo.Text = AbrirArchivo.FileName;
                this.RutaArchivo = TxtArchivo.Text;
            }
            if (TxtArchivo.Text == "")
            {
                BtnCargar.Enabled = false;
            }
            else
            {
                BtnCargar.Enabled = true;
                BtnGenerar.Enabled = false;
                BtnGuardarCSV.Enabled = false;

            }
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            mArchivo = new Archivo();
            mArchivo.padre = this;
            mArchivo.RutaArchivo = this.RutaArchivo;
            if (mArchivo.AbrirArchivo())
            {
                mArchivo.LeerArchivo("Docentes");
                DtgLista.DataSource = Listas.ListaProyectos;
                DtgLista.AutoResizeColumns();
                BtnCargar.Enabled = false;
                BtnGenerar.Enabled = true;
                BtnGuardarCSV.Enabled = true;
                PbCarga.Value = PbCarga.Maximum;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      public void MostrarAvanceCarga()
        {
            PbCarga.PerformStep();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            //Mostrar el formulario para seleccionar la ubicacion
            FrmSeleccionarUbicacion_PD mFrmSeleccionar = new FrmSeleccionarUbicacion_PD();
            mFrmSeleccionar.ShowDialog();
        }

        private void BtnGuardarCSV_Click(object sender, EventArgs e)
        {
            FrmGenerarArchivoCsv mFrmGenerarArchivoCsv = new FrmGenerarArchivoCsv();
            mFrmGenerarArchivoCsv.ShowDialog();
        }
    }
}
