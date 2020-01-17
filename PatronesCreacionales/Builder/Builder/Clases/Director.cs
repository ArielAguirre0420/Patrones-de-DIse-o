using Builder.Interfaces;

namespace Builder.Clases
{
    public class Director
    {
        private IBuilder _builder;
        private ITipoMotor _tipomotor;

        public IBuilder Builder
        {
            set { _builder = value; }
        }
           
        public void CarBuilder()
        {
            this._builder.Seats();
            this._builder.Engiene( _tipomotor);
            this._builder.Trip();
            this._builder.GPS();
        }
        public void ManualCarBuilder()
        {
            this._builder.Seats();
            this._builder.Engiene(_tipomotor);
            this._builder.Trip();
            this._builder.GPS();
        }
    }
}
