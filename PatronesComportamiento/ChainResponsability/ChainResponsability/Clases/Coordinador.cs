namespace ChainResponsability.Clases
{
    public class Coordinador : AbstractHandler
    {
        public override string Handle(int _iCosto)
        {
            if (_iCosto > 0 && _iCosto <= 5000)
            {
                return $"El pago con la cantidad de ${_iCosto} pesos se autorizo por el coordinador";
            }
            else
            {
                return base.Handle(_iCosto);
            }
        }

    }
}
