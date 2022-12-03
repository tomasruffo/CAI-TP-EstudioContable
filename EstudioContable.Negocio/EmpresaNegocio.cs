using EstudioContable.AccesoDatos;
using EstudioContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Negocio
{
    public class EmpresaNegocio
    {
        private EmpresaDatos _empresaDatos;
        private EmpleadoDatos _empleadoDatos;

        public EmpresaNegocio()
        {
            _empresaDatos = new EmpresaDatos();
            _empleadoDatos = new EmpleadoDatos();

        }

        public List<Empresa> GetLista()
        {
            List<Empresa> list = _empresaDatos.TraerTodos();

            return list;
        }

        public Empresa GetById(int idEmpleado)
        {
            foreach (var item in GetLista())
            {
                if (item.Id == idEmpleado)
                    return item;
            }
            return null;
        }

        public List<Empleado> GetListaEmpleados()
        {
            List<Empleado> list = _empleadoDatos.TraerTodos();

            return list;
        }

        public Empresa GetByIdEmpleado(int idEmpleado)
        {
            int? idEmpresa = null;
            foreach (var item in GetListaEmpleados())
            {
                if (item.Id == idEmpleado)
                    idEmpresa = item.IdEmpresa;
            }

            if (idEmpresa is null)
            {
                throw new Exception("No se encontro un usuario con ese id");
            }
            else
            {
                Empresa empresaDelEmpleado = GetById(idEmpresa.GetValueOrDefault());
                return empresaDelEmpleado;
            }

            
            
        }

        

        public Empresa GetByLegajo(int legajo)
        {
            foreach (var item in GetLista())
            {
                if (item.Id == legajo)
                    return item;
            }
            return null;
        }



        public void AltaEmpresa(int id, string razonSocial, long cuit, string domicilio)
        {
            Empresa empresa = new Empresa(id, razonSocial, cuit, domicilio);

            
            TransaccionResultado transaction = _empresaDatos.Insertar(empresa);
            if (!transaction.IsOk)
                throw new Exception(transaction.Error);

            Console.WriteLine("Empresa agregada correctamente");


        }







    }
}
