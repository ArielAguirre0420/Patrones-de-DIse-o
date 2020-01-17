namespace AbstractFactory.Interfaces
{
    public interface IAbstractFactory
    {
        IProductButton CreateButton();

        IProductCheckBox CreateCheckBox();

        IProductRadioButton CreateRadioButton();
    }
}
