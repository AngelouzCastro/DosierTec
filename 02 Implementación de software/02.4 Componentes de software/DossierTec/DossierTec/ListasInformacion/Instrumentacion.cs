using System;
using System.Collections.Generic;
using System.Text;

namespace ListasInformacion
{
    public class Instrumentacion
    {
        public Instrumentacion(string carrera, string docente, string materia, string semestre, string grupo)
        {
            Carrera = carrera;
            Docente = docente;
            Materia = materia;
            Semestre = semestre;
            Grupo = grupo;
        }

        public String Carrera { get; set; }
        public String Docente { get; set; }
        public String Materia { get; set; }
        public String Semestre { get; set; }
        public String Grupo { get; set; }

        public override String ToString()
        {
            return Carrera + " - " + Docente + " - " + Materia + " - " + Semestre + " - " + Grupo;
            ///ISC-DanielArredondoSalcedo-AMD6A
        }
    }
}

