﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aguiñagalde.Entidades
{
    public class RMora:Remito 
    {
       


        public RMora(string xSerie, DateTime xFecha, Moneda xMoneda, int xZ, string xCaja, int xCodTarifa, int xCodVendedor, ClienteActivo xCliente, List<LineaRemito> xLineas, string xComentario, int xCodFormaPago, int xTipoPago)
           : base(xSerie, xFecha, xMoneda, xCliente, xLineas, xCodTarifa, xComentario, xCodVendedor)
        {
            
        }

        public override int NumeroCFE()
        {
            if (IS.Rut.Length == 12)
                return 113;
            return 103;
        }

        public override decimal Importe()
        {
            decimal zSuma = 0;
            foreach (LineaRemito L in base.Lineas)
            {
                zSuma += L.Total();
            }
            return decimal.Round(zSuma, 2);
        }

        public override decimal TotalBruto()
        {
            decimal zSuma = 0;
            foreach (LineaRemito L in base.Lineas)
            {
                zSuma += L.Precio * L.Unidadestotal;
            }
            return decimal.Round(zSuma, 2);
        }

        public override decimal TotalImpuestos()
        {
            decimal zSuma = 0;
            foreach (LineaRemito L in base.Lineas)
            {
                zSuma += (Math.Abs(L.Total()) - Math.Abs(L.Precio));
            }
            zSuma = Math.Abs(zSuma);
            return decimal.Round(zSuma, 2);
        }

        public override decimal Costo()
        {
            decimal zSuma = 0;
            foreach (LineaRemito L in base.Lineas)
            {
                zSuma += L.Costo;
            }
            return Math.Abs(zSuma);
        }

        public override decimal TotalIva()
        {
            return this.Importe() - this.TotalBruto();
        }

        public override decimal TotalCostoIva()
        {
            decimal zSuma = 0;
            foreach (LineaRemito L in base.Lineas)
            {
                zSuma += L.Costeiva;
            }
            return Math.Abs(zSuma);
        }

        public override bool CFE()
        {
            bool zCFE = false;
            if (this.Movimiento == null)
                return false;
            foreach (MovimientoGeneral M in this.Movimiento)
            {
                if (M.CFE != null)
                    zCFE = true;
                else
                    zCFE = false;
            }
            return zCFE;
        }


        public override string Adenda()
        {
            string Salto = "|";
            string Titulo = " **** DOCUMENTOS QUE AFECTA **** " + Salto + "Num.Interno: " + this.Serie + " " + this.Numero + Salto + "Cuenta: " + this.Cliente.IdCliente;
            string Adenda = "";
            int Index = 0;
            if (this.Movimiento == null)
                return Titulo + Salto + "Debito Global";
            else
            {


                foreach (Movimiento M in this.Movimiento)
                {
                    if (Index == 1)
                    {
                        Index = 0;
                        Adenda = Adenda + " " + M.Serie + " " + M.Numero.ToString() + Salto;
                    }
                    else
                    {
                        Index += 1;
                        Adenda = Adenda + " " + M.Serie + " " + M.Numero.ToString();
                    }

                }
                return Titulo + Salto + Salto + Adenda;
            }
        }

        public override int TipoDoc()
        {
            return 19;
        }

        public override int FormaPago()
        {
            if (base.Recibo > 0)
                if (Moneda.Codmoneda == 1)
                    return 1;
                else
                    return 3;
            return 2;
        }

        public override int TipoPago()
        {
            if (base.Recibo > 0)
                return 1;
            return 7;
        }

        public override char Estado()
        {
            if (base.Recibo > 0)
                return 'S';
            return 'P';
        }

        public override string GenApunte()
        {
            if (Recibo > 0)
                return "SALDADO (F/F)";
            return "VENCIMIENTO";
        }

        public override int Remesa()
        {
            if (Recibo > 0)
                return Recibo;
            return -1;
        }

        public override int NumeroZ()
        {
            if (Recibo > 0)
                return base.Z;
            return 0;
        }

        public override string SerieCaja()
        {
            if (Recibo > 0)
                return base.Caja;
            return string.Empty;
        }

        public override string Sudocumento()
        {
            if (Recibo > 0)
                return base.SerieRecibo;
            return string.Empty;
        }
    }
}
