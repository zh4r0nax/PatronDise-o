﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Interfaces
{
    public interface IEstudiante
    {
        void Matriculacion(Curso curso);
        void DesMatriculacion(Curso curso);
    }
}
