using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class FacturaLin
    {

        private string _idArticulo;

        public string IdArticulo
        {
            get { return _idArticulo; }
            set { _idArticulo = value; }
        }


        private int _idLinea;

        public int IdLinea
        {
            get { return _idLinea; }
            set { _idLinea = value; }
        }
        private int _idFactura;

        public int IdFactura
        {
            get { return _idFactura; }
            set { _idFactura = value; }
        }
        private string _serieFactura;

        public string SerieFactura
        {
            get { return _serieFactura; }
            set { _serieFactura = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private float _unidades;

        public float Unidades
        {
            get { return _unidades; }
            set { _unidades = value; }
        }
        private float _precio;

        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        private float _dto;

        public float Dto
        {
            get { return _dto; }
            set { _dto = value; }
        }
        private int _tipoimpuesto;

        public int Tipoimpuesto
        {
            get { return _tipoimpuesto; }
            set { _tipoimpuesto = value; }
        }
        private float _valoriva;

        public float Valoriva
        {
            get { return _valoriva; }
            set { _valoriva = value; }
        }

        public FacturaLin(int xIdFactura,string xSerieFactura,int xNumLin)
        {
            _idFactura = xIdFactura;
            _serieFactura = xSerieFactura;
            _idLinea = xNumLin;
        }

    }
}
