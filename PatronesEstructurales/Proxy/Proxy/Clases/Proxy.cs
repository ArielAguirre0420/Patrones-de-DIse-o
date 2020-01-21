using Proxy.Interfaces;
using System;

namespace Proxy.Clases
{
    public class Proxys : ILlave 
    {
        private ILlave _Auto;
        private ILlave _Motor;

        public Proxys(ILlave auto)
        {
            _Auto = auto;
        }

        public void EncenderAuto(int _iLlave)
        {
            if (ValidarLlaveCorrecta(_iLlave))
            {
                Console.WriteLine("La llave es la correcta");

                _Auto.EncenderAuto(_iLlave);

                _Motor = new Motor();
                _Motor.EncenderAuto(_iLlave);
            }
            else
            {
                Console.WriteLine("No es la llave correcta");
            }
        }

        private bool ValidarLlaveCorrecta(int _iLlave)
        {
            int iLlave = 20012020;
            Console.WriteLine("Validando si es la llave correcta.");

            return iLlave == _iLlave;
        }
    }
}
