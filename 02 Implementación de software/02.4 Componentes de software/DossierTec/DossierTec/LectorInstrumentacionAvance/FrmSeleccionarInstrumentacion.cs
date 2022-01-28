using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SpreadsheetLight;
using ListasInformacion;
using GeneradorInstrumentacionAvance;

namespace LectorInstrumentacionAvance
{
    public partial class FrmSeleccionarInstrumentacion : Form
    {
        string DireccionArchivo; // Para almacenar la direccion del archivo seleccionado
        public FrmSeleccionarInstrumentacion()
        {
            InitializeComponent();
            DireccionArchivo = "";
        }

    

        private void FrmSeleccionar_Load(object sender, EventArgs e)
        {
            BtnCargar.Enabled = false;
            BtnGenerar.Enabled = false;
            PbCarga.Visible = false;
            lblCargando.Text = "";
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
                this.DireccionArchivo = TxtArchivo.Text;
            }
            if (TxtArchivo.Text == "")
            {
                BtnCargar.Enabled = false;
            }
            else
            {
                BtnCargar.Enabled = true;
                BtnGenerar.Enabled = false;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            NuevaCarga();
            Archivo mArchivo = new Archivo(DireccionArchivo);
            if (mArchivo.AbrirArchivo())
            {

                float porcentaje = 0;
                SLDocument libro;
                libro = new SLDocument(DireccionArchivo);
                string[] hojas = libro.GetWorksheetNames().ToArray();
                PbCarga.Maximum = hojas.Length;
                float carga = 100 / (hojas.Length);
                for (int i = 0; i < hojas.Length; i++)
                {
                    if (hojas[i] == "Docentes") continue;
                    porcentaje = porcentaje + carga;
                    BtnSeleccionar.Enabled = false;

                    if (mArchivo.LeerArchivo(hojas[i]))
                    {
                        lblCargando.Text = "cargando.." + porcentaje + "%";
                        this.Text = "cargando... " + porcentaje + "%";
                        lblHojas.Text = "Hojas leidas: " + i;
                        PbCarga.PerformStep();
                    }
                }
                FinCarga();
            }
            else
            {
                ArchivoCorrupto();
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void NuevaCarga()
        {
            this.Text = "Cargando...";
            lblCargando.Text = "Cargando...";
            lblCargando.Visible = true;
            PbCarga.Value = 0;
            PbCarga.Visible = true;
            BtnSeleccionar.Enabled = false;
            BtnCargar.Enabled = false;
            BtnGenerar.Enabled = false;
        }
        public void FinCarga()
        {
            this.Text = "Selecionar Archivo";
            PbCarga.Value = PbCarga.Maximum;
            BtnCargar.Enabled = false;
            BtnSeleccionar.Enabled = true;
            BtnGenerar.Enabled = true;
            DgvLista.DataSource = Listas.ListaInstrumentaciones;
            lblCargando.Text = "Carga Completada";
            BtnCancelar.Enabled = true;
        }
        public void ArchivoCorrupto()
        {
            lblCargando.Text = "Error en el archivo";
            PbCarga.Value = PbCarga.Maximum;
            lblHojas.Text = "Hojas leidas: 0";
            BtnSeleccionar.Enabled = true;
            this.Text = "Selecionar Archivo";
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            //Mostrar el formulario para seleccionar la ubicacion
            FrmSeleccionarUbicacion mFrmSeleccionar = new FrmSeleccionarUbicacion();
            mFrmSeleccionar.ShowDialog();
        }
    }
}
