using DesignPatterns.Library.FactoryMethodExample;

Console.WriteLine("--- Factory Method Example ---");
Console.WriteLine();

List<IDocumentFactory> factories = new()
{
    new ODFDocumentFactory(),
    new PDFDocumentFactory()
};

foreach (var factory in factories)
{
    factory.CreateDocument("El Orígen de las Especies.", "Lorem ipsum...")
           .Render();
}