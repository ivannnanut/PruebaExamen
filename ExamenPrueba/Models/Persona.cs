using ExamenPrueba.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamenPrueba.Models
{
    abstract class Persona : ISaludable
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        private int _edad;

        public Persona(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        abstract public void Saludar(string hola);

        public void Andar() {
            Console.WriteLine("Estoy andando");
        }

        public int Edad
        {
            get { return _edad; }
            set
            {
                if (value <= 4 || value >= 67)
                {
                    throw new Exception("[ERROR] Edad incorrecta");
                }
                else
                {
                    _edad = value;
                }
            }
        }

    }
}
