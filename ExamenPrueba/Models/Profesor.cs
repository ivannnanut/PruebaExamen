using ExamenPrueba.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrueba.Models
{
    class Profesor : Persona, IEvaluable
    {
        private float _sueldo;

        public Profesor(string nombre, string apellidos, int edad, float sueldo) : base(nombre, apellidos, edad)
        {
            Sueldo = sueldo;
        }

        public float Sueldo
        {
            get { return _sueldo; }
            set
            {
                if (value < 600 || value > 4000)
                {
                    throw new Exception("[ERROR] ¿Seguro que gana eso?");
                }
                _sueldo = value;
            }
        }

        public void Regañar(string regaño)
        {
            Console.WriteLine("Vete a tu casa y piensalo " + regaño);
        }



        public void Evaluar(Alumno alumno, float nota)
        {
            alumno.Nota = nota;
        }


        public override void Saludar(string hola)
        {

            Console.WriteLine("Holita " + hola);
        }

        public override string ToString()
        {
            string frase = ("[PROFESOR] " + Nombre + " " + Apellidos);
            return String.Format(frase + "\n" + "".PadRight(frase.Length, '-'));
        }

    }
}
