using System;

namespace Command.Clases
{
    public class ObtenerHabilidad
    {
        public void Caminar(int _iNivelPoder, string _cNombrePersona)
        {
            Console.WriteLine($"{_cNombrePersona} caminando con velocidad de poder {_iNivelPoder}");
        }
        public void Saltar(int _iNivelPoder, string _cNombrePersona)
        {
            Console.WriteLine($"{_cNombrePersona} saltando con nivel de poder {_iNivelPoder}");
        }
        public void Golpear(int _iNivelPoder, string _cNombrePersona)
        {
            Console.WriteLine($"{_cNombrePersona} golpeando con nivel de poder {_iNivelPoder}");
        }
        public void DispararPistola(int _iNivelPoder, string _cNombrePersona)
        {
            Console.WriteLine($"{_cNombrePersona} disparando pistola con nivel de poder {_iNivelPoder}");
        }
        public void LanzarGranadas(int _iNivelPoder, string _cNombrePersona)
        {
            Console.WriteLine($"{_cNombrePersona} lanza granada con nivel de poder {_iNivelPoder}");
        }
        public void DispararRiflePlasma(int _iNivelPoder, string _cNombrePersona)
        {
            Console.WriteLine($"{_cNombrePersona} dispara rifle de plasma con nivel de poder {_iNivelPoder}");
        }
    }
}
