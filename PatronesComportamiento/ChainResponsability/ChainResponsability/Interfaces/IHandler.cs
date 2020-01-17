namespace ChainResponsability.Interfaces
{
    public interface IHandler
    {
        IHandler NextLevel(IHandler handler);

        string Handle(int costo);
    }
}
