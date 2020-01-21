using Command.Interfaces;

namespace Command.Clases
{
    public class LanzarGranada : IAccion 
    {
        private int NivelPoder;
        private string Nombre;
        private ObtenerHabilidad receiver;

        public LanzarGranada(ObtenerHabilidad _habilidad, int _iNivelPoder, string _cNombre)
        {
            receiver = _habilidad;
            NivelPoder = _iNivelPoder;
            Nombre = _cNombre;
        }

        public void Accion()
        {
            NivelPoder *= 10;
            receiver.Caminar(NivelPoder, Nombre);
        }
    }
}
