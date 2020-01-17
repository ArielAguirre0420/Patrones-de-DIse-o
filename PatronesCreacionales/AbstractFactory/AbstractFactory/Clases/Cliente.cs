using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Clases
{
    public class Cliente
    {
        public void Main()
        {
          
            Console.WriteLine("Client: Instancia la fabrica Windows");
            ClientMethod(new ConcreteFactoryWin());
            Console.WriteLine();

            Console.WriteLine("Client: Instancia la fabrica Mac");
            ClientMethod(new ConcreteFactoryMac());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var _CreateButton = factory.CreateButton();
            var _CreateCheckbox = factory.CreateCheckBox();
            var _CreateRadioButton = factory.CreateRadioButton();

            Console.WriteLine(_CreateButton.CreateButton());
            Console.WriteLine(_CreateCheckbox.CreateCheckBox());
            Console.WriteLine(_CreateRadioButton.CreateRadioButton());

        }
    }
}
