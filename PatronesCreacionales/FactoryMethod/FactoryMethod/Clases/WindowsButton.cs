using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Clases
{
    public class WindowsButton : IButton 
    {
        public string OnClick()
        {
            return "{Se creó el botón para Windows}";
        }
    }
}
