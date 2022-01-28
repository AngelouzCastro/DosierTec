using ListasInformacion;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectorProyectosDescarga
{
    public class Archivo
    {
        public string RutaArchivo { get; set; }
        SLDocument Libro;
        public FrmSeleccionarProyectos padre { get; set; }

        public Archivo(){
            RutaArchivo = "";
            Listas.ListaProyectos = new List<Proyecto>();
        }

        public bool AbrirArchivo() {
            
            try {
                Libro = new SLDocument(RutaArchivo);
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al abrir el archivo, verifique que sea un archivo válido o no esté siendo usado por otra aplicación ");
                return false;
            }
        }

        public bool LeerArchivo(string Hoja)
        {
            // try por si existe algun error en la hoja
            try {
                //por si no existe la hoja omitirla
                if (Libro.SelectWorksheet(Hoja) == true) {
                    string Docente = "";
                    string ProyectoDescarga="";
                    Proyecto mProyecto;
                    int Inicio=0;
                    int Fin = 0;
                    int j = 1;
                    while (true) {
                        if (Libro.GetCellValueAsString(1,j).ToUpper().Trim() == "PROYECTOS") {
                            Inicio = j;
                        }
                        if (Libro.GetCellValueAsString(2, j).ToUpper().Trim() == "CLASES") {
                            Fin = j;
                            if (Inicio == 0) {
                                break;
                            }
                        }
                        if(Inicio!= 0 && Fin != 0) {
                            break;
                        }
                        j++;
                    }
                    for (int i = 4; Libro.GetCellValueAsString(i,1).ToUpper().Trim() != "TOTALES"; i++){
                        if (!string.IsNullOrEmpty(Libro.GetCellValueAsString(i,1))) {
                            Docente = Libro.GetCellValueAsString(i, 1);
                            for (int k = Inicio; k < Fin; k = k + 2) {
                                int NumeroUno;
                                int NumeroDos;
                                if (string.IsNullOrEmpty(Libro.GetCellValueAsString(i, k))) {
                                    NumeroUno = 0;
                                } else {
                                    NumeroUno = int.Parse(Libro.GetCellValueAsString(i, k));
                                }
                                if (string.IsNullOrEmpty(Libro.GetCellValueAsString(i, k + 1))) {
                                    NumeroDos = 0;
                                } else {
                                    NumeroDos = int.Parse(Libro.GetCellValueAsString(i, k + 1));
                                }

                                if ((NumeroUno + NumeroDos) > 0) {
                                    if (!string.IsNullOrEmpty(Libro.GetCellValueAsString(2,k))) {
                                        ProyectoDescarga = Libro.GetCellValueAsString(2, k);
                                        if (Docente != "" && ProyectoDescarga != "") {
                                            mProyecto = new Proyecto();
                                            mProyecto.Docente = Docente;
                                            mProyecto.ProyectoDescarga = ProyectoDescarga;
                                            Listas.ListaProyectos.Add(mProyecto);
                                        }
                                    }
                                }
                            }
                        }
                        padre.MostrarAvanceCarga();
                    }   
                    Docente = "";
                    ProyectoDescarga = "";
                } else {
                    MessageBox.Show("¡No fue posible encontrar la Hoja " + Hoja + "!");
                }
                return true;
            }
            //por si existe un error en alguna hoja 
            catch (Exception ex) {
                MessageBox.Show("¡Error al leer el archivo!\nPor favor verifique el formato.");
                return false;
            }
        }
    }
}
