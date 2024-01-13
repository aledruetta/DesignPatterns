using DesignPatterns.Library.AbstractFactoryExample.Factories;
using DesignPatterns.Library.AbstractFactoryExample.Products;

Console.WriteLine("--- Abstract Factory Example ---");

IWindowElementFactory factory = new FlatFactory();

List<IWindowElement> products = new()
{
    factory.CreateButton(),
    factory.CreateNavBar()
};

foreach (var product in products)
{
    product.DoSomething();
}