using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace GeneradorInstrumentacionAvance
{
    public partial class FrmSeleccionarUbicacion : Form
    {
        string DireccionDirectorio;
        public FrmSeleccionarUbicacion()
        {
            InitializeComponent();
            DireccionDirectorio = "";

        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Metodo para Mandar llamar a la Clase Directorio y crearlos 
            if (TxtDireccion.Text == "")
            {
                MessageBox.Show("No se ha Seleccionado una Ubicación");
            }
            else
            {
                if (Directory.Exists(TxtDireccion.Text))
                {
                    Directorio mDirectorio = new Directorio(this.DireccionDirectorio);

                    //Ejemplo para Probar
                    // this.llenarLista();

                    mDirectorio.CreacionDirectorios();
                    MessageBox.Show("El Directorio ha sido Creado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("{0} No es un Directorio Válido", TxtDireccion.Text);
                }
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            // Para seleccionar la Ubicación del Directorio
            FolderBrowserDialog Ubicacion = new FolderBrowserDialog();
            if (Ubicacion.ShowDialog() == DialogResult.OK)
            {
                TxtDireccion.Text = Ubicacion.SelectedPath;
                this.DireccionDirectorio = TxtDireccion.Text;
            }
            else
            {
                MessageBox.Show("La ruta es Inaccesible");
            }


            if (TxtDireccion.Text == "")
            {
                BtnAceptar.Enabled = false;
            }
            else
            {
                BtnAceptar.Enabled = true;
            }
        }

        //Ejemplo para Probar con una Lista
        /*private void llenarLista() {
            Archivo mArchivo = new Archivo();
            string[] hojas = { "ISC", "TICS", "IA", "IGE", "IEM", "CP", "IIA", "CP_S1", "CP_S2", "IA_S1", "IA_S2", "EaD_IA_S1", 
                "EaD_IA_S2", "EaD_CP_S1", "EaD_CP_S2", "EaD_ISC_S1", "EaD_ISC_S2" };
            for (int i = 0; i < hojas.Length; i++)
            {
                mArchivo.LeerArchivo(hojas[i]);
            }

        }*/
    }
}
