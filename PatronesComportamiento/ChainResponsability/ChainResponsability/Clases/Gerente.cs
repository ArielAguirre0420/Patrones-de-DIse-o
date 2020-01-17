namespace ChainResponsability.Clases
{
    public class Gerente : AbstractHandler
    {
        public override string Handle(int _iCosto)
        {
            if (_iCosto > 5000 && _iCosto <= 10000)
            {
                return $"El pago con la cantidad de ${_iCosto} pesos se autorizo por el Gerente";
            }
            else
            {
                return base.Handle(_iCosto);
            }
        }
    }
}
