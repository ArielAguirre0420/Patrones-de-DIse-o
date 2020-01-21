using Command.Interfaces;

namespace Command.Clases
{
    public class FusionAccion
    {
        private IAccion Caminar;
        private IAccion Saltar;
        private IAccion Golpear;
        private IAccion DispararPistola;
        private IAccion LanzarGranada;
        private IAccion DispararRiflePlasma;

        public void SetCaminar(IAccion accion)
        {
            Caminar = accion;
        }

        public void SetSaltar(IAccion accion)
        {
            Saltar = accion;
        }

        public void SetGolpear(IAccion accion)
        {
            Golpear = accion;
        }

        public void SetDispararPistola(IAccion accion)
        {
            DispararPistola = accion;
        }

        public void SetLanzarGranada(IAccion accion)
        {
            LanzarGranada = accion;
        }

        public void SetDispararRiflePlasma(IAccion accion)
        {
            DispararRiflePlasma = accion;
        }

        public void RealizarAccion()
        {
            if (Caminar is IAccion)
            {
                Caminar.Accion();
            }

            if (Golpear is IAccion)
            {
                Golpear.Accion();
            }

            if (Saltar is IAccion)
            {
                Saltar.Accion();
            }

            if (DispararPistola is IAccion)
            {
                DispararPistola.Accion();
            }

            if (LanzarGranada is IAccion)
            {
                LanzarGranada.Accion();
            }

            if (DispararRiflePlasma is IAccion)
            {
                DispararRiflePlasma.Accion();
            }
        }
    }
}
