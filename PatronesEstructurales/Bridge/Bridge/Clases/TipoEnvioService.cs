using Bridge.Interfaces;

namespace Bridge.Clases
{
    public class TipoEnvioService
    {
        protected ITipoEstadoEnvio _ITipoEstadoEnvio;


        public string EnvioPorBarco()
        {
            return "El paquete se envio por Barco";
        }

        public string EnvioPorAire()
        {
            return "El paquete se envio por Aire";
        }
        public string EnvioPorTren()
        {
            return "El paquete se envio por Tren";
        }
    }
}
