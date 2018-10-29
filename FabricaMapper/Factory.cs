using Aguiñagalde.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aguiñagalde.SQL;


namespace Aguiñagalde.FabricaMapper
{
    public class Factory
    {
        public static IMapper getMapper(Type Class)
        {
            switch (Class.Name)
            {
                case "GCliente": return (IMapper)new CuentasMapper();

                //case "GCuentas": return (IMapper)new CuentasMapper();

                case "GCobros": return (IMapper)new CobrosMapper();

                case "GTeledata": return (IMapper)new TeledataMapper();

                case "GInco": return (IMapper)new IncoMapper();
            }
            return null;
        }
    }
}
