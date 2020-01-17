using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Clases
{
    public class Factory
    {
       public  IGuardar opciones(string _opt)
        {
            IGuardar Instancia = null;

            switch (_opt)
            {
                case "1":
                    Instancia = new StrategyBMP();
                    break;
                case "2":
                    Instancia = new StrategyJPGE();
                    break;
                case "3":
                    Instancia = new StrategyPNG();
                    break;
                default: 
                    Console.WriteLine("Elija un número del 1 al 3"); break;
            }

            return Instancia;
        }
    }
}
