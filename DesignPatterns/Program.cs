using DesignPatterns.Library.AbstractFactory.Factories;
using DesignPatterns.Library.AbstractFactory.Products;

Console.WriteLine("--- Abstract Factory ---");

IAbstractFactory factory = new ConcreteFactory4();

List<IProduct> products = new()
{
    factory.CreateProductA(),
    factory.CreateProductB()
};

foreach (var product in products)
{
    product.DoSomething();
}