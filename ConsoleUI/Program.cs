using CoreLibrary; // core is actually using standard library
//using FrameworkLibrary;

namespace ConsoleUI;

public class Program
{
    static void Main(string[] args)
    {
        Generators generators = new Generators();
        PersonModel person = new PersonModel { Prefix = "Mr.", FirstName = "Mohammad", LastName = "Jabir" };

        string message = generators.WelcomeMessage("Mr.", "Jabir");
        Console.WriteLine(message);

        Console.ReadLine();
    }
}