using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Clases
{
    public class WindowsDialog : Messaje
    {
        public override IButton FactoryMethod()
        {
            return new WindowsButton();
        }
    }
}
