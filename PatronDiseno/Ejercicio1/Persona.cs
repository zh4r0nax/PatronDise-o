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
        //Ejercicio1 polimorfismo de jufgadores de españa
        public String Nombre_Principal ;
        public String Nombre_Secundario ;
        public String Apellido_Paterno ;
        public String Apellido_Materno ;
        public int Rut ;
        public String CV ;
        public String Estado_Civil ;

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
