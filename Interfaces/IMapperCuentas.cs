using Aguiñagalde.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Aguiñagalde.Interfaces
{
    public interface IMapperCuentas:IMapper
    {
        object DetalleFactura(string xSerie, int xNumero);
        object ObtenerClientes();
        int ExisteCliente(string xCodCLiente, string xCedula);
        int getClienteIDByCedula(string ID);
        int getClienteIDRut(string ID);
        object getSimpleByID(int xID);
        object getFormaPagoByIDCliente(int xID);
        object getTarifaByCliente(int ID);
        DateTime getFecUltimoPago(int xCodCliente);
        DateTime getFecUltimaCompra(int xCodCliente);
        List<PersonaAutorizada> GetListaAutorizados(int xCodCliente, int xSubCuenta);
        List<object> getInactivos();
        void AddAsociado(object xTitular, object xPersona, List<object> Autorizadas);
        void GuardarBitacora(List<object> xListaCambio,string xNUsuario);
        object getEstadoCuenta(DateTime xFechaDesde, DateTime xFechaHasta, object xCliente, int xSubCuenta);
        List<object> getTiposCta();
        void AgregarOrden(object xOrden);
        List<object> getLinkByCFE(string xSerie, int xNumero);
        List<object> getLinkByFactura(string xSerie, int xNumero);
        void UpdateSubCuenta(object xSCuenta);
        List<SubCuenta > getSubCuentasByCliente(int xCodCliente);
        void AddSubCuenta(object xObj);
        void ModificarAsociado(object xPersona, int xTitular);
        List<object> getMovimientosPendiente(int xCodCliente,bool wCFE);
        void ModificarLimites(object xCliente, decimal xTope, decimal xLimite, string xComentario, int xUsuario, string xLugar);
        void GrabarLlamada(int xIdCLiente, int campania, string xUsuario,string xComentario);
        DataTable getClientesIncobrables();
        string DatosLlamada(int xCodCliente, int xCampania);
        bool PuedoLlamar(int xCliente, int xCampania);
        List<object> getAll();
        decimal getSaldo(int xidCliente,int xCodMoneda);
        List<object> ClientesParaEC();
        void setEnvioEmail(int idCliente);
    }
}
