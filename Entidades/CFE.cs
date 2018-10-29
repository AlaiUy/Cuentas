using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class CFE 
    {
        private int _Tipo;

        public int Tipo
        {
            get { return _Tipo; }
            
        }
        private string _Serie;

        public string Serie
        {
            get { return _Serie; }
        }
        private int _Numero;

        public int Numero
        {
            get { return _Numero; }
        }
        private string _Link;

        public string Link
        {
            get { return _Link; }
        }
        private string _SerieAlbaran;

        public string SerieAlbaran
        {
            get { return _SerieAlbaran; }
            set { _SerieAlbaran = value; }
        }

        private int _NumeroAlbaran;

        public int NumeroAlbaran
        {
            get { return _NumeroAlbaran; }
            set { _NumeroAlbaran = value; }
        }

        private string _SerieFactura;

        public string SerieFactura
        {
            get { return _SerieFactura; }
            set { _SerieFactura = value; }
        }
        private int _NumeroFactura;

        public int NumeroFactura
        {
            get { return _NumeroFactura; }
            set { _NumeroFactura = value; }
        }

        public CFE(int xTipo,string xSerie,int xNumero,string xLink,string xSerieAlbaran,int xNumeroAlbaran,string xSerieFactura,int xNumeroFactura)
        {
            _Tipo = xTipo;
            _Serie = xSerie;
            _Numero = xNumero;
            _Link = xLink;
            _SerieAlbaran = xSerieAlbaran;
            _NumeroAlbaran = xNumeroAlbaran;
            _SerieFactura = xSerieFactura;
            _NumeroFactura = xNumeroFactura;
        }

        public override string ToString()
        {
            switch(_Tipo)
            {
                case 101:
                    return "e-Ticket";
                    
                case 102:
                    return "N/C e-Tickets";
                case 103:
                    return "Nota Debito e-Ticket";
                case 111:
                    return "e-Factura";
                case 112:
                    return "N/C e-Factura";
                case 113:
                    return "Nota Debito e-Factura";
            }
            return _Tipo.ToString();
        }


    }
}
