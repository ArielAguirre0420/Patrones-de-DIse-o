using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    public class EnviarCorreo : IObservador 
    {
        public void Actualizar()
        {
            Console.WriteLine("Se ha enviado el correo");
        }
    }
}
