using Aguiñagalde.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Interfaces
{
    public interface IMapperInco:IMapper
    {

        int getClienteIDByCedula(string xID);

        int getClienteIDRut(string xID);

        object getSimpleByID(int xID);

        FPago getFormaPagoByIDCliente(int xID);

        Tarifa getTarifaByCliente(int ID);

        DateTime getFecUltimoPago(int xCodCliente);
        EstadoCuenta getEstadoCuenta(DateTime xFechaDesde, DateTime xFechaHasta, ClienteInco xCliente, int xSubCuenta);
    }
}
