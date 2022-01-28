using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using SpreadsheetLight;
using ListasInformacion;

namespace LectorInstrumentacionAvance
{
    public class Archivo
    {

        string DireccionArchivo;
        SLDocument libro;
        public Archivo(string DireccionArchivo)
        {
            this.DireccionArchivo = DireccionArchivo;
            Listas.ListaInstrumentaciones = new List<Instrumentacion>();
            
        }

        public bool AbrirArchivo()
        {

            try
            {
                libro = new SLDocument(DireccionArchivo);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo, verifique que sea un archivo válido o no esté siendo usado por otra aplicación ");
                return false;
            }

        }

        //mtodo para buscar los datos en las hojas de excel y llenar la lista
        public bool LeerArchivo(string Hoja)
        {
            // try por si existe algun error en la hoja
            try
            {

                libro.SelectWorksheet(Hoja);
                
                

                //por si no existe la hoja omitirla
                if (libro.SelectWorksheet(Hoja) == true)
                {
                    int ColumnaDocente = 4;
                    int ColumnaSemestre = 2;
                    int ColumnaGrupo = 3;
                    int ColumnaMateria = 1;
                    string Docente = "";
                    string Semestre = "";
                    string Grupo = "";
                    string Materia = "";
                    string Carrera = Hoja;
                    Instrumentacion mInstrumentacion;
                    for (int Fila = 2; Fila <= 100; Fila++)
                    {
                        if (!string.IsNullOrEmpty(libro.GetCellValueAsString(Fila, ColumnaMateria)))
                        {
                            Materia = libro.GetCellValueAsString(Fila, ColumnaMateria);
                        }
                        if (!string.IsNullOrEmpty(libro.GetCellValueAsString(Fila, ColumnaSemestre)))
                        {
                            Semestre = libro.GetCellValueAsString(Fila, ColumnaSemestre);
                        }
                        if (!string.IsNullOrEmpty(libro.GetCellValueAsString(Fila, ColumnaGrupo)))
                        {
                            Grupo = libro.GetCellValueAsString(Fila, ColumnaGrupo);
                        }
                        if (!string.IsNullOrEmpty(libro.GetCellValueAsString(Fila, ColumnaDocente)))
                        {
                            Docente = libro.GetCellValueAsString(Fila, ColumnaDocente);
                        }
                        if (libro.GetCellValueAsString(Fila, ColumnaMateria) == "" &&
                           libro.GetCellValueAsString(Fila + 1, ColumnaMateria) == "" &&
                           libro.GetCellValueAsString(Fila - 1, ColumnaMateria) == "")
                        {
                            break;
                        }
                        if (Carrera != "" && Docente != "" && Materia != "" && Semestre != "" && Grupo != "")
                        {
                            mInstrumentacion = new Instrumentacion(Carrera, Docente, Materia, Semestre, Grupo);
                            Listas.ListaInstrumentaciones.Add(mInstrumentacion);
                        }
                        Docente = "";
                        Semestre = "";
                        Grupo = "";
                        Materia = "";
                    }
                }
                else
                {
                    MessageBox.Show("¡No fue posible encontrar la Hoja " + Hoja + "!");
                }
                return true;
            }
            //por si existe un error en alguna hoja
            catch (Exception ex)
            {
                MessageBox.Show("¡Error al leer el archivo ! " + ex.ToString());
                return false;
            }


        }


    }

}

