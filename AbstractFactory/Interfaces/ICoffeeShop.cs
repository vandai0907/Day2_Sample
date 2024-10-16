namespace AbstractFactory.Interfaces
{
    internal interface ICoffeeShop
    {
        ICaffee GetCaffee();
        IOtherDrink GetOtherDrink();
    }
}
