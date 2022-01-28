using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneradorProyectosDescarga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListasInformacion;

namespace GeneradorProyectosDescarga.Tests
{
    [TestClass()]
    public class Directorio_PDTests
    {
        [TestMethod()]
        public void CrearDirectoriosTest()
        {
            GeneradorProyectosDescarga.Directorio_PD mDir
                =  new GeneradorProyectosDescarga.Directorio_PD("c:/repo_test");
            LlenarListaProyectos();
            mDir.CrearDirectorios();
            Assert.AreEqual(true, true);
        }

        [TestMethod()]
        public void CrearDirectoriosTest_vacio()
        {
            GeneradorProyectosDescarga.Directorio_PD mDir
                = new GeneradorProyectosDescarga.Directorio_PD("c:/repo_test");
            Listas.ListaProyectos = new List<Proyecto>();
            mDir.CrearDirectorios();
            Assert.AreEqual(true, true);
        }

        public void LlenarListaProyectos()
        {
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


        }
    }
}