﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Personas
    {
        private string _Apellido;
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        private string _Direccion;
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private DateTime _FechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }
        private int _IDPlan;
        public int IDPlan
        {
            get { return _IDPlan; }
            set { _IDPlan = value; }
        }
        private int _Legajo;
        public int Legajo
        {
            get { return _Legajo; }
            set { _Legajo = value; }
        }
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private string _Telefono;
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public enum TipoPersona
        {
            Alumno,
            Docente,
            jefeCatedra

        }

        private TipoPersona _TiposPersonas;
        public TipoPersona TiposPersonas
        {
            get { return _TiposPersonas; }
            set { _TiposPersonas = value; }
        }
         






    }
}
