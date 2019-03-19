using Ejercicio1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Persona: IEstudiante,IEmpleado,IPersonal_servicio,IProfesor
    {
        public String Nombre_Principal { get; set; }
        public String Nombre_Secundario { get; set; }
        public String Apellido_Paterno { get; set; }
        public String Apellido_Materno { get; set; }
        public int Rut { get; set; }
        public String CV { get; set; }
        public String Estado_Civil { get; set; }

        public virtual void Cambio_Departameno(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public virtual void DesMatriculacion(Curso curso)
        {
            throw new NotImplementedException();
        }

        public virtual void Matriculacion(Curso curso)
        {
            throw new NotImplementedException();
        }

        public virtual void Registracion_Despacho(Despacho despacho)
        {
            throw new NotImplementedException();
        }

        public virtual void Traslado_Seccion(Seccion seccion)
        {
            throw new NotImplementedException();
        }
    }
}
