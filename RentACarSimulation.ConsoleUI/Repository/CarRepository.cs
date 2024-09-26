

using RentACarSimulation.ConsoleUI.Models;

namespace RentACarSimulation.ConsoleUI.Repository;

public sealed class CarRepository : BaseRepository, ICarRepository
{
    public Car Add(Car entity)
    {
        throw new NotImplementedException();
    }

    public Car? Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAllByKilometerRange(int min, int max)
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAllByModelNameContains(string modelName)
    {
        throw new NotImplementedException();
    }

    public Car? GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Car? Update(Guid id, Car entity)
    {
        throw new NotImplementedException();
    }
}
