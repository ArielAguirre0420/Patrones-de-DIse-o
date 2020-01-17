using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Clases
{
    public class Activada : IAlarmaEstado 
    {
        private Alarma context;

        public void SetContext(Alarma _context)
        {
            context = _context;
        }

        public void Activar()
        {
            Console.WriteLine("La alarma esta en estado activo");
        }

        public void Desactivar()
        {
            Desactivada state = new Desactivada();

            state.SetContext(context);
            context.CambiarEstado(state);
            Console.WriteLine("La alarma esta en estado desactivada");
        }
    }
}
