using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Liquidacion
    {
        private int _id;
        private int _idEmpleado;
        private int _codigoTransferencia;
        private int _periodo;
        private double _bruto;
        private double _descuentos;
        private DateTime _fechaAlta;
  
        public Liquidacion(int id , int idEmpleado, int codigoTransferencia, int periodo, double bruto, double descuentos)
        {
            _id= id;
            _idEmpleado= idEmpleado;
            _codigoTransferencia= codigoTransferencia;
            _periodo = periodo;
            _bruto = bruto;
            _descuentos = descuentos;
            _fechaAlta = DateTime.Today; 
    }

        public int Id { get => _id;}
        public int IdEmpleado { get => _idEmpleado;  }
        public int CodigoTransferencia { get => _codigoTransferencia; }
        public int Periodo { get => _periodo; set => _periodo = value; }
        public double Bruto { get => _bruto; set => _bruto = value; }
        public double Descuentos { get => _descuentos; set => _descuentos = value; }
        public DateTime FechaAlta { get => _fechaAlta;  }


        public override string ToString()
        {
            return this.Id + "-" + this.CodigoTransferencia + " periodo: " + this.Periodo + " bruto: " + this.Bruto + " Descuentos: " + this.Descuentos + "Fecha Alta: " + this.FechaAlta;
        }


    }
}
