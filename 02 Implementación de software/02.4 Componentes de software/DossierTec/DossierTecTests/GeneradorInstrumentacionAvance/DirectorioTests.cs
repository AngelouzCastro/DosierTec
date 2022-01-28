using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneradorInstrumentacionAvance;
using ListasInformacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorInstrumentacionAvance.Tests
{
    [TestClass()]
    public class DirectorioTests
    {
        [TestMethod()]
        public void CreacionDirectoriosTest()
        {
            GeneradorInstrumentacionAvance.Directorio mDir = new Directorio("c:/repo_test");
            LlenarListaInstrumentaciones();
            mDir.CreacionDirectorios();
            Assert.AreEqual(true, true);
        }

        [TestMethod()]
        public void CreacionDirectoriosTest_vacio()
        {
            GeneradorInstrumentacionAvance.Directorio mDir = new Directorio("c:/repo_test");
            Listas.ListaInstrumentaciones = new List<Instrumentacion>();
            mDir.CreacionDirectorios();
            Assert.AreEqual(true, true);
        }

        private void LlenarListaInstrumentaciones()
        {
            Listas.ListaInstrumentaciones = new List<Instrumentacion>();
            //Creamos instrumentaciones de ejemplo
            Instrumentacion mInst1 = new Instrumentacion("ISC","Daniel Arredondo", "Bases de datos","7","A");
            Listas.ListaInstrumentaciones.Add(mInst1);
            Instrumentacion mInst2 = new Instrumentacion("ISC", "Daniel Arredondo", "Ingeniería de software", "5", "A");
            Listas.ListaInstrumentaciones.Add(mInst2);
            Instrumentacion mInst3 = new Instrumentacion("ITIC", "Manuel Ignacion Salas", "TSP", "9", "A");
            Listas.ListaInstrumentaciones.Add(mInst3);
            Instrumentacion mInst4 = new Instrumentacion("IEM", "José María", "Dinámica de fluidos", "3", "A");
            Listas.ListaInstrumentaciones.Add(mInst4);

        }

        
    }
}