namespace Delegates;

public class CarService
{
    public List<Car> GetDefaultCarsList()
    {
        return Resources.Cars;
    }

    public IEnumerable<string> ApplyConversion(...) // tu czegos brakuje
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Car> ApplyWherePredicate(...) // tu czegos brakuje
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Car> ApplySortUsingComparison(...) // tu czegos brakuje
    {
        throw new NotImplementedException();
    }
}
