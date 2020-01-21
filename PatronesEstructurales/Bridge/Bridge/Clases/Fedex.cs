using Bridge.Interfaces;

namespace Bridge.Clases
{
    public class Fedex : IPaqueteria
    {
        public string RecogerPedido()
        {
            return "recoger pedido";
        }

        public string EnviarPedido()
        {
            return "enviar pedido";
        }
        public string EntregarPedido()
        {
            return "entregar pedido";
        }
    }
}
