using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Clases
{
    public class Cliente
    {
        public void Main()
        {
            Console.WriteLine("App: ejecutando windows.");
            ClientCode(new WindowsDialog());

            Console.WriteLine("");

            Console.WriteLine("App: ejecutando HTML.");
            ClientCode(new WebDialog());
        }

     
        public void ClientCode(Messaje Messaje)
        {
            Console.WriteLine("Client: Muestrame el mensaje\n" + Messaje.SomeOperation());
            
        }
    }
}
