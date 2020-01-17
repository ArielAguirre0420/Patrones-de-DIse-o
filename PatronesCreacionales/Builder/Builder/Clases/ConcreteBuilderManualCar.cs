using Builder.Interfaces;

namespace Builder.Clases
{
    public class ConcreteBuilderManualCar : IBuilder 
    {
        private ManualCar _manualcar = new ManualCar();

        public ConcreteBuilderManualCar()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._manualcar = new ManualCar();
        }

        // All production steps work with the same product instance.
        public void Seats()
        {
            this._manualcar.Add("Agregando Seats");
        }

        public void Engiene(ITipoMotor _tipoMotor)
        {
            this._manualcar.Add("Agregando Engiene");
        }

        public void Trip()
        {
            this._manualcar.Add("Agregando Trip");
        }

        public void GPS()
        {
            this._manualcar.Add("Agregando GPS");
        }


        public ManualCar GetProduct()
        {
            ManualCar result = this._manualcar;

            this.Reset();

            return result;
        }
    }
}
