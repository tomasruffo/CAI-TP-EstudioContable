using EstudioContable.AccesoDatos;
using EstudioContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Negocio
{
    public class CategoriaNegocio
    {
        private CategoriaDatos _categoriaDatos;
        private EmpleadoDatos _empleadoDatos;
        public CategoriaNegocio()
        {
            _categoriaDatos = new CategoriaDatos();

        }

        public List<Categoria> GetLista()
        {
            List<Categoria> list = _categoriaDatos.TraerTodos();

            return list;
        }

        public Categoria GetById(int? id)
        {
            foreach (var item in GetLista())
            {
                if (item.Id == id)
                    return item;

            }
            return null;
        }

        public List<Empleado> GetListaEmpleados()
        {
            List<Empleado> list = _empleadoDatos.TraerTodos();

            return list;
        }

        public Categoria GetByIdEmpleado(int idEmpleado)
        {
            int? idCategoria = null; ;
            foreach (var item in GetListaEmpleados())
            {
                if (item.Id == idEmpleado)
                    idCategoria = item.IdCategoria;
            }

            if (idCategoria == null)
            {
                throw new Exception("No se encontro un usuario con ese id ");
            }
            else
            {
                Categoria categoraiDelEmpleado = GetById(idCategoria);
                return categoraiDelEmpleado;
            }

        }



        public void AltaCategoria(int id, string nombre, string convenio, double sueldoBasico)
        {
            Categoria categoria = new Categoria(id, nombre, convenio, sueldoBasico);

            _categoriaDatos.Insertar(categoria);


        }







    }
}
