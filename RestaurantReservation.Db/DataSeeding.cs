using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Enums;

namespace RestaurantReservation.Db;

public static class DataSeeding
{
  public static void Seed(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Customer>().HasData(GetCustomers());
    modelBuilder.Entity<Employee>().HasData(GetEmployees());
    modelBuilder.Entity<MenuItem>().HasData(GetMenuItems());
    modelBuilder.Entity<Order>().HasData(GetOrders());
    modelBuilder.Entity<OrderItem>().HasData(GetOrderItems());
    modelBuilder.Entity<Reservation>().HasData(GetReservations());
    modelBuilder.Entity<Restaurant>().HasData(GetRestaurants());
    modelBuilder.Entity<Table>().HasData(GetTables());
  }
  
  private static Customer[] GetCustomers() => new Customer[] {
    new()
    {
      CustomerId = 1,
      Email = "customer1@example.com",
      FirstName = "John",
      LastName = "Doe",
      PhoneNumber = "123-456-7890"
    },
    new()
    {
      CustomerId = 2,
      Email = "customer2@example.com",
      FirstName = "Jane",
      LastName = "Smith",
      PhoneNumber = "987-654-3210"
    },
    new()
    {
      CustomerId = 3,
      Email = "customer3@example.com",
      FirstName = "Mike",
      LastName = "Johnson",
      PhoneNumber = "555-123-4567"
    },
    new()
    {
      CustomerId = 4,
      Email = "customer4@example.com",
      FirstName = "Emily",
      LastName = "Wilson",
      PhoneNumber = "555-987-6543"
    },
    new()
    {
      CustomerId = 5,
      Email = "customer5@example.com",
      FirstName = "Chris",
      LastName = "Brown",
      PhoneNumber = "555-555-5555"
    }
  };
  
  private static Employee[] GetEmployees() => new Employee[] {
    new()
    {
      EmployeeId = 1,
      FirstName = "Alice",
      LastName = "Smith",
      Position = EmployeePosition.Manager,
      RestaurantId = 1
    },
    new()
    {
      EmployeeId = 2,
      FirstName = "Bob",
      LastName = "Johnson",
      Position = EmployeePosition.Chef,
      RestaurantId = 2
    },
    new()
    {
      EmployeeId = 3,
      FirstName = "Charlie",
      LastName = "Brown",
      Position = EmployeePosition.Manager,
      RestaurantId = 3
    },
    new()
    {
      EmployeeId = 4,
      FirstName = "David",
      LastName = "Wilson",
      Position = EmployeePosition.Waiter,
      RestaurantId = 4
    },
    new()
    {
      EmployeeId = 5,
      FirstName = "Eva",
      LastName = "Davis",
      Position = EmployeePosition.Bartender,
      RestaurantId = 5
    }
  };
  
  private static MenuItem[] GetMenuItems() => new MenuItem[] {
    new()
    {
      ItemId = 1,
      Description = "Delicious Burger",
      Name = "Burger",
      Price = 10.99m,
      RestaurantId = 1
    },
    new()
    {
      ItemId = 2,
      Description = "Classic Margherita Pizza",
      Name = "Margherita Pizza",
      Price = 12.99m,
      RestaurantId = 2
    },
    new()
    {
      ItemId = 3,
      Description = "Fresh Garden Salad",
      Name = "Garden Salad",
      Price = 7.99m,
      RestaurantId = 3
    },
    new()
    {
      ItemId = 4,
      Description = "Spaghetti with Meatballs",
      Name = "Spaghetti",
      Price = 14.99m,
      RestaurantId = 4
    },
    new()
    {
      ItemId = 5,
      Description = "Chocolate Brownie Sundae",
      Name = "Brownie Sundae",
      Price = 8.99m,
      RestaurantId = 5
    }
  };
  
