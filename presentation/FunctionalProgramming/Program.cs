namespace FunctionalProgramming;

internal class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int> Add = (n1, n2) => n1 + n2;
        Func<int, int, int> Subtract = (n1, n2) => n1 - n2;
        Func<int, int, int> Multiply = (n1, n2) => n1 * n2;
        Func<int, int, int> Divide = (n1, n2) => n1 / n2;

        Func<string> GetTextFromConsole = () => Console.ReadLine();
        Func<string, int> ParseTextToInt = text => int.Parse(text);
        Action<int> WriteNumberToConsole = number => Console.WriteLine(number);
        Action<string> WriteTextToConsole = text => Console.WriteLine(text);

        Func<(int, int)> GetParameters = () =>
        {
            WriteTextToConsole("Please provide two numbers");
            return (ParseTextToInt(GetTextFromConsole()), ParseTextToInt(GetTextFromConsole()));
        };

        Func<int, (int, int), int> GetSelectedOperationResultForInputs = (operationIndex, parameters) =>
        {
            return operationIndex switch
            {
                1 => Add(parameters.Item1, parameters.Item2),
                2 => Subtract(parameters.Item1, parameters.Item2),
                3 => Multiply(parameters.Item1, parameters.Item2),
                4 => Divide(parameters.Item1, parameters.Item2),
                _ => throw new NotImplementedException()
            }; ;
        };

        Func<int> GetSelectedOperationIndex = () =>
        {
            WriteTextToConsole("Select operation to perform: ");
            WriteTextToConsole("[1] Add");
            WriteTextToConsole("[2] Subtract");
            WriteTextToConsole("[3] Multiply");
            WriteTextToConsole("[4] Divide");

            return ParseTextToInt(GetTextFromConsole());
        };

        Action<int> WriteResultToConsole = (result) => 
        {
            WriteTextToConsole("The result is: ");
            WriteNumberToConsole(result);
        };

        WriteResultToConsole(GetSelectedOperationResultForInputs(GetSelectedOperationIndex(), GetParameters()));
    }        
}