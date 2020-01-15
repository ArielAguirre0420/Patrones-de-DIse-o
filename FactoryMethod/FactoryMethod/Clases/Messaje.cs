using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Clases
{
    public abstract class Messaje
    {
        public abstract IButton FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Messaje: Presione el botón aceptar para continuar "
                + product.OnClick();

            return result;
        }
    }
}
