using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class Agenda
    {
        private DateTime _Fecha;
        private List<Agendalin> _Lineas;

        public List<Agendalin> Lineas
        {
            get
            {
                return _Lineas;;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
            }
        }

        public Agenda()
        {
            _Lineas = new List<Agendalin>();
        }

        public void AgregarLineas(List<Agendalin> xLineas)
        {
            foreach (Agendalin L in xLineas)
                Agregarlinea(L);
        }

        public void Agregarlinea(Agendalin xLinea)
        {
            _Lineas.Add(xLinea);
        }

        public DataTable Impresion()
        {
            DataTable T = new DataTable("Agenda");
            DataColumn ColFecha = T.Columns.Add("CLIENTE", System.Type.GetType("System.String"));
            DataColumn ColEstado = T.Columns.Add("DIRECCION", Type.GetType("System.String"));
            DataColumn ColMov = T.Columns.Add("NOMBRE", Type.GetType("System.String"));
            DataColumn ColSer = T.Columns.Add("FUV", Type.GetType("System.String"));
            DataColumn ColNum = T.Columns.Add("PESOS", Type.GetType("System.String"));
            DataColumn ColDebe = T.Columns.Add("DOLARES", Type.GetType("System.String"));
            DataColumn ColHaber = T.Columns.Add("COMENTARIO", Type.GetType("System.String"));

            if (_Lineas.Count > 0)
            {
                DataRow R;
                foreach (Agendalin L in _Lineas)
                {
                    R = T.NewRow();
                    R["CLIENTE"] = L.Codcliente;
                    R["DIRECCION"] = L.Dircobro;
                    R["NOMBRE"] = L.Nombre;
                    if(L.Pesos < 10)
                        R["PESOS"] = String.Format(CultureInfo.InvariantCulture, "{0:0.00}", L.Pesos, 2);
                    else
                        R["PESOS"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", L.Pesos, 2);
                    if(L.Dolares < 10)
                        R["DOLARES"] = String.Format(CultureInfo.InvariantCulture, "{0:0.00}", L.Dolares, 2);
                    else
                        R["DOLARES"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", L.Dolares, 2);
                    R["COMENTARIO"] = L.Comentario;
                    T.Rows.Add(R);
                }
            }
            return T;
        }

    }
}
