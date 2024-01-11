using DesignPatterns.Library.FactoryMethod;

Console.WriteLine("--- Factory Method ---");

List<Creator> creators = new()
{
    new ConcreteCreatorA(),
    new ConcreteCreatorB()
};

foreach (var creator in creators)
{
    creator.FactoryMethod()
           .DoSomething();
}