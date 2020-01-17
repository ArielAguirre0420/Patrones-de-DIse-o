using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Clases
{
    public class Desactivada : IAlarmaEstado 
    {
        public IAlarmaEstado estadoAlarma = null;
        private Alarma context;

        public void SetContext(Alarma _context)
        {
            context = _context;
        }

        public void Activar()
        {
            Activada state = new Activada();
            state.SetContext(context);
            context.CambiarEstado(state);

            Console.WriteLine("Alarma activada");
        }

        public void Desactivar()
        {
            Console.WriteLine("La alarma esta ya esta en estado desactivada");
        }
    }
}
