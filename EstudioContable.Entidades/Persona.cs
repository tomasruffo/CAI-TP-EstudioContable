﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Persona 
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private long _telefono;
        private string _mail;
  
        public Persona(int id , string nombre, string apellido, string direccion, long telefono,string mail)
        {
           _id = id;
           _nombre = nombre;
           _apellido = apellido;
           _direccion = direccion;
           _telefono = telefono;
           _mail = mail;   
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public long Telefono { get => _telefono; set => _telefono = value; }
        public string Mail { get => _mail; set => _mail = value; }


    }
}
