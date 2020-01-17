namespace ChainResponsability.Clases
{
    public class Subdirector : AbstractHandler
    {
        public override string Handle(int _iCosto)
        {
            if (_iCosto > 10000 && _iCosto <= 15000)
            {
                return $"El pago con la cantidad de ${_iCosto} pesos se autorizo por el Subdirector";
            }
            else
            {
                return base.Handle(_iCosto);
            }
        }
    }
}
