using Microsoft.VisualStudio.TestTools.UnitTesting;
using LectorProyectosDescarga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectorProyectosDescarga.Tests
{
    [TestClass()]
    public class ArchivoTests
    {
        [TestMethod()]
        public void AbrirArchivoTest_Existe()
        {
            LectorProyectosDescarga.Archivo mArchivo = new Archivo();
            mArchivo.RutaArchivo = "c:\\repo_test\\Carga_Acad_v2.0.xlsx";
            bool resp = mArchivo.AbrirArchivo();

            Assert.AreEqual(true, resp);
        }
        [TestMethod()]
        public void AbrirArchivoTest_NoExiste()
        {
            LectorProyectosDescarga.Archivo mArchivo = new Archivo();
            mArchivo.RutaArchivo = "c:\\repo_test\\no_esta.xlsx";
            bool resp = mArchivo.AbrirArchivo();
            Assert.AreEqual(false, resp);
        }
        
        [TestMethod()]
        public void AbrirArchivoTest_LeerDocentes()
        {
            bool resp = false;
            LectorProyectosDescarga.Archivo mArchivo = new Archivo();
            mArchivo.RutaArchivo = "c:\\repo_test\\Carga_Acad_v2.0.xlsx";
            mArchivo.padre = new FrmSeleccionarProyectos();
            if (mArchivo.AbrirArchivo())
                resp = mArchivo.LeerArchivo("Docentes");
            Assert.AreEqual(true, resp);
        }
        
        [TestMethod()]
        public void AbrirArchivoTest_LeerDocentesNoDisponible()
        {
            bool resp = false;
            LectorProyectosDescarga.Archivo mArchivo = new Archivo();
            mArchivo.RutaArchivo = "c:\\repo_test\\Carga_Acad_v2.0.xlsx";
            mArchivo.padre = new FrmSeleccionarProyectos();
            if (mArchivo.AbrirArchivo())
                resp = mArchivo.LeerArchivo("No existe");
            Assert.AreEqual(true, resp);
        }
        
        [TestMethod()]
        public void AbrirArchivoTest_LeerProyectos()
        {
            int resp = 0;
            LectorProyectosDescarga.Archivo mArchivo = new Archivo();
            mArchivo.RutaArchivo = "c:\\repo_test\\Carga_Acad_v2.0.xlsx";
            mArchivo.padre = new FrmSeleccionarProyectos();
            if (mArchivo.AbrirArchivo())
            {
                mArchivo.LeerArchivo("Docentes");
                resp=ListasInformacion.Listas.ListaProyectos.Count();
            }
            Assert.AreEqual(216, resp);
        }
    }
}