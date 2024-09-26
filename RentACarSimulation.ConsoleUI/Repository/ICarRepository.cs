

using RentACarSimulation.ConsoleUI.Models;

namespace RentACarSimulation.ConsoleUI.Repository;

public interface ICarRepository : IRepository<Car,Guid>
{
    List<Car> GetAllByKilometerRange (int min, int max);
    List<Car> GetAllByModelNameContains(string modelName);
}
