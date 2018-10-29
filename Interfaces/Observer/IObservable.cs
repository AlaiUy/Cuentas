using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Interfaces
{
    public interface IObservable
    {
        void Register(IObserver xObserver);
        void UnRegister(IObserver xObserver);
        void notifyObservers();
        void notifyObservers(Object Data);
    }
}
