using Bridge.Interfaces;
using System;

namespace Bridge.Clases
{
    public class Client
    {
        
        public string ClientCode(Empresa empresa)
        {
        
            ITipoEstadoEnvio i = new EnvioBarco();
            //DHL.EnviarPedido();
            return "";

        }

        
    }
}
