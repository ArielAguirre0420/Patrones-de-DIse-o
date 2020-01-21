namespace Bridge.Interfaces
{
    public interface ITipoEstadoEnvio
    {
        string CargarPedido();

        string ProcesarEnvio();

        string ProcesoEntrega();
    }
}
