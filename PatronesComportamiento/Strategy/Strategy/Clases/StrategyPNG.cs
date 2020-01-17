using Strategy.Interfaces;

namespace Strategy.Clases
{
    public class StrategyPNG : IGuardar
    {
        public string Guardar(string nombreImagen)
        {
            return nombreImagen + ".PNG";
        }
    }
}
