using Bridge.Clases;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //TipoEnvioService tipoEnvioService = new TipoEnvioService();


            Client client = new Client();
            
            inicio();

            Empresa empresa;

            empresa = new Empresa(new Estafeta());
            client.ClientCode(empresa);
            Console.ReadKey();
        }

        public static void inicio()
        {
            EnvioAire envioAire = new EnvioAire();
            EnvioBarco envioBarco = new EnvioBarco();
            EnvioTren envioTren = new EnvioTren();

            Console.WriteLine("\nEliga el número que corresponda al formato en el que desea guardar la imagen" +
               "\n1. Fedex" +
               "\n2. DHL" +
               "\n3. Estafeta");
            string opt = Console.ReadLine();


            switch (opt)
            {
                case "1":
                    Console.WriteLine("la empresa fedex realizara un envio por mar");
                    Console.WriteLine(envioBarco.CargarPedido());
                    Console.WriteLine(envioBarco.ProcesarEnvio());
                    Console.WriteLine(envioBarco.ProcesoEntrega());
                    break;
                case "2":
                    Console.WriteLine("la empresa DHL realizara un envio por aire");
                    Console.WriteLine(envioAire.CargarPedido());
                    Console.WriteLine(envioAire.ProcesarEnvio());
                    Console.WriteLine(envioAire.ProcesoEntrega());
                    Console.WriteLine("la empresa DHL realizara un envio por mar");
                    Console.WriteLine(envioAire.CargarPedido());
                    Console.WriteLine(envioAire.ProcesarEnvio());
                    Console.WriteLine(envioAire.ProcesoEntrega());
                    break;
                case "3":
                    Console.WriteLine("la empresa Estafeta realizara un envio por tren");
                    Console.WriteLine(envioTren.CargarPedido());
                    Console.WriteLine(envioTren.ProcesarEnvio());
                    Console.WriteLine(envioTren.ProcesoEntrega());
                    break;
                default:
                    Console.WriteLine("Elija un número del 1 al 3");
                    break;
            }
        }
    }
}
