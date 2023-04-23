namespace Delegates;

internal static class Resources
{
    public static List<Car> Cars = new List<Car>()
    {
        new Car
        {
            Manufacturer = "Opel",
            Model = "Vectra",
            ProductionYear = 1997,
            EngineVolumeInCubicCentimeters = 1600
        },
        new Car
        {
            Manufacturer = "Mercedes",
            Model = "C-Class",
            ProductionYear = 2019,
            EngineVolumeInCubicCentimeters = 2100
        },
        new Car
        {
            Manufacturer = "Chevrolet",
            Model = "Camaro",
            ProductionYear = 1967,
            EngineVolumeInCubicCentimeters = 4300
        },
        new Car
        {
            Manufacturer = "Ford",
            Model = "Fiesta",
            ProductionYear = 2018,
            EngineVolumeInCubicCentimeters = 1600
        },
        new Car
        {
            Manufacturer = "Ford",
            Model = "Focus",
            ProductionYear = 2020,
            EngineVolumeInCubicCentimeters = 2000
        },
        new Car
        {
            Manufacturer = "Ford",
            Model = "Escort",
            ProductionYear = 2016,
            EngineVolumeInCubicCentimeters = 1500
        }
    };
}
