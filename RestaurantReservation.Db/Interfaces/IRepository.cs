using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Db.Interfaces;

public interface IRepository<TEntity> where TEntity : Entity
{
  Task CreateAsync(TEntity entity);

  Task UpdateAsync(TEntity entity);

  Task DeleteAsync(int id);

  Task<bool> IsExistAsync(int id);
}