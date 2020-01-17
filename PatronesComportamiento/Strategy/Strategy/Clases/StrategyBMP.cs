using Strategy.Interfaces;

namespace Strategy.Clases
{
    public class StrategyBMP : IGuardar
    {
        public string Guardar(string nombreImagen)
        {
            return nombreImagen + ".BMP";
        }
    }
}
