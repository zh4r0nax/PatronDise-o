using Ejercicio1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /// <summary>
    /// Clase estudiante que Hereda Propiedades de Persona Implementando una interface de Estudiante
    /// </summary>
    public class Estudiante : Persona, IEstudiante
    {
        List<Curso> Lista_Curso;
        public Estudiante()
        {
            try
            {
                Lista_Curso = new List<Curso>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        /// <summary>
        /// Metodo que ayuda a quitar un matricula de algun curso
        /// </summary>
        /// <param name="curso">Datos del curso a quitar</param>
        public void DesMatriculacion(Curso curso)
        {
            try
            {
                Lista_Curso.Remove(curso);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Metodo para agregar una matricula de un curso al estudiante
        /// </summary>
        /// <param name="curso">Datos del curso a Agregar</param>
        public void Matriculacion(Curso curso)
        {
            try
            {
                Lista_Curso.Add(curso);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
