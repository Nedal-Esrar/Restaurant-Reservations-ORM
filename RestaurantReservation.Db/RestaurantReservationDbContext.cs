using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Db;

public class RestaurantReservationDbContext : DbContext
{
  public RestaurantReservationDbContext(DbContextOptions<RestaurantReservationDbContext> options) : base(options)
  {
  }
}