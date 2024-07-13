using Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        ExampleClass exampleClass = new ExampleClass("Büşraa", "Güneş");
        exampleClass.Person();

        Console.WriteLine(exampleClass.Meslek);
    }
}