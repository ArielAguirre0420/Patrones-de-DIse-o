using Bridge.Interfaces;

namespace Bridge.Clases
{
    public class DHL : IPaqueteria 
    {
        public ITipoEstadoEnvio tipoEstadoEnvio;

        public DHL(ITipoEstadoEnvio _tipoEstadoEnvio)
        {
            this.tipoEstadoEnvio = _tipoEstadoEnvio;
        }
        public string RecogerPedido()
        {
            return tipoEstadoEnvio.CargarPedido();
            // return"recoger pedido";
        }

        public string EnviarPedido()
        {
            return "enviar pedido";
        }
        public string EntregarPedido()
        {
            return "entreegar pedido";
        }


    }
}
