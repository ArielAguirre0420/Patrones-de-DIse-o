using ChainResponsability.Interfaces;

namespace ChainResponsability.Clases
{
    public class AbstractHandler : IHandler 
    {
        private IHandler _nextHandler;

        public virtual string Handle(int _costo)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(_costo);
            }
            else
            {
                return null;
            }
        }
        
        public IHandler NextLevel(IHandler _handler)
        {
            this._nextHandler = _handler;

            return _handler;
        }

    }
}
