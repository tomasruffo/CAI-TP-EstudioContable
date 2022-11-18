using EstudioContable.Entidades;
using EstudioContable.AccesoDatos.utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;


namespace EstudioContable.AccesoDatos
{
    public class LiquidacionDatos
    {
        public List<Liquidacion> TraerTodos()
        {
            string json_liquidaciones = WebHelper.Get("/EstudioContable/Liquidacion");
            List<Liquidacion> resultado = MapList(json_liquidaciones);
            return resultado;
        }

        private List<Liquidacion> MapList(string json)
        {
            List<Liquidacion> lst = JsonConvert.DeserializeObject<List<Liquidacion>>(json); // deserializacion
            return lst;
        }

    
        public TransaccionResultado Insertar(Liquidacion liquidacion)
        {
            NameValueCollection obj = ReverseMap(liquidacion); //serializacion -> json

            string json = WebHelper.Post("/EstudioContable/liquidacion", obj);

            TransaccionResultado lst = JsonConvert.DeserializeObject<TransaccionResultado>(json);

            return lst;
        }

        private NameValueCollection ReverseMap(Liquidacion liquidacion)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idEmpleado", liquidacion.IdEmpleado.ToString());
            n.Add("Periodo", liquidacion.Periodo.ToString());
            n.Add("CodigoTransferencia", liquidacion.CodigoTransferencia.ToString());
            n.Add("Bruto", liquidacion.Bruto.ToString());
            n.Add("Descuentos", liquidacion.Descuentos.ToString());
            n.Add("FechaAlta", liquidacion.FechaAlta.ToString());
            n.Add("id", liquidacion.Id.ToString());


            return n;
        }

    }
}
