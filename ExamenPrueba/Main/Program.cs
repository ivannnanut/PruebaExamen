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

            Console.WriteLine(myClase.profe);
            foreach (var a in myClase.alumnos)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("La nota media de la clase es "+ myClase.CalcularMedia()) ;

            Console.ReadLine();

        }
        private static List<Alumno> AniadirAlumnos()
        {
            var lista = new List<Alumno>();

            lista.Add(new Alumno("Ivansito", "Carrillito", 20, "eeadd3445"));
            lista.Add(new Alumno("JUANVMILLX", "Pedrosa", 26, "eadad34562"));
            lista.Add(new Alumno("Albatross","Enano",20,"esasdasd242354"));
            return lista;
        }

        private static Profesor AniadirProfesor()
        {
            var profesor = new Profesor("Jose", "De la Torre", 26, 2500);
            return profesor;
        }


    }
}


