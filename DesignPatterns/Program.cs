// run: 'dotnet run <opt1> <opt2>'
// example: 'dotnet run a 1'
// example: 'dotnet run b 3'

using DesignPatterns.Library.Builder;

char? opt1 = args[0]?[0];
char? opt2 = args[1]?[0];

Console.WriteLine("--- Builder ---");
Console.WriteLine();

Builder builder;

switch (opt1)
{
    case 'a':
        builder = new ConcreteBuilderA();
        break;
    case 'b':
        builder = new ConcreteBuilderB();
        break;
    default:
        throw new NotImplementedException($"Option is not implemented: '{opt1}'");
}

Director director = new(builder, opt2);
director.Construct();

Product product = builder.GetProduct();
Console.WriteLine(product);