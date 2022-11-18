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

        public LiquidacionNegocio()
        {
            _liquidacionDatos = new LiquidacionDatos();

        }

        public List<Liquidacion> GetLista()
        {
            List<Liquidacion> list = _liquidacionDatos.TraerTodos();

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


        public void AltaLiquidacion(int id, int idEmpleado, int codigoTransferencia, int periodo, double bruto, double descuentos)
        {
            Liquidacion liquidacion = new Liquidacion(id, idEmpleado, codigoTransferencia, periodo, bruto, descuentos);

            _liquidacionDatos.Insertar(liquidacion);


        }







    }
}
