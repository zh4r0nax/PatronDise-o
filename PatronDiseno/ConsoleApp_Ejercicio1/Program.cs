using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1;

namespace ConsoleApp_Ejercicio1
{
    class Program
    {
        List<Estudiante> Lista_Estudiantes = new List<Estudiante>();
        List<Persona> Lista_Personas = new List<Persona>();
        List<Profesor> Lista_Profesor = new List<Profesor>();
        List<Personal_Servicio> Lista_Persolan_Servicio = new List<Personal_Servicio>();


        static void Main(string[] args)
        {
            Persona estudiante1 = new Persona();

            Curso cur = new Curso();
            cur.ID = 1;
            cur.Nombre = "Programacion";

            estudiante1.Nombre_Principal = "Juan";
            estudiante1.Nombre_Secundario = "Manuel";
            estudiante1.Apellido_Paterno = "Galvez";
            estudiante1.Apellido_Materno = "Castro";

            estudiante1 = new Estudiante(estudiante1);
            estudiante1.Matriculacion(cur);

            Console.WriteLine(estudiante1.ToString());

        }

        private void Agregar_Persona_Lista(Persona persona)
        {
            //switch (persona.GetType())
            //{
            //    case Persona:
            //        Lista_Personas.Add(persona);
            //        break
            //    default:
            //        break;
            //}
        }
    }
}
