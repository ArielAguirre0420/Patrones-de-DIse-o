using Bridge.Interfaces;

namespace Bridge.Clases
{
    public class EnvioBarco : ITipoEstadoEnvio
    {
        public string CargarPedido()
        {
            return "cargo el pedido por barco";
        }

        public string ProcesarEnvio()
        {
            return "proceso de envio por barco";
        }
        public string ProcesoEntrega()
        {
            return "proceso de entrega por barco";
        }
    }
}
