using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPrueba.Models;

namespace ExamenPrueba.Interfaces
{
    interface IEvaluable
    {

        void Evaluar(Alumno alumno, float nota);
        
    }
}
