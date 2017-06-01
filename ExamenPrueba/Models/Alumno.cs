using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrueba.Models
{
    class Alumno : Persona
    {
        public string nMatricula { get; set; }
        private float _nota;

        public Alumno(string nombre,string apellidos,int edad,string nmatricula, float nota) : base( nombre,  apellidos, edad)
        {
            nMatricula = nmatricula;
            Nota = nota;
        }

        public Alumno(string nombre, string apellidos, int edad, string nmatricula) : base(nombre, apellidos, edad)
        {
            nMatricula = nmatricula;
            Nota =0;
        }

        public float Nota
        {
            get { return _nota; }
            set
            {
                if(value<0 || value > 10)
                {
                    throw new Exception("[ERROR] Nota incorrecta");
                }
                _nota = value;
            }
        }

        override
        public void Saludar(string hola)
        {
            hola = "Holita vecinito";
            Console.WriteLine(hola);
        }

        public void Quejarse(string queja)
        {
            queja = "Enga ya profe";
            Console.WriteLine(queja);
        }

        
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2} ", Nombre, Apellidos,Nota);
        } 
    }
}
