using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPrueba.Models;

namespace ExamenPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClase = new Clase();
            myClase.alumnos = AniadirAlumnos();
            myClase.profe = AniadirProfesor();

            try
            {
                myClase.EvaluarTodos();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            foreach (var a in myClase.alumnos)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();

        }
        private static List<Alumno> AniadirAlumnos()
        {
            var lista = new List<Alumno>();

            lista.Add(new Alumno("Ivansito", "Carrillito", 20, "eeadd3445"));
            lista.Add(new Alumno("JUANVMILLX", "Pedrosa", 26, "eadad34562"));
            return lista;
        }

        private static Profesor AniadirProfesor()
        {
            var profesor = new Profesor("Jose", "De la Torre", 26, 2500);
            return profesor;
        }


    }
}


