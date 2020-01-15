using AbstractFactory.Interfaces;

namespace AbstractFactory.Clases
{
    public class ConcreteProductWinRadioButton : IProductRadioButton
    {
        public string CreateRadioButton()
        {
            return "Se ha creado el RadioButton para Windows";
        }
    }
}
