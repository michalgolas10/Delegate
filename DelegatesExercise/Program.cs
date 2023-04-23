namespace Delegates;

public class Program
{
    private static CarService _carService;

    public static void Main()
    {
        RegisterCarService();

        while (true)
        {
            Menu();
        }
    }

    private static void RegisterCarService()
    {
        _carService = new CarService();

        // TODO - cwiczenie nr 2 z eventem        
    }

    private static void Menu()
    {
        Console.WriteLine("Select option: ");
        Console.WriteLine("[1] List cars in default order.");
        Console.WriteLine("[2] List cars sorted by...");
        Console.WriteLine("[3] List cars where...");
        Console.WriteLine("[4] List cars, select property...");

        var selection = Console.ReadKey();

        switch (selection.KeyChar)
        {
            case '1':
                ListCarsInDefaultOrder();
                break;
            case '2':
                ListCarsSortedBy();
                break;
            case '3':
                ListCarsWhere();
                break;
            case '4':
                ListCarsSelectProperty();
                break;
            default:
                throw new NotImplementedException();
        };
    }

    private static void ListCarsInDefaultOrder()
    {
        OutputCarsToConsole(_carService.GetDefaultCarsList());
    }

    private static void ListCarsSortedBy()
    {
        Console.WriteLine();
        Console.WriteLine("[1] ...manufacturer");
        Console.WriteLine("[2] ...model");
        Console.WriteLine("[3] ...productionYear");
        Console.WriteLine("[4] ...engineVolumeInCubicCentimeters");

        var selection = Console.ReadKey();

        // TODO
        switch (selection.KeyChar)
        {
            case '1':
                // tu czegos brakuje
                break;
            case '2':
                // tu czegos brakuje
                break;
            case '3':
                // tu czegos brakuje
                break;
            case '4':
                // tu czegos brakuje
                break;
            default:
                throw new NotImplementedException();
        };

        OutputCarsToConsole(_carService.ApplySortUsingComparison(...)); // tu czegos brakuje
    }

    private static void ListCarsWhere()
    {
        Console.WriteLine();
        Console.WriteLine("[1] ...manufacturer is Ford");
        Console.WriteLine("[2] ...model name begins with 'C'");
        Console.WriteLine("[3] ...productionYear is before 2000");
        Console.WriteLine("[4] ...engineVolumeInCubicCentimeters is over 2000");

        var selection = Console.ReadKey();        

        switch (selection.KeyChar)
        {
            case '1':
                // tu czegos brakuje
                break;
            case '2':
                // tu czegos brakuje
                break;
            case '3':
                // tu czegos brakuje
                break;
            case '4':
                // tu czegos brakuje
                break;
            default:
                throw new NotImplementedException();
        };

        OutputCarsToConsole(_carService.ApplyWherePredicate(...); // tu czegos brakuje
    }

    private static void ListCarsSelectProperty()
    {
        Console.WriteLine();
        Console.WriteLine("[1] ...manufacturer");
        Console.WriteLine("[2] ...model");
        Console.WriteLine("[3] ...productionYear");
        Console.WriteLine("[4] ...engineVolumeInCubicCentimeters");

        var selection = Console.ReadKey();        

        switch (selection.KeyChar)
        {
            case '1':
                // tu czegos brakuje
                break;
            case '2':
                // tu czegos brakuje
                break;
            case '3':
                // tu czegos brakuje
                break;
            case '4':
                // tu czegos brakuje
                break;
            default:
                throw new NotImplementedException();
        };

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        foreach (var item in _carService.ApplyConversion(...) // tu czegos brakuje
        {
            Console.WriteLine(item);
            Console.WriteLine($"########################################");
        }

        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void OutputCarsToConsole(IEnumerable<Car> list)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;

        foreach (var car in list)
        {
            Console.WriteLine($"Manufacturer = {car.Manufacturer}");
            Console.WriteLine($"Model = {car.Model}");
            Console.WriteLine($"ProductionYear = {car.ProductionYear}");
            Console.WriteLine($"EngineVolumeInCubicCentimeters={car.EngineVolumeInCubicCentimeters}");
            Console.WriteLine($"########################################");
        }

        Console.ForegroundColor = ConsoleColor.White;
    }
}