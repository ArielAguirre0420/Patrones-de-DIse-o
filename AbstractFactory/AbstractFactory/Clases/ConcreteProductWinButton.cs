using AbstractFactory.Interfaces;

namespace AbstractFactory.Clases
{
    public class ConcreteProductWinButton : IProductButton 
    {
        public string CreateButton()
        {
            return "Se ha creado el Button para Windows";
        }
    }
}
