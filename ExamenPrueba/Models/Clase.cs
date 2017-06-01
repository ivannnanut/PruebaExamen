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
        public List<Alumno> alumnos { get; set; }

        public float CalcularMedia()
        {
            float nota;
           return  nota = alumnos.Average(x => x.Nota);
        }

        public void EvaluarTodos()
        {
            if(profe == null || alumnos == null)
            {
                throw new Exception("Falta gente en la clase");
            }
            foreach (var a in alumnos)
            {
                var nota = PonerNota(a);
                profe.Evaluar(a, nota);
            }

        }

        public float PonerNota(Alumno a)
        {
            Console.WriteLine("Introduce la nota del alumno " + a.Nombre+" " + a.Apellidos);
            var notaStr = Console.ReadLine();
            var nota = 0f;
            float.TryParse(notaStr, out nota);
            return nota;
        }
    }
        
}
