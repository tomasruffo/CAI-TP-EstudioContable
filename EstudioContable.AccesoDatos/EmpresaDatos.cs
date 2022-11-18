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
    public class EmpresaDatos
    {
        public List<Empresa> TraerTodos()
        {
            string json_empresas = WebHelper.Get("/EstudioContable/Empresas");
            List<Empresa> resultado = MapList(json_empresas);
            return resultado;
        }

        private List<Empresa> MapList(string json)
        {
            List<Empresa> lst = JsonConvert.DeserializeObject<List<Empresa>>(json); // deserializacion
            return lst;
        }
;
    
        public TransaccionResultado Insertar(Empresa empresa)
        {
            NameValueCollection obj = ReverseMap(empresa); //serializacion -> json

            string json = WebHelper.Post("/EstudioContable/Empresa", obj);

            TransaccionResultado lst = JsonConvert.DeserializeObject<TransaccionResultado>(json);

            return lst;
        }


   

        private NameValueCollection ReverseMap(Empresa empresa)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("RazonSocial", empresa.RazonSocial.ToString());
            n.Add("Cuit", empresa.Cuit.ToString();
            n.Add("Domicilio", empresa.Domicilio);
            n.Add("FechaAlta", empresa.FechaAlta.ToString());
            n.Add("Usuario", empresa.Id.ToString()); // le pongo id poruqe no se que poner en usuario
            n.Add("id", empresa.Id.ToString());

            return n;
        }

    }
}
