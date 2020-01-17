namespace ChainResponsability.Clases
{
    public class Director : AbstractHandler
    {
        public override string Handle(int _costo)
        {
            if (_costo > 15000 && _costo <= 50000)
            {
                return $"El pago con la cantidad de ${ _costo} pesos se autorizo por el Director";
            }
            else
            {
                return $"El pago con la cantidad de ${ _costo} pesos no autorizo por el Director";

            }
        }
    }
}
