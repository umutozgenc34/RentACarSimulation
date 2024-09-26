using RentACarSimulation.ConsoleUI.Models;

namespace RentACarSimulation.ConsoleUI.Repository;

public abstract class BaseRepository
{
    public List<Car> cars = new List<Car>
    {
         new Car(new Guid("{6762CE88-F211-45AE-9C67-60A4BF472A8E}"), 2, 1, 1, "Available", 50000, 2021, "34ABC123", "Toyota", "Corolla", 500),
         new Car(new Guid("{6762CE88-F211-45AE-9C67-60A4BF472A8A}"), 3, 2, 1, "Rented", 75000, 2020, "35XYZ456", "Honda", "Civic", 450),
         new Car(new Guid("{6762CE88-F211-45AE-9C67-60A4BF472A8Z}"), 1, 1, 2, "Maintenance", 65000, 2022, "36JKL789", "Ford", "Focus", 550),
         new Car(new Guid("{6762CE88-F211-45AE-9C67-60A4BF472A8B}"), 4, 1, 1, "Available", 30000, 2019, "37DEF123", "BMW", "320i", 700),
         new Car(new Guid("{6762CE88-F211-45AE-9C67-60A4BF472A8K}"), 5, 3, 2, "Rented", 120000, 2017, "38GHI456", "Mercedes", "C-Class", 800),
         new Car(new Guid("{6762CE88-F211-45AE-9C67-60A4BF472A8O}"), 2, 2, 1, "Available", 60000, 2020, "39JKL789", "Audi", "A4", 650)
    };

    public List<Colors> colors = new List<Colors>
    {
        new Colors(1, "Red"),
        new Colors(2, "Blue"),
        new Colors(3, "Black"),
        new Colors(4, "White"),
        new Colors(5, "Gray"),
        new Colors(6, "Silver")
    };

    public List<Fuel> fuels = new List<Fuel>
    {
        new Fuel(1, "Gasoline"),
        new Fuel(2, "Diesel"),
        new Fuel(3, "Electric"),
        new Fuel(4, "Hybrid"),
        new Fuel(5, "LPG"),
        new Fuel(6, "Hydrogen")
    };

    public List<Transmission> transmissions = new List<Transmission>
    {
        new Transmission(1, "Manual"),
        new Transmission(2, "Automatic"),
        new Transmission(3, "Semi-Automatic"),
        new Transmission(4, "CVT (Continuously Variable Transmission)")
    };
}
