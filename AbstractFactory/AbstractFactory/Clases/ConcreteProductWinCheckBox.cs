using AbstractFactory.Interfaces;

namespace AbstractFactory.Clases
{
    public class ConcreteProductWinCheckBox : IProductCheckBox 
    {
        public string CreateCheckBox()
        {
            return "Se creo el checkbox para Windows";
        }
    }
}
