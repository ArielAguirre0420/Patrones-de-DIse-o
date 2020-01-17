using AbstractFactory.Interfaces;

namespace AbstractFactory.Clases
{
    public class ConcreteProductMacRadioButton : IProductRadioButton
    {
        public string CreateRadioButton()
        {
            return "Se ha creado el RadioButton para Mac";
        }
    }
}
