﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class Usuario
    {
        private int _codUsuario;
        private string _Nombre;
        private string _EmailHost;
        private string _PassEmail;
        private int _CodVendedor;
        private string _Email;
        private string _Password;
        private List<Permiso> _Permisos;
        private string _NombreReal;

        public Usuario(int xCodigo,List<Permiso> xList)
        {
            _codUsuario = xCodigo;
            _Permisos = xList;
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }


        public string PassEmail
        {
            get { return _PassEmail; }
            set { _PassEmail = value; }
        }


        public string EmailHost
        {
            get { return _EmailHost; }
            set { _EmailHost = value; }
        }


        public int CodVendedor
        {
            get { return _CodVendedor; }
            set { _CodVendedor = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public int CodUsuario
        {
            get { return _codUsuario; }
        }

        public List<Permiso> Permisos
        {
            get
            {
                return _Permisos;
            }

        }

        public string NombreReal
        {
            get
            {
                return _NombreReal;
            }

            set
            {
                _NombreReal = value;
            }
        }

        public bool Permiso(int xPermiso)
        {
            if (_Permisos != null)
                if(_Permisos.Exists(x => x.IdPermiso == xPermiso))
                    return true;
            return false;
        }
    }
}
