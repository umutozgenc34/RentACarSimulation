
using RentACarSimulation.ConsoleUI.Models;

namespace RentACarSimulation.ConsoleUI.Repository;

public interface IRepository <TEntity,TId> 
    where TEntity : Entity<TId>, new()
{
    TEntity? GetById(TId id);
    List<TEntity> GetAll();

    TEntity Add(TEntity entity);

    TEntity? Update(TId id, TEntity entity);
    TEntity? Delete(TId id);
}
