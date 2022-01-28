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
using SpreadsheetLight;

namespace GeneradorProyectosDesgarga
{
    public partial class FrmSeleccionarUbicacion_PD : Form
    {
        string DireccionDirectorio;
        public FrmSeleccionarUbicacion_PD()
        {
            InitializeComponent();
            DireccionDirectorio = "";
        }


        private void BtnSeleccionar_Click_1(object sender, EventArgs e)
        {
            // Para seleccionar la Ubicación del Directorio
            FolderBrowserDialog Ubicacion = new FolderBrowserDialog();
            if (Ubicacion.ShowDialog() == DialogResult.OK)
            {
                TxtUbicacion.Text = Ubicacion.SelectedPath;
                this.DireccionDirectorio = TxtUbicacion.Text;
            }
            else
            {
                MessageBox.Show("La ruta es Inaccesible");
            }


            if (TxtUbicacion.Text == "")
            {
                BtnAceptar.Enabled = false;
            }
            else
            {
                BtnAceptar.Enabled = true;
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Metodo para Mandar llamar a la Clase Directorio y crearlos 
            if (TxtUbicacion.Text == "")
            {
                MessageBox.Show("No se ha Seleccionado una Ubicación");
            }
            else
            {
                if (Directory.Exists(TxtUbicacion.Text))
                {
                    Directorio_PD mDirectorio_PD = new Directorio_PD(this.DireccionDirectorio);

                    //Ejemplo para Probar
                    //this.llenarLista();

                    mDirectorio_PD.CrearDirectorios();
                    MessageBox.Show("El Directorio ha sido Creado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("{0} No es un Directorio Válido", TxtUbicacion.Text);
                }
            }
        }

        /*private void llenarLista() {
            //Para probar el Sistema
            //Inicializamos la lista en vacio
            Listas.ListaProyectos = new List<Proyecto>();

            //Creamos un registro de proyecto
            Proyecto mPro1 =
                new Proyecto("Daniel Arredondo", "Acreditación");
            //Agregamos ese registro a la lista de instrumentaciones
            Listas.ListaProyectos.Add(mPro1);

            Proyecto mPro3 =
                new Proyecto("Manuel Ignacio Salas", "Curso Arduino");
            Listas.ListaProyectos.Add(mPro3);

            //Creamos un registro de proyecto
            Proyecto mPro4 =
                new Proyecto("Daniel Arredondo", " Capacitación CDC");
            //Agregamos ese registro a la lista de instrumentaciones
            Listas.ListaProyectos.Add(mPro4);

            Proyecto mPro2 =
                new Proyecto("Manuel Ignacio Salas", "Tutorías");
            Listas.ListaProyectos.Add(mPro2);

            Proyecto mPro5 =
                new Proyecto("Daniel Arredondo", "Robótica");
            //Agregamos ese registro a la lista de instrumentaciones
            Listas.ListaProyectos.Add(mPro5);

        
        }*/
    }
}
