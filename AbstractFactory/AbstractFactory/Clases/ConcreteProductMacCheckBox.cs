using AbstractFactory.Interfaces;

namespace AbstractFactory.Clases
{
    public class ConcreteProductMacCheckBox : IProductCheckBox 
    {
        public string CreateCheckBox()
        {
            return "Se creo el checkbox para Mac";
        }
    }
}
