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
    public class CategoriaDatos
    {
        public List<Categoria> TraerTodos()
        {
            string json_categorias = WebHelper.Get("/EstudioContable/Categorias");
            List<Categoria> resultado = MapList(json_categorias);
            return resultado;
        }

        private List<Categoria> MapList(string json)
        {
            List<Categoria> lst = JsonConvert.DeserializeObject<List<Categoria>>(json); // deserializacion
            return lst;
        }
;
    
        public TransaccionResultado Insertar(Categoria categoria)
        {
            NameValueCollection obj = ReverseMap(categoria); //serializacion -> json

            string json = WebHelper.Post("/EstudioContable/Categoria", obj);

            TransaccionResultado lst = JsonConvert.DeserializeObject<TransaccionResultado>(json);

            return lst;
        }

        private NameValueCollection ReverseMap(Categoria categoria)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Nombre", categoria.Nombre.ToString());
            n.Add("Convenio", categoria.Convenio);
            n.Add("SueldoBasico", categoria.SueldoBasico.ToString());
            n.Add("id", categoria.Id.ToString());
         

            return n;
        }

    }
}
