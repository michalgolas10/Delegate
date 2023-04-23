namespace DelegatesPresentation;

public class Program
{    
    static void Main(string[] args)
    {
        PredefinedDelegatesExamples();        

        var someClass = new ClassUsingDelegate();

        Action makeCoffeeDelegate = () => Console.WriteLine("I make coffee");
        makeCoffeeDelegate += MakeTea;

        someClass.DoSomething(makeCoffeeDelegate);

        SomeOperationOnThreeIntegers sumOfThreeIntegers =
            (i1, i2, i3) => i1 + i2 + i3;
        Console.WriteLine(sumOfThreeIntegers(2, 5, 7).ToString());
    }

    private static void PredefinedDelegatesExamples()
    {
        Action<DateTime> outputMonthDayFromDateTime = (DateTime dt) => Console.WriteLine(dt.ToString("M"));
        outputMonthDayFromDateTime(DateTime.UtcNow);

        Func<int, int, int> addTwoNumbers = (number1, number2) => number1 + number2;
        Console.WriteLine(addTwoNumbers(2, 3));

        Converter<int, string> convertNumberToString = (number) => $"The number is: {number}";
        Console.WriteLine(convertNumberToString(5));

        Predicate<int> isEven = (number) => number % 2 == 0;
        Console.WriteLine(isEven(5));

        Comparison<string> compareNumberOfDigits = (string str1, string str2) =>
        str1.Count(c => char.IsDigit(c)).CompareTo(str2.Count(c => char.IsDigit(c)));

        Console.WriteLine(compareNumberOfDigits("alamakota3", "ala1ma2kota"));
    }

    public static void MakeCoffee()
    {
        Console.WriteLine("I make coffee");
    }

    public static void MakeTea()
    {
        Console.WriteLine("I make tea");
    }
}