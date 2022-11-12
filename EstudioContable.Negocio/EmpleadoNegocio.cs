using EstudioContable.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Negocio
{
    public class EmpleadoNegocio
    {
        private EmpleadoDatos _empeladoDatos;
        private EmpresaDatos _empresaDatos;

        public EmpleadoNegocio()
        {
            _empeladoDatos = new EmpleadoDatos();
            _empresaDatos = new EmpresaDatos();

        }

        public List<Empleado> GetLista()
        {
            List<Empleado> list = _empleadoDatos.Traer(100);

            return list;
        }

        public Empresa GetByLegajo( int legajo)
        {
            foreach ( var item in GetLista())
            {
                if (item.Legajo = legajo)
                    return item;
            }
        }


        public void AltaEmpleado(int idEmpresa, int idCategoria, DateTime fechaNacimiento, DateTime fechaAlta, bool activo, int id, string nombre, string apellido, string direccion, long telefono, string mail)
        {
            Empleado empelado = new Empleado();



            _empeladoDatos.Insertar(empleado)


        }







    }
}
