using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Aguiñagalde.Entidades;

namespace Aguiñagalde.Interfaces
{
    public interface IMapperCobros:IMapper
    {


        object getCajaByID(string xNombreMaquina,object xUser);
        List<object> getListaMonedas();
        int GenerarRemitos(object xRe, object xUsuario, object xClaves, object xCajaGeneral, bool xImprimir);
        object getClavesEmpresa();
        object getUsuario(string xUsuario, string xPassword);
        
        void CambiarClaveUsuario(int xcodUsuario, string xpassword);
        object getAllRecibos(int xZ, string xCaja);

        object getAgenda(DateTime xfecha);
        
        object getMonedaByCliente(int xCodCliente);
        List<object> getFormasPago();
        List<object> getTarifasVenta();
        List<object> getMovimientosByRecibo(string xSerie, int xID, object xCliente);
        void UpdateParameters(List<Config> xLista, string xNombreEquipo);
        //void AgregarAgengaLin(object xAL);
        void AgregarAgengaLin(string xCodCLiente, DateTime xFechaVisita, int xCodUsuario, string xDirCobro, string xComentario);
        object getContadosPendientes();
        object getCajaDia(string xNombreMaquina, object xUser);
        object DetallePosicion(string xSerie, int xNumero);
        void SaldarCP(List<object> xLista, object xCaja);
        object getArqueoByID(int xIdArqueo,string xCaja);
        List<object> getMovimientosByArqueo(int numero,string xCaja);
        int getNumeroUsuarioArqueo(int xIdArqueo,string xCaja);
        object getUsuarioByVendedor(int xVendedor);
        decimal getImportePendiente(string xSerie, string xNumero);
        int getz(Caja xCaja);

        object Parametros(string xNombreMaquina, List<int> Indexs);
    }
}
