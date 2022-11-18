using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Empresa 
    {
        private int _id;
        private string _razonSocial;
        private long _cuit;
        private string _domicilio;
        private DateTime _fechaAlta;
  
        public Empresa(int id , string razonSocial, long cuit, string domicilio )
        {
           _id = id;
           _razonSocial = razonSocial;
           _cuit = cuit;
           _domicilio = domicilio;
           _fechaAlta = DateTime.Today;
        }

        public int Id { get => _id;}
        public string RazonSocial { get => _razonSocial;  }
        public long Cuit { get => _cuit; set => _cuit = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        public DateTime FechaAlta { get => _fechaAlta; }


        public override string ToString()
        {
            return this.Id + "-" + this.RazonSocial + "- domicilio: " + this.Domicilio + " razon social: "+ this.RazonSocial ;

        }


    }

   

}

