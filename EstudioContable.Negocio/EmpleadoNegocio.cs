using EstudioContable.Entidades;
using EstudioContable.AccesoDatos;
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

        public EmpleadoNegocio()
        {
            _empeladoDatos = new EmpleadoDatos();

        }

        public List<Empleado> GetLista()
        {
            List<Empleado> list = _empeladoDatos.TraerTodos();

            return list;
        }
        

        public List<Empleado> ReporteEmpleados(int idEmpresa)
        {
            List<Empleado> empleadosDeLaEmpresa= new List<Empleado>();

            List<Empleado> empleados = _empeladoDatos.TraerTodos();
            foreach( Empleado empleado in empleados)
            {
                if (empleado.IdEmpresa == idEmpresa)
                {
                    empleadosDeLaEmpresa.Add(empleado);
                }

            }
            return empleadosDeLaEmpresa;
        }

        public Empleado GetByLegajo( int legajo)
        {
            foreach ( var item in GetLista())
            {
                if (item.Id == legajo)
                    return item;
            }
            return null;
        }


        public void AltaEmpleado(int idEmpresa, int idCategoria,long cuil ,DateTime fechaNacimiento , int id, string nombre, string apellido, string direccion, long telefono, string mail)
        {
   
            Empleado empelado = new Empleado( idEmpresa,  idCategoria,cuil,  fechaNacimiento,   id,  nombre,  apellido,  direccion,  telefono,  mail);

            TransaccionResultado transaction =  _empeladoDatos.Insertar(empelado);
            if (!transaction.IsOk)
                throw new Exception(transaction.Error);

            Console.WriteLine("Empleado agregado correctamente");

        }







    }
}
