namespace Builder.Interfaces
{
    public interface IBuilder
    {
        void Seats();

        void Engiene(ITipoMotor _tipoMotor);

        void Trip();

        void GPS();
    }
}
