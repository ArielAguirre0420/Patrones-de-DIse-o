using Builder.Interfaces;

namespace Builder.Clases
{
    public class ConcreteBuilderCar : IBuilder 
    {
        private ITipoMotor tipoMotor;
        private Car _car = new Car();

        public ConcreteBuilderCar()
        {
            this.Reset();
        }

        public ConcreteBuilderCar(ITipoMotor tipoMotor)
        {
            this.tipoMotor = tipoMotor;
        }

        public void Reset()
        {
            this._car = new Car();
        }

        // All production steps work with the same product instance.
        public void Seats()
        {
            this._car.Add("Agregando Seats");
        }

        public void Engiene(ITipoMotor tipoMotor)
        {
            this._car.Add("Agregando Engiene");
        }

        public void Trip()
        {
            this._car.Add("Agregando Trip");
        }

        public void GPS()
        {
            this._car.Add("Agregando GPS");
        }


        public Car GetProduct()
        {
            Car result = this._car;

            this.Reset();

            return result;
        }
    }
}
