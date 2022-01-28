using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuardarCSV;
using ListasInformacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardarCSV.Tests
{
    [TestClass()]
    public class ArchivoCsvTests
    {
        [TestMethod()]
        public void crearArchivoCsvTest()
        {
            GuardarCSV.ArchivoCsv mArchivo = new ArchivoCsv();
            LlenarListaProyectos();
            mArchivo.crearArchivoCsv(ListasInformacion.Listas.ListaProyectos, "c:/repo_test/proyectos_de_descarga.csv");
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