using System;
using System.Collections.Generic;
using System.Text;

namespace ListasInformacion
{
    class Listas
    {
        /// <summary>
        /// Esta lista sirve para almacenar y validar los datos 
        /// que se usarán para generar el repositorio de Instrumentaciones y Avance.
        /// </summary>
        static public List<Instrumentacion> ListaInstrumentaciones { get; set; }
        /// <summary>
        /// Esta lista sirve para almacenar y validar los datos 
        /// que se usarán para generar el repositorio de Proyectos.
        /// </summary>
        static public List<Proyecto> ListaProyectos { get; set; }
    }
}
