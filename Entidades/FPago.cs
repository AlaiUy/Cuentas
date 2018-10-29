using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class FPago : IComparable
    {
        string mID;

        public string ID
        {
            get { return mID; }
            set { mID = value; }
        }

        string mNombre;

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public FPago()
        {

        }

        public FPago(string xID,string xNombre)
        {
            mNombre = xNombre;
            mID = xID;
        }

        public override string ToString()
        {
            return mNombre;
        }



        public int CompareTo(object obj)
        {
            if (obj == null)
                return 0;
            FPago FP = (FPago)obj;
            if (Convert.ToInt32(FP.ID) < Convert.ToInt32(this.ID))
                return 1;
            else
                return -1;
        }
    }

   


}
