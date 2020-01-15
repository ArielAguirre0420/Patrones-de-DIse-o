using AbstractFactory.Interfaces;

namespace AbstractFactory.Clases
{
    public class ConcreteFactoryWin : IAbstractFactory
    {
        public IProductButton CreateButton()
        {
            return new ConcreteProductWinButton();
        }

        public IProductCheckBox CreateCheckBox()
        {
            return new ConcreteProductWinCheckBox();
        }

        public IProductRadioButton CreateRadioButton()
        {
            return new ConcreteProductWinRadioButton();
        }
    }
}
