using AbstractFactory.Interfaces;

namespace AbstractFactory.Clases
{
    class ConcreteProductMacButton : IProductButton
    {
        public  string CreateButton()
        {
            return "Se ha creado el Button para Mac";
        }
    }
}
