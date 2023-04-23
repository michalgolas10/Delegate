namespace Delegates;

public class CarService
{
    public List<Car> GetDefaultCarsList()
    {
        return Resources.Cars;
    }

    public IEnumerable<string> ApplyConversion(Converter<Car, string> converter) // tu czegos brakuje
    {
        var cars = GetDefaultCarsList();
        return cars.Select(c => converter(c));
    }

    public IEnumerable<Car> ApplyWherePredicate(Predicate<Car> predicate) // tu czegos brakuje
    {
        var cars = GetDefaultCarsList();
        return cars.Where(c => predicate(c));
    }

    public IEnumerable<Car> ApplySortUsingComparison(Comparison<Car> comparison) // tu czegos brakuje
    {
        var cars = GetDefaultCarsList();
        cars.Sort(comparison);
        return cars;
    }
}
