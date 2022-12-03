using EstudioContable.AccesoDatos;
using EstudioContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Negocio
{
    public class LiquidacionNegocio
    {
        private LiquidacionDatos _liquidacionDatos;
        private EmpleadoDatos _empleadoDatos;


        public LiquidacionNegocio()
        {
            _liquidacionDatos = new LiquidacionDatos();
            _empleadoDatos = new EmpleadoDatos();    

        }

        public List<Liquidacion> GetLista()
        {
            List<Liquidacion> list = _liquidacionDatos.TraerTodos();

            return list;
        }

        public List<Empleado> GetEmpleados()
        {
            List<Empleado> list = _empleadoDatos.TraerTodos();

            return list;
        }



        public List<Liquidacion> GetById(int Id)
        {
            List<Liquidacion> matched_liquidaciones = new List<Liquidacion>();
            foreach (var item in GetLista())
            {
                if (item.Id == Id)
                    matched_liquidaciones.Add(item);
            }
            return matched_liquidaciones;
        }

        
         public List<Liquidacion> ReporteLiquidaciones(int idCategoria)
        {
            List<Empleado> empelados = GetEmpleados();
            List<Empleado> empeladosCategoria = new List<Empleado>(); 
            List<Liquidacion> liquidacionesCategoria = new List<Liquidacion>();
            foreach (Empleado empleado in empelados)
            {
                if (empleado.IdCategoria == idCategoria)
                {
                    empeladosCategoria.Add(empleado);
                }

            }
            if (empeladosCategoria.Count == 0)
            {
                throw new Exception("No se encontraron empelados que tengan esa categoria");
            }

            foreach(Empleado empelado in empeladosCategoria)
            {
                List<Liquidacion> liquidacionesPorEmpleado = GetById(empelado.Id);
                liquidacionesCategoria.AddRange(liquidacionesPorEmpleado);
            }
            return liquidacionesCategoria;
        }

        public void AltaLiquidacion(int id, int idEmpleado, int codigoTransferencia, int periodo, double bruto, double descuentos)
        {
            Liquidacion liquidacion = new Liquidacion(id, idEmpleado, codigoTransferencia, periodo, bruto, descuentos);

            TransaccionResultado transaction = _liquidacionDatos.Insertar(liquidacion);
            if (!transaction.IsOk)
                throw new Exception(transaction.Error);

            Console.WriteLine("Empresa agregada correctamente");

        }







    }
}
