using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Clases
{
    public class Alarma
    {
        private IAlarmaEstado Estado = null;

        public Alarma(IAlarmaEstado _Estado)
        {
            Estado = _Estado;
        }

        public void Activar()
        {
            this.Estado.Activar();
        }

        public void Desactivar()
        {
            this.Estado.Desactivar();
        }

        public void CambiarEstado(IAlarmaEstado _Estado)
        {
            this.Estado = _Estado;
        }

    }
}