  private static Order[] GetOrders() => new Order[] {
    new()
    {
      OrderId = 1,
      EmployeeId = 1,
      OrderDate = DateTime.Parse("2023-09-30 19:30:00"),
      ReservationId = 1,
      TotalAmount = 25
    },
    new()
    {
      OrderId = 2,
      EmployeeId = 2,
      OrderDate = DateTime.Parse("2023-10-02 20:00:00"),
      ReservationId = 2,
      TotalAmount = 12
    },
    new()
    {
      OrderId = 3,
      EmployeeId = 3,
      OrderDate = DateTime.Parse("2023-10-05 21:15:00"),
      ReservationId = 3,
      TotalAmount = 23
    },
    new()
    {
      OrderId = 4,
      EmployeeId = 4,
      OrderDate = DateTime.Parse("2023-10-07 18:45:00"),
      ReservationId = 4,
      TotalAmount = 29
    },
    new()
    {
      OrderId = 5,
      EmployeeId = 5,
      OrderDate = DateTime.Parse("2023-10-10 22:00:00"),
      ReservationId = 5,
      TotalAmount = 8
    }
  };
  
  private static OrderItem[] GetOrderItems() => new OrderItem[] {
    new()
    {
      OrderItemId = 1,
      ItemId = 1,
      OrderId = 1,
      Quantity = 2
    },
    new()
    {
      OrderItemId = 2,
      ItemId = 2,
      OrderId = 2,
      Quantity = 1
    },
    new()
    {
      OrderItemId = 3,
      ItemId = 3,
      OrderId = 3,
      Quantity = 3
    },
    new()
    {
      OrderItemId = 4,
      ItemId = 4,
      OrderId = 4,
      Quantity = 2
    },
    new()
    {
      OrderItemId = 5,
      ItemId = 5,
      OrderId = 5,
      Quantity = 1
    }
  };
  
  private static Reservation[] GetReservations() => new Reservation[] {
    new()
    {
      ReservationId = 1,
      CustomerId = 1,
      PartySize = 4,
      ReservationDate = DateTime.Parse("2023-09-30 18:00:00"),
      RestaurantId = 1,
      TableId = 1
    },
    new()
    {
      ReservationId = 2,
      CustomerId = 2,
      PartySize = 2,
      ReservationDate = DateTime.Parse("2023-10-02 19:30:00"),
      RestaurantId = 2,
      TableId = 2
    },
    new()
    {
      ReservationId = 3,
      CustomerId = 3,
      PartySize = 6,
      ReservationDate = DateTime.Parse("2023-10-05 20:15:00"),
      RestaurantId = 3,
      TableId = 3
    },
    new()
    {
      ReservationId = 4,
      CustomerId = 4,
      PartySize = 3,
      ReservationDate = DateTime.Parse("2023-10-07 17:45:00"),
      RestaurantId = 4,
      TableId = 4
    },
    new()
    {
      ReservationId = 5,
      CustomerId = 5,
      PartySize = 5,
      ReservationDate = DateTime.Parse("2023-10-10 21:00:00"),
      RestaurantId = 5,
      TableId = 5
    }
  };
  
  private static Restaurant[] GetRestaurants() => new Restaurant[] {
    new()
    {
      RestaurantId = 1,
      Address = "123 Main St",
      Name = "Restaurant A",
      OpeningHours = "9:00 AM - 10:00 PM",
      PhoneNumber = "555-123-4567"
    },
    new()
    {
      RestaurantId = 2,
      Address = "456 Elm St",
      Name = "Restaurant B",
      OpeningHours = "10:00 AM - 9:00 PM",
      PhoneNumber = "555-987-6543"
    },
    new()
    {
      RestaurantId = 3,
      Address = "789 Oak St",
      Name = "Restaurant C",
      OpeningHours = "8:00 AM - 11:00 PM",
      PhoneNumber = "555-111-2222"
    },
    new()
    {
      RestaurantId = 4,
      Address = "101 Pine St",
      Name = "Restaurant D",
      OpeningHours = "11:00 AM - 8:00 PM",
      PhoneNumber = "555-333-4444"
    },
    new()
    {
      RestaurantId = 5,
      Address = "222 Cedar St",
      Name = "Restaurant E",
      OpeningHours = "7:00 AM - 9:00 PM",
      PhoneNumber = "555-666-7777"
    }
  };
  
  private static Table[] GetTables() => new Table[] {
    new()
    {
      TableId = 1,
      Capacity = 4,
      RestaurantId = 1
    },
    new()
    {
      TableId = 2,
      Capacity = 2,
      RestaurantId = 2
    },
    new()
    {
      TableId = 3,
      Capacity = 6,
      RestaurantId = 3
    },
    new()
    {
      TableId = 4,
      Capacity = 3,
      RestaurantId = 4
    },
    new()
    {
      TableId = 5,
      Capacity = 5,
      RestaurantId = 5
    }
  };
}