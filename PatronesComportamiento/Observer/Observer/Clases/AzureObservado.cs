using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer.Clases
{
    public class AzureObservado 
    {
        List<IObservador> lstObservadores = new List<IObservador>();

        public void addObsevador(IObservador observador)
        {
            this.lstObservadores.Add(observador);
        }

        public void DeleteObsevador(IObservador observador)
        {
            this.lstObservadores.Remove(observador);
        }

        public void Notificar()
        {
           Console.WriteLine("Se sube codigo");

            foreach (var observador in lstObservadores)
            {
                
                observador.Actualizar();
            }
        }

        public void SubirCambios()
        {
            Notificar();
        }

     
    }
}
