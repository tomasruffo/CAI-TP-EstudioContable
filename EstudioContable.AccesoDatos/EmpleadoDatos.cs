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
    public class EmpleadoDatos
    {
        public List<Empleado> TraerTodos()
        {
            string json_empleados = WebHelper.Get("/EstudioContable/Empleados");
            List<Empleado> resultado = MapList(json_empleados);
            return resultado;
        }

        private List<Empleado> MapList(string json)
        {
            List<Empleado> lst = JsonConvert.DeserializeObject<List<Empleado>>(json); // deserializacion
            return lst;
        }
;
    
        public TransaccionResultado Insertar(Empleado empleado)
        {
            NameValueCollection obj = ReverseMap(empleado); //serializacion a json

            string json = WebHelper.Post("/EstudioContable/Empleado", obj);

            TransaccionResultado lst = JsonConvert.DeserializeObject<TransaccionResultado>(json);// deserializacion de la resupuesta

            return lst;
        }

        private NameValueCollection ReverseMap(Empleado empleado)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idCategoria", empleado.IdCategoria.ToString());
            n.Add("idEmpresa", empleado.IdEmpresa.ToString();
            n.Add("Apellido", empleado.Apellido);
            n.Add("Cuil", empleado.Cuil.ToString());
            n.Add("Nombre", empleado.Nombre);
            n.Add("Apellido", empleado.Apellido);
            n.Add("FechaNacimiento", empleado.FechaNacimiento.ToString("yyyy-MM-dd"));
            n.Add("FechaAlta", empleado.FechaAlta.ToString("yyyy-MM-dd"));
            n.Add("id", empleado.Id.ToString());
            return n;
        }

    }
}
