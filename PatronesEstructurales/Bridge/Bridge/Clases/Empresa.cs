using Bridge.Interfaces;

namespace Bridge.Clases
{
    public class Empresa : TipoEnvioService
    {
        protected IPaqueteria paqueteria;

        public Empresa(IPaqueteria _paqueteria)
        {
            this.paqueteria = _paqueteria;
        }

        public virtual string RecogerPedido()
        {
            return "La empresa estafeta empezo el proceso de envio" + ","+ paqueteria.RecogerPedido() + ", " +
                paqueteria.EnviarPedido() + ", " + paqueteria.EntregarPedido();
        }


    }
}
