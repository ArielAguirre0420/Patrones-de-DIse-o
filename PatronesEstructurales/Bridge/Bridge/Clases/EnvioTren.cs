using Bridge.Interfaces;

namespace Bridge.Clases
{
    public class EnvioTren : ITipoEstadoEnvio 
    {
        public string CargarPedido()
        {
            return "cargo el pedido por tren";
        }

        public string ProcesarEnvio()
        {
            return "proceso de envio por tren";
        }
        public string ProcesoEntrega()
        {
            return "proceso de entrega por tren";
        }
    }
}
