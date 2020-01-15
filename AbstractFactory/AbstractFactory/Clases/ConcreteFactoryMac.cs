using AbstractFactory.Interfaces;

namespace AbstractFactory.Clases
{
    public class ConcreteFactoryMac : IAbstractFactory
    {
        public IProductButton CreateButton()
        {
            return new ConcreteProductMacButton();
        }

        public IProductCheckBox CreateCheckBox()
        {
            return new ConcreteProductMacCheckBox();
        }

        public IProductRadioButton CreateRadioButton()
        {
            return new ConcreteProductMacRadioButton();
        }
    }
}
