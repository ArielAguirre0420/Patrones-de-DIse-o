using Bridge.Interfaces;

namespace Bridge.Clases
{
    public class EnvioAire : ITipoEstadoEnvio
    {
        public string CargarPedido()
        {
            return "cargo el pedido por aire";
        }

        public string ProcesarEnvio()
        {
            return "proceso de envio por aire";
        }
        public string ProcesoEntrega()
        {
            return "proceso de entrega por aire";
        }
    }
}
