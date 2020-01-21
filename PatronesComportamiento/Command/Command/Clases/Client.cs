namespace Command.Clases
{
    public class Client
    {
        FusionAccion fusionAccion = new FusionAccion();
        ObtenerHabilidad obtenerHabilidad = new ObtenerHabilidad();

        public void RealizarAccion(int _iGuerrero, int _iAccion, string _cNombre)
        {
            switch (_iAccion)
            {
                case 1:
                    fusionAccion.SetCaminar(new Caminar(obtenerHabilidad, _iGuerrero, _cNombre)); 
                    break;
                case 2:
                    fusionAccion.SetSaltar(new Saltar(obtenerHabilidad, _iGuerrero, _cNombre)); 
                    break;
                case 3:
                    fusionAccion.SetGolpear(new Golpear(obtenerHabilidad, _iGuerrero, _cNombre)); 
                    break;
                case 4:
                    fusionAccion.SetDispararPistola(new DispararPistola(obtenerHabilidad, _iGuerrero, _cNombre)); 
                    break;
                case 5:
                    fusionAccion.SetLanzarGranada(new LanzarGranada(obtenerHabilidad, _iGuerrero, _cNombre)); 
                    break;
                case 6:
                    fusionAccion.SetDispararRiflePlasma(new DispararRiflePlasma(obtenerHabilidad, _iGuerrero, _cNombre)); 
                    break;
            }
            fusionAccion.RealizarAccion();
        }
    }
}
