using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Clases
{
    public class GuardadoService
    {
        private  IGuardar _guardar;

        public void SetStrategy(string opt)
        {
            _guardar = new Factory().opciones(opt);  //Buscar a que  tipo de archivo va instanciar
        } 

        public void send(string cNombre)
        {
            string texto = _guardar.Guardar(cNombre); // optine el nombre del archivo

            imprimirMensaje(texto);
        }

        private  void imprimirMensaje(string mensajeImagen)
        {
            Console.WriteLine("Se ha guardado la imagen {0}", mensajeImagen);
        }

    }
}
