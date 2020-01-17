using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interfaces
{
    public interface IAzureObservador
    {
        void addObsevador(IObservador observador);
        void DeleteObsevador(IObservador observador);
        void Notificar(IObservador observador);
    }
}
