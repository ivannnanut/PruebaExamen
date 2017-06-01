using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrueba.Models
{
    class Clase
    {
        public Profesor profe { get; set; }
        public IList<Alumno> alumnos { get; set; }

        public float CalcularMedia()
        {
            float nota;
           return  nota = alumnos.Average(x => x.Nota);
        }
    }
}
