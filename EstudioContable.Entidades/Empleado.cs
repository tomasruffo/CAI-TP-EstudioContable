using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Empleado 

    {
        private int _idEmpresa;
        private int _idCategoria;
        private long _cuil;
        private DateTime _fechaNacimiento;
        private DateTime _fechaAlta;
        private bool _activo;
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private long _telefono;
        private string _mail;

        public Empleado(int idEmpresa, int idCategoria,long cuil, DateTime fechaNacimiento,  int id, string nombre, string apellido, string direccion, long telefono, string mail)
        {
            _idEmpresa = idEmpresa;
            _idCategoria = idCategoria;
            _cuil = cuil;
            _fechaNacimiento = fechaNacimiento;
            _fechaAlta = DateTime.Today;
            _activo = true;
            _id= id;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;
            _mail = mail;

        }

        

        public int IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public string IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string Cuil { get => _cuil; set => _cuil = value; }
        public long FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string FechaAlta { get => _fechaAlta; }
        public DateTime Activo { get => _activo; set => _activo = value; }
        public int Id { get => _id; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public long Telefono { get => _telefono; set => _telefono = value; }
        public string Mail { get => _mail; set => _mail = value; }


    public override string ToString()
    {
        return this.Id + "-" + this.Nombre + " "+this.Apellido;

    }

     

    }
}
