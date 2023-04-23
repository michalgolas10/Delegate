namespace DelegatesPresentation;

public class Program
{    
    static void Main(string[] args)
    {
        var someClass = new ClassUsingDelegate();

        SomethingToDo makeCoffeeDelegate = MakeCoffee;

        someClass.DoSomething(makeCoffeeDelegate);
    }

    public static void MakeCoffee()
    {
        Console.WriteLine("I make coffee");
    }
}