using System;

namespace ChainResponsability.Clases
{
    public class Autorizada
    {
        public void main(AbstractHandler handler, int _iCosto, string _cConcepto)
        {
            var result = handler.Handle(_iCosto);

            Console.WriteLine("\n" + _cConcepto + "\n" + result);
        }
    }
}
