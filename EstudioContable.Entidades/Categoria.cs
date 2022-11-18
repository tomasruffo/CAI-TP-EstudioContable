using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Categoria

    {
        private int _id;
        private string _nombre;
        private string _convenvio;
        private double _sueldoBasico;


        public Categoria( int id, string nombre, string convenio, double sueldoBasico)
        {
        
            _id = id;
            _nombre = nombre;
            _convenvio = convenio;
            _sueldoBasico = sueldoBasico;
     

        }

        public int Id { get => _id;}
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Convenio { get => _convenvio; set => _convenvio = value; }
        public double SueldoBasico { get => _sueldoBasico; set => _sueldoBasico = value; }


        public override string ToString()
        {
            return this.Id + "- La categoria es " + this.Nombre + " pertenece al convenio " + this.Convenio + " y el sueldo basico es "+ this.SueldoBasico;

        }



    }
}