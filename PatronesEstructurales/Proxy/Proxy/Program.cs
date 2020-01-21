using Proxy.Clases;
using Proxy.Interfaces;
using System;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Inicio();
            Console.ReadKey();
        }

        private static int ValidarLlave()
        {
            int iLlave = 0;
            try
            {
                Console.WriteLine("Introduzca los numeros de la llave para encender el carro");
                iLlave = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Deben ser numeros enteros");
                ValidarLlave();
            }

            return iLlave;
        }

        private static void Inicio()
        {
            int illave = ValidarLlave();

            ILlave autos = new Auto();
            ILlave proxy = new Proxys(autos);
            proxy.EncenderAuto(illave);

            Reinicio();
        }

        private static void Reinicio()
        {
            Console.WriteLine("Presione una tecla para insertar otra llave o 0 para salir");
            string opt = Console.ReadLine();

            if (opt == "0")
            {
                Environment.Exit(-1);
            }
            else
            {
                Console.Clear();
                Inicio();
            }
        }
    }
}
