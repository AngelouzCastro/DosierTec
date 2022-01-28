using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ListasInformacion;

namespace GeneradorInstrumentacionAvance
{
    public class Directorio
    {
        string DireccionDirectorio; //Ubicación de nonde estará el directorio

        public Directorio(string Direccion) {
            this.DireccionDirectorio = Direccion;
        }

        public void CreacionDirectorios() {
            //Método para recorer la Lista y creando los directorios
            Listas.ListaInstrumentaciones = Listas.ListaInstrumentaciones;
            string Carrera = "";
            string Docente = "";
            string Materia = "";
            string Semestre = "";
            string Grupo = "";
            string DirExistentes = "";
            foreach (Instrumentacion mInstrumentacion in Listas.ListaInstrumentaciones){
                
                Carrera = mInstrumentacion.Carrera;
                Docente = mInstrumentacion.Docente;
                Materia = mInstrumentacion.Materia;
                Semestre = mInstrumentacion.Semestre;
                Grupo = mInstrumentacion.Grupo;
                // Especificamos la ruta completa del directorio a crear.
                string path = @""+this.DireccionDirectorio +"\\Instr-Avance"+ "\\"+Carrera + "\\"+Docente+"\\"+Materia+"_"+Semestre + Grupo + " ";
                //MessageBox.Show(path);

                try {
                    // Verifica si el directorio existe.
                    if (Directory.Exists(path)){
                        DirExistentes= DirExistentes+" "+ Carrera + "\\" + Docente + "\\" + Materia + "_" + Semestre + Grupo + "\n";
                    }else{
                        //Crea la ruta completa de directorios, junto con sus subcarpetas
                        DirectoryInfo di = Directory.CreateDirectory(path);
                        Console.WriteLine("El directorio ha sido creado {0}.", Directory.GetCreationTime(path));
                    }
                }catch (Exception ex){
                    MessageBox.Show("Error: {0}", ex.ToString());
                }

            }
            if(!DirExistentes.Equals(""))
                MessageBox.Show("Los siguientes directorios ya existian: \n "+ DirExistentes.Substring(0,1000) +"...");

        }
    }
}
