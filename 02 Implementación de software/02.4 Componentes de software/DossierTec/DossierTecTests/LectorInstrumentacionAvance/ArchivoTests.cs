using Microsoft.VisualStudio.TestTools.UnitTesting;
using LectorInstrumentacionAvance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectorInstrumentacionAvance.Tests
{
    [TestClass()]
    public class ArchivoTests
    {
        [TestMethod()]
        public void AbrirArchivoTest_Existe()
        {
            LectorInstrumentacionAvance.Archivo mArchivo = new Archivo("c:\\repo_test\\Carga_Acad_v2.0.xlsx");
            bool resp=mArchivo.AbrirArchivo();

            Assert.AreEqual(true, resp);
        }
        [TestMethod()]
        public void AbrirArchivoTest_NoExiste()
        {
            LectorInstrumentacionAvance.Archivo mArchivo = new Archivo("c:\\repo_test\\no_esta.xlsx");
            bool resp = mArchivo.AbrirArchivo();
            Assert.AreEqual(false, resp);
        }

        [TestMethod()]
        public void AbrirArchivoTest_LeerCarrera()
        {
            bool resp=false;
            LectorInstrumentacionAvance.Archivo mArchivo = new Archivo("c:\\repo_test\\Carga_Acad_v2.0.xlsx");
            if (mArchivo.AbrirArchivo())
                resp=mArchivo.LeerArchivo("ISC");
            Assert.AreEqual(true, resp);
        }

        [TestMethod()]
        public void AbrirArchivoTest_LeerCarreraNoDisponible()
        {
            bool resp = false;
            LectorInstrumentacionAvance.Archivo mArchivo = new Archivo("c:\\repo_test\\Carga_Acad_v2.0.xlsx");
            if (mArchivo.AbrirArchivo())
                resp = mArchivo.LeerArchivo("No existe");
            Assert.AreEqual(true, resp);
        }

        [TestMethod()]
        public void AbrirArchivoTest_LeerMaterias()
        {
            int resp = 0;
            LectorInstrumentacionAvance.Archivo mArchivo = new Archivo("c:\\repo_test\\Carga_Acad_v2.0.xlsx");
            if (mArchivo.AbrirArchivo())
            {
                mArchivo.LeerArchivo("ISC");
                resp=ListasInformacion.Listas.ListaInstrumentaciones.Count();
            }
            Assert.AreEqual(33, resp);
        }

    }
}