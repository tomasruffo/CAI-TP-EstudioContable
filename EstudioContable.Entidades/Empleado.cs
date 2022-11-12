using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Empleado : Persona
    {
   
        public Persona(int idEmpresa, int idCategoria, DateTime fechaNacimiento, DateTime fechaAlta, bool activo)
            : base(id,  nombre,  apellido,  direccion,  telefono,  mail)
        {
            _idEmpresa = idEmpresa;
            _idCategoria = idCategoria;
            _fechaNacimiento = fechaNacimiento;
            _fechaAlta = fechaAlta;
            _activo = activo;
        }

        private int _idEmpresa;
        private int _idCategoria;
        private DateTime _fechaNacimiento;
        private DateTime _fechaAlta;
        private bool _activo;

        public int IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public string IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public long FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime Activo { get => _activo; set => _activo = value; }
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public long Telefono { get => _telefono; set => _telefono = value; }
        public string Mail { get => _mail; set => _mail = value; }
    }
}
