using Strategy.Interfaces;

namespace Strategy.Clases
{
    public class StrategyJPGE : IGuardar 
    {
        public string Guardar(string nombreImagen)
        {
            return nombreImagen + ".JPGE";
        }
    }
}
