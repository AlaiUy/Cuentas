using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Interfaces
{
    public interface ImapperTeledata:IMapper
    {
        void setIngresarLlamada(object xCliente,int xCampania);

        bool ExisteCliente(int xIdCliente, int xCampania);

        void BorrarCliente(int xIdCliente, int xCampania);


    }
}
